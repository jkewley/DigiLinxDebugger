using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using DigiLinXLibrary.Device.Base;
using DigiLinXLibrary.Network.Packets;
using NetStreamsDebugger.Properties;
using NetStreamsDebugger.Support.Grids;

namespace NetStreamsDebugger {
    public partial class DebuggerForm : Form {
        private List<IBindingListViewGeneric> allBindingListViews;
        private BindingListView<NetStreamsPacket> allPacketView;
        private BindingListView<DriverPacket> driverView;
        private BindingListView<ErrorPacket> errorView;
        private BindingListView<GUIPacket> guiView;
        private BindingListView<InfoPacket> infoView;
        private BindingListView<WarningPacket> warningView;

        public DebuggerForm() {
            InitializeComponent();
            AddAllDevicesToClientFilterList();
            ReadInSavedFilters();
            BindNetworkInterfaces();
            BindFilterList();
            lnkAbout.Text = string.Format(lnkAbout.Text, Settings.Default.DebuggerVersion);
            SetupListeningWorker();
            ApplyGridStyles();
            BindDataGridViews();
            ApplySettings();
            UpdateFilterStatusLabel();
        }

        private void AddAllDevicesToClientFilterList() {
            DigiLinxDevice aDevice = new DigiLinxDevice();
            aDevice.IPAddress = IPAddress.Any;
            aDevice.ServiceName = "All Devices";
            clientsBindingSource.Add(aDevice);
        }

        /// <summary>
        /// Some grid styles are easier to do outside of the VS.Net designer
        /// </summary>
        private void ApplyGridStyles() {
            DataGridViewCellStyle rowStyle = new DataGridViewCellStyle();
            rowStyle.BackColor = Color.White;
            rowStyle.SelectionBackColor = Color.Cornsilk;
            rowStyle.SelectionForeColor = Color.Black;

            DataGridViewCellStyle alternatingStyle = new DataGridViewCellStyle(rowStyle);
            alternatingStyle.BackColor = Color.LightBlue;

            allGrid.AlternatingRowsDefaultCellStyle = alternatingStyle;
            allGrid.RowsDefaultCellStyle = rowStyle;
            driverGrid.AlternatingRowsDefaultCellStyle = alternatingStyle;
            driverGrid.RowsDefaultCellStyle = rowStyle;
            infoGrid.AlternatingRowsDefaultCellStyle = alternatingStyle;
            infoGrid.RowsDefaultCellStyle = rowStyle;
            warningGrid.AlternatingRowsDefaultCellStyle = alternatingStyle;
            warningGrid.RowsDefaultCellStyle = rowStyle;
            errorGrid.AlternatingRowsDefaultCellStyle = alternatingStyle;
            errorGrid.RowsDefaultCellStyle = rowStyle;
            guiGrid.AlternatingRowsDefaultCellStyle = alternatingStyle;
            guiGrid.RowsDefaultCellStyle = rowStyle;
        }

        /// <summary>
        /// Create grid views and predicates, and bind them to the grid. Add them to a collection for later use.
        /// </summary>
        private void BindDataGridViews() {
            //Create BindingListViews
            allPacketView = new BindingListView<NetStreamsPacket>(new List<NetStreamsPacket>());
            driverView = new BindingListView<DriverPacket>(new List<DriverPacket>());
            infoView = new BindingListView<InfoPacket>(new List<InfoPacket>());
            warningView = new BindingListView<WarningPacket>(new List<WarningPacket>());
            errorView = new BindingListView<ErrorPacket>(new List<ErrorPacket>());
            guiView = new BindingListView<GUIPacket>(new List<GUIPacket>());

            //Attach predicates
            allPacketView.FilterPredicate = WeWantToCapturePacket;
            driverView.FilterPredicate = WeWantToCapturePacket;
            infoView.FilterPredicate = WeWantToCapturePacket;
            warningView.FilterPredicate = WeWantToCapturePacket;
            errorView.FilterPredicate = WeWantToCapturePacket;
            guiView.FilterPredicate = WeWantToCapturePacket;

            //Bind to grids
            allGrid.DataSource = allPacketView;
            driverGrid.DataSource = driverView;
            infoGrid.DataSource = infoView;
            warningGrid.DataSource = warningView;
            errorGrid.DataSource = errorView;
            guiGrid.DataSource = guiView;

            //create a collection of binders
            allBindingListViews = new List<IBindingListViewGeneric>();
            allBindingListViews.Add(allPacketView);
            allBindingListViews.Add(driverView);
            allBindingListViews.Add(infoView);
            allBindingListViews.Add(warningView);
            allBindingListViews.Add(errorView);
            allBindingListViews.Add(guiView);
        }

        /// <summary>
        /// User-action based settings need to be fired
        /// </summary>
        private void ApplySettings() {
            if(Settings.Default.LargeSystemBehavior) chkLargeSystem_CheckedChanged(null, null);
        }

        /// <summary>
        /// Save settings when the app closes
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(CancelEventArgs e) {
            base.OnClosing(e);
            Settings.Default.Save();
        }

        private void ScrollAndUpdateGrids() {
            if(Settings.Default.AutoScroll) {
                if(allGrid.RowCount > 0) allGrid.FirstDisplayedCell = allGrid.Rows[allGrid.RowCount - 1].Cells[0];
                if(driverGrid.RowCount > 0) driverGrid.FirstDisplayedCell = driverGrid.Rows[driverGrid.RowCount - 1].Cells[0];
                if(infoGrid.RowCount > 0) infoGrid.FirstDisplayedCell = infoGrid.Rows[infoGrid.RowCount - 1].Cells[0];
                if(warningGrid.RowCount > 0) warningGrid.FirstDisplayedCell = warningGrid.Rows[warningGrid.RowCount - 1].Cells[0];
                if(errorGrid.RowCount > 0) errorGrid.FirstDisplayedCell = errorGrid.Rows[errorGrid.RowCount - 1].Cells[0];
                if(guiGrid.RowCount > 0) guiGrid.FirstDisplayedCell = guiGrid.Rows[guiGrid.RowCount - 1].Cells[0];
            }
            UpdateTabLabels();
        }

        private void UpdateTabLabels() {
            tabAll.Text = string.Format("All Messages ({0})", allGrid.RowCount);
            tabDriver.Text = string.Format("Driver Messages ({0})", driverGrid.RowCount);
            tabInfo.Text = string.Format("Info Messages ({0})", infoGrid.RowCount);
            tabWarning.Text = string.Format("Warning Messages ({0})", warningGrid.RowCount);
            tabError.Text = string.Format("Error Messages ({0})", errorGrid.RowCount);
            tabGUI.Text = string.Format("GUI Messages ({0})", guiGrid.RowCount);
        }

        private void GridFilterApplied(object sender, EventArgs e) {
            DoApplyAllFilters();
        }

        private void CollapseExpandOptionsPane(object sender, EventArgs e) {
            int collapsedWidth = splitContainer.Width - splitContainer.SplitterWidth - 14;
            bool splitterIsCollapsed = splitContainer.SplitterDistance == collapsedWidth;
            splitContainer.SplitterDistance = splitterIsCollapsed ? splitContainer.Width - 264 : splitContainer.Width - 14;
            butMoreLess.Text = splitterIsCollapsed ? ">>" : "<<";
        }

        private void lnkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(string.Format("http://wiredright.wordpress.com?fromDebugger={0}", Settings.Default.DebuggerVersion));
        }

        private void btnClear_Click(object sender, EventArgs e) {
            theAllLogger.Info("Grids Cleared");
            foreach (IBindingListViewGeneric view in allBindingListViews) 
                view.Clear();
            UpdateTabLabels();
        }

        private void ShowMessageDetail(object sender, DataGridViewCellEventArgs e) {
            NetStreamsPacket netStreamsPacket = (NetStreamsPacket) allGrid.Rows[e.RowIndex].DataBoundItem;
            Debug.WriteLine("Clicked On " + netStreamsPacket.Device.DeviceName);
            DeviceDetailForm detail = new DeviceDetailForm(netStreamsPacket);
            detail.Show();
        }
    }
}