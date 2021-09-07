
namespace NetStreamsDebugger {
    partial class DebuggerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebuggerForm));
            this.butStartStop = new System.Windows.Forms.Button();
            this.allMessagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driverMessagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infoMessagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warningMessagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorMessagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmboDevices = new System.Windows.Forms.ComboBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkAutoScroll = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.tabCntrl = new System.Windows.Forms.TabControl();
            this.tabAll = new System.Windows.Forms.TabPage();
            this.allGrid = new System.Windows.Forms.DataGridView();
            this.messageTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStampHexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netStreamsPacketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabDriver = new System.Windows.Forms.TabPage();
            this.driverGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReadableTimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStampHexDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReducedMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.infoGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabWarning = new System.Windows.Forms.TabPage();
            this.warningGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabError = new System.Windows.Forms.TabPage();
            this.errorGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabGUI = new System.Windows.Forms.TabPage();
            this.guiGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.chkCaptureGUI = new System.Windows.Forms.CheckBox();
            this.chkErrorMessages = new System.Windows.Forms.CheckBox();
            this.chkWarningMessages = new System.Windows.Forms.CheckBox();
            this.chkInfoMessages = new System.Windows.Forms.CheckBox();
            this.chkDriverMessages = new System.Windows.Forms.CheckBox();
            this.lnkAbout = new System.Windows.Forms.LinkLabel();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.lnkExcluded = new System.Windows.Forms.LinkLabel();
            this.lnkClearFilters = new System.Windows.Forms.LinkLabel();
            this.lblExcludedList = new System.Windows.Forms.Label();
            this.lblIncludedList = new System.Windows.Forms.Label();
            this.lnkIncluded = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxDisplay = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNetworkInterface = new System.Windows.Forms.ComboBox();
            this.chkLargeSystem = new System.Windows.Forms.CheckBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.butMoreLess = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxLogging = new System.Windows.Forms.GroupBox();
            this.chkApplyFilterToLog = new System.Windows.Forms.CheckBox();
            this.chkLogOnlySelected = new System.Windows.Forms.CheckBox();
            this.loggingDirLabel = new System.Windows.Forms.LinkLabel();
            this.lblWorkingDir = new System.Windows.Forms.Label();
            this.chkEnableLogging = new System.Windows.Forms.CheckBox();
            this.filterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.allMessagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverMessagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoMessagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warningMessagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMessagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabCntrl.SuspendLayout();
            this.tabAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netStreamsPacketBindingSource)).BeginInit();
            this.tabDriver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverGrid)).BeginInit();
            this.tabInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoGrid)).BeginInit();
            this.tabWarning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warningGrid)).BeginInit();
            this.tabError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorGrid)).BeginInit();
            this.tabGUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guiGrid)).BeginInit();
            this.groupBoxData.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxDisplay.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.groupBoxLogging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // butStartStop
            // 
            this.butStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butStartStop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.butStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.butStartStop.Location = new System.Drawing.Point(588, 5);
            this.butStartStop.Margin = new System.Windows.Forms.Padding(0);
            this.butStartStop.Name = "butStartStop";
            this.butStartStop.Size = new System.Drawing.Size(75, 22);
            this.butStartStop.TabIndex = 2;
            this.butStartStop.Text = "Start";
            this.toolTip1.SetToolTip(this.butStartStop, "Start and stop the capture of DigilLinX messages");
            this.butStartStop.UseVisualStyleBackColor = true;
            this.butStartStop.Click += new System.EventHandler(this.ButtonToggleNetworkMonitor);
            // 
            // allMessagesBindingSource
            // 
            this.allMessagesBindingSource.DataSource = typeof(DigiLinXLibrary.Network.Packets.NetStreamsPacket);
            // 
            // driverMessagesBindingSource
            // 
            this.driverMessagesBindingSource.AllowNew = false;
            this.driverMessagesBindingSource.DataSource = typeof(DigiLinXLibrary.Network.Packets.DriverPacket);
            // 
            // infoMessagesBindingSource
            // 
            this.infoMessagesBindingSource.DataSource = typeof(DigiLinXLibrary.Network.Packets.InfoPacket);
            // 
            // warningMessagesBindingSource
            // 
            this.warningMessagesBindingSource.DataSource = typeof(DigiLinXLibrary.Network.Packets.WarningPacket);
            // 
            // errorMessagesBindingSource
            // 
            this.errorMessagesBindingSource.DataSource = typeof(DigiLinXLibrary.Network.Packets.ErrorPacket);
            // 
            // cmboDevices
            // 
            this.cmboDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmboDevices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.cmboDevices.DataSource = this.clientsBindingSource;
            this.cmboDevices.DisplayMember = "IPAndName";
            this.cmboDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboDevices.FormattingEnabled = true;
            this.cmboDevices.Location = new System.Drawing.Point(6, 150);
            this.cmboDevices.Name = "cmboDevices";
            this.cmboDevices.Size = new System.Drawing.Size(215, 21);
            this.cmboDevices.TabIndex = 4;
            this.toolTip1.SetToolTip(this.cmboDevices, "Show only the messages that originate with the selected device");
            this.cmboDevices.ValueMember = "IPAddress";
            this.cmboDevices.SelectedValueChanged += new System.EventHandler(this.GridFilterApplied);
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataSource = typeof(DigiLinXLibrary.Device.Base.DigiLinxDevice);
            // 
            // chkAutoScroll
            // 
            this.chkAutoScroll.AutoSize = true;
            this.chkAutoScroll.Checked = global::NetStreamsDebugger.Properties.Settings.Default.AutoScroll;
            this.chkAutoScroll.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::NetStreamsDebugger.Properties.Settings.Default, "AutoScroll", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAutoScroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoScroll.Location = new System.Drawing.Point(9, 20);
            this.chkAutoScroll.Name = "chkAutoScroll";
            this.chkAutoScroll.Size = new System.Drawing.Size(104, 17);
            this.chkAutoScroll.TabIndex = 5;
            this.chkAutoScroll.Text = "Auto Scroll Grids";
            this.toolTip1.SetToolTip(this.chkAutoScroll, "Automatically scroll the grids as new messages arrive. \r\nThis can slow down the p" +
                    "erformace of the debugger, so it is not \r\nrecommended when debugging large syste" +
                    "ms.");
            this.chkAutoScroll.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Device Filter:";
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.splitContainer.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer.Panel1.Controls.Add(this.panel2);
            this.splitContainer.Panel1.Controls.Add(this.tabCntrl);
            this.splitContainer.Panel1MinSize = 400;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.splitContainer.Panel2.BackgroundImage = global::NetStreamsDebugger.Properties.Resources.OptionsBackground;
            this.splitContainer.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer.Panel2.Controls.Add(this.groupBoxData);
            this.splitContainer.Panel2.Controls.Add(this.lnkAbout);
            this.splitContainer.Panel2.Controls.Add(this.grpFilter);
            this.splitContainer.Panel2.Controls.Add(this.panel1);
            this.splitContainer.Panel2.Controls.Add(this.pnlTop);
            this.splitContainer.Panel2.Controls.Add(this.groupBoxLogging);
            this.splitContainer.Panel2MinSize = 14;
            this.splitContainer.Size = new System.Drawing.Size(939, 638);
            this.splitContainer.SplitterDistance = 675;
            this.splitContainer.TabIndex = 7;
            this.splitContainer.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = global::NetStreamsDebugger.Properties.Resources.VistaToolbar;
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.butStartStop);
            this.panel2.Location = new System.Drawing.Point(0, 604);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 34);
            this.panel2.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(496, 5);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 22);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.toolTip1.SetToolTip(this.btnClear, "Clear all messages that have been captured");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tabCntrl
            // 
            this.tabCntrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCntrl.Controls.Add(this.tabAll);
            this.tabCntrl.Controls.Add(this.tabDriver);
            this.tabCntrl.Controls.Add(this.tabInfo);
            this.tabCntrl.Controls.Add(this.tabWarning);
            this.tabCntrl.Controls.Add(this.tabError);
            this.tabCntrl.Controls.Add(this.tabGUI);
            this.tabCntrl.HotTrack = true;
            this.tabCntrl.ItemSize = new System.Drawing.Size(74, 23);
            this.tabCntrl.Location = new System.Drawing.Point(0, 10);
            this.tabCntrl.Margin = new System.Windows.Forms.Padding(0);
            this.tabCntrl.Name = "tabCntrl";
            this.tabCntrl.SelectedIndex = 0;
            this.tabCntrl.Size = new System.Drawing.Size(674, 595);
            this.tabCntrl.TabIndex = 4;
            // 
            // tabAll
            // 
            this.tabAll.Controls.Add(this.allGrid);
            this.tabAll.Location = new System.Drawing.Point(4, 27);
            this.tabAll.Name = "tabAll";
            this.tabAll.Padding = new System.Windows.Forms.Padding(3);
            this.tabAll.Size = new System.Drawing.Size(666, 564);
            this.tabAll.TabIndex = 0;
            this.tabAll.Text = "All Messages";
            this.tabAll.UseVisualStyleBackColor = true;
            // 
            // allGrid
            // 
            this.allGrid.AllowUserToAddRows = false;
            this.allGrid.AllowUserToDeleteRows = false;
            this.allGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Cornsilk;
            this.allGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.allGrid.AutoGenerateColumns = false;
            this.allGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.messageTypeDataGridViewTextBoxColumn,
            this.Device,
            this.TimeStamp,
            this.timeStampHexDataGridViewTextBoxColumn,
            this.messageDataGridViewTextBoxColumn});
            this.allGrid.DataSource = this.netStreamsPacketBindingSource;
            this.allGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allGrid.Location = new System.Drawing.Point(3, 3);
            this.allGrid.MultiSelect = false;
            this.allGrid.Name = "allGrid";
            this.allGrid.ReadOnly = true;
            this.allGrid.RowHeadersWidth = 20;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Cornsilk;
            this.allGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.allGrid.RowTemplate.Height = 18;
            this.allGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allGrid.Size = new System.Drawing.Size(660, 558);
            this.allGrid.TabIndex = 0;
            this.allGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowMessageDetail);
            // 
            // messageTypeDataGridViewTextBoxColumn
            // 
            this.messageTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.messageTypeDataGridViewTextBoxColumn.DataPropertyName = "MessageType";
            this.messageTypeDataGridViewTextBoxColumn.FillWeight = 34.8432F;
            this.messageTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.messageTypeDataGridViewTextBoxColumn.Name = "messageTypeDataGridViewTextBoxColumn";
            this.messageTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.messageTypeDataGridViewTextBoxColumn.Width = 56;
            // 
            // Device
            // 
            this.Device.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Device.DataPropertyName = "Device";
            this.Device.HeaderText = "Device";
            this.Device.Name = "Device";
            this.Device.ReadOnly = true;
            this.Device.Width = 66;
            // 
            // TimeStamp
            // 
            this.TimeStamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TimeStamp.DataPropertyName = "ReadableTimeStamp";
            this.TimeStamp.HeaderText = "Time Stamp";
            this.TimeStamp.Name = "TimeStamp";
            this.TimeStamp.ReadOnly = true;
            this.TimeStamp.Width = 88;
            // 
            // timeStampHexDataGridViewTextBoxColumn
            // 
            this.timeStampHexDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.timeStampHexDataGridViewTextBoxColumn.DataPropertyName = "TimeStampHex";
            this.timeStampHexDataGridViewTextBoxColumn.FillWeight = 34.8432F;
            this.timeStampHexDataGridViewTextBoxColumn.HeaderText = "Message ID";
            this.timeStampHexDataGridViewTextBoxColumn.Name = "timeStampHexDataGridViewTextBoxColumn";
            this.timeStampHexDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeStampHexDataGridViewTextBoxColumn.Width = 89;
            // 
            // messageDataGridViewTextBoxColumn
            // 
            this.messageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.messageDataGridViewTextBoxColumn.DataPropertyName = "Message";
            this.messageDataGridViewTextBoxColumn.FillWeight = 230.3136F;
            this.messageDataGridViewTextBoxColumn.HeaderText = "Message";
            this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            this.messageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // netStreamsPacketBindingSource
            // 
            this.netStreamsPacketBindingSource.DataSource = typeof(DigiLinXLibrary.Network.Packets.NetStreamsPacket);
            // 
            // tabDriver
            // 
            this.tabDriver.Controls.Add(this.driverGrid);
            this.tabDriver.Location = new System.Drawing.Point(4, 27);
            this.tabDriver.Name = "tabDriver";
            this.tabDriver.Padding = new System.Windows.Forms.Padding(3);
            this.tabDriver.Size = new System.Drawing.Size(666, 564);
            this.tabDriver.TabIndex = 2;
            this.tabDriver.Text = "Driver Messages";
            this.tabDriver.UseVisualStyleBackColor = true;
            // 
            // driverGrid
            // 
            this.driverGrid.AllowUserToAddRows = false;
            this.driverGrid.AllowUserToDeleteRows = false;
            this.driverGrid.AllowUserToOrderColumns = true;
            this.driverGrid.AllowUserToResizeRows = false;
            this.driverGrid.AutoGenerateColumns = false;
            this.driverGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.driverGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.ReadableTimeStamp,
            this.timeStampHexDataGridViewTextBoxColumn1,
            this.DriverDevice,
            this.Category,
            this.ReducedMessage});
            this.driverGrid.DataSource = this.driverMessagesBindingSource;
            this.driverGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driverGrid.Location = new System.Drawing.Point(3, 3);
            this.driverGrid.MultiSelect = false;
            this.driverGrid.Name = "driverGrid";
            this.driverGrid.ReadOnly = true;
            this.driverGrid.RowHeadersWidth = 20;
            this.driverGrid.RowTemplate.Height = 18;
            this.driverGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.driverGrid.Size = new System.Drawing.Size(660, 558);
            this.driverGrid.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Device";
            this.dataGridViewTextBoxColumn10.HeaderText = "Device";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 66;
            // 
            // ReadableTimeStamp
            // 
            this.ReadableTimeStamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ReadableTimeStamp.DataPropertyName = "ReadableTimeStamp";
            this.ReadableTimeStamp.HeaderText = "Time Stamp";
            this.ReadableTimeStamp.Name = "ReadableTimeStamp";
            this.ReadableTimeStamp.ReadOnly = true;
            this.ReadableTimeStamp.Width = 88;
            // 
            // timeStampHexDataGridViewTextBoxColumn1
            // 
            this.timeStampHexDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.timeStampHexDataGridViewTextBoxColumn1.DataPropertyName = "TimeStampHex";
            this.timeStampHexDataGridViewTextBoxColumn1.HeaderText = "Message ID";
            this.timeStampHexDataGridViewTextBoxColumn1.Name = "timeStampHexDataGridViewTextBoxColumn1";
            this.timeStampHexDataGridViewTextBoxColumn1.ReadOnly = true;
            this.timeStampHexDataGridViewTextBoxColumn1.Width = 89;
            // 
            // DriverDevice
            // 
            this.DriverDevice.DataPropertyName = "DriverDevice";
            this.DriverDevice.HeaderText = "Name";
            this.DriverDevice.Name = "DriverDevice";
            this.DriverDevice.ReadOnly = true;
            this.DriverDevice.Width = 75;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 75;
            // 
            // ReducedMessage
            // 
            this.ReducedMessage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReducedMessage.DataPropertyName = "ReducedMessage";
            this.ReducedMessage.HeaderText = "Message";
            this.ReducedMessage.Name = "ReducedMessage";
            this.ReducedMessage.ReadOnly = true;
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.infoGrid);
            this.tabInfo.Location = new System.Drawing.Point(4, 27);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(666, 564);
            this.tabInfo.TabIndex = 1;
            this.tabInfo.Text = "Info Messages";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // infoGrid
            // 
            this.infoGrid.AllowUserToAddRows = false;
            this.infoGrid.AllowUserToDeleteRows = false;
            this.infoGrid.AllowUserToResizeRows = false;
            this.infoGrid.AutoGenerateColumns = false;
            this.infoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn11});
            this.infoGrid.DataSource = this.infoMessagesBindingSource;
            this.infoGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoGrid.Location = new System.Drawing.Point(3, 3);
            this.infoGrid.MultiSelect = false;
            this.infoGrid.Name = "infoGrid";
            this.infoGrid.ReadOnly = true;
            this.infoGrid.RowHeadersWidth = 20;
            this.infoGrid.RowTemplate.Height = 18;
            this.infoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.infoGrid.Size = new System.Drawing.Size(660, 558);
            this.infoGrid.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Device";
            this.dataGridViewTextBoxColumn3.HeaderText = "Device";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 66;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ReadableTimeStamp";
            this.dataGridViewTextBoxColumn1.HeaderText = "Time Stamp";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 88;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TimeStampHex";
            this.dataGridViewTextBoxColumn2.HeaderText = "Message ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 89;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Message";
            this.dataGridViewTextBoxColumn11.HeaderText = "Message";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // tabWarning
            // 
            this.tabWarning.Controls.Add(this.warningGrid);
            this.tabWarning.Location = new System.Drawing.Point(4, 27);
            this.tabWarning.Name = "tabWarning";
            this.tabWarning.Padding = new System.Windows.Forms.Padding(3);
            this.tabWarning.Size = new System.Drawing.Size(666, 564);
            this.tabWarning.TabIndex = 3;
            this.tabWarning.Text = "Warning Messages";
            this.tabWarning.UseVisualStyleBackColor = true;
            // 
            // warningGrid
            // 
            this.warningGrid.AllowUserToAddRows = false;
            this.warningGrid.AllowUserToDeleteRows = false;
            this.warningGrid.AllowUserToResizeRows = false;
            this.warningGrid.AutoGenerateColumns = false;
            this.warningGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.warningGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn12});
            this.warningGrid.DataSource = this.warningMessagesBindingSource;
            this.warningGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.warningGrid.Location = new System.Drawing.Point(3, 3);
            this.warningGrid.MultiSelect = false;
            this.warningGrid.Name = "warningGrid";
            this.warningGrid.ReadOnly = true;
            this.warningGrid.RowHeadersWidth = 20;
            this.warningGrid.RowTemplate.Height = 18;
            this.warningGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.warningGrid.Size = new System.Drawing.Size(660, 558);
            this.warningGrid.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Device";
            this.dataGridViewTextBoxColumn5.HeaderText = "Device";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 66;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ReadableTimeStamp";
            this.dataGridViewTextBoxColumn4.HeaderText = "Time Stamp";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 88;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TimeStampHex";
            this.dataGridViewTextBoxColumn6.HeaderText = "Message ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 89;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Message";
            this.dataGridViewTextBoxColumn12.HeaderText = "Message";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // tabError
            // 
            this.tabError.Controls.Add(this.errorGrid);
            this.tabError.Location = new System.Drawing.Point(4, 27);
            this.tabError.Name = "tabError";
            this.tabError.Padding = new System.Windows.Forms.Padding(3);
            this.tabError.Size = new System.Drawing.Size(666, 564);
            this.tabError.TabIndex = 4;
            this.tabError.Text = "Error Messages";
            this.tabError.UseVisualStyleBackColor = true;
            // 
            // errorGrid
            // 
            this.errorGrid.AllowUserToAddRows = false;
            this.errorGrid.AllowUserToDeleteRows = false;
            this.errorGrid.AllowUserToResizeRows = false;
            this.errorGrid.AutoGenerateColumns = false;
            this.errorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.errorGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn13});
            this.errorGrid.DataSource = this.errorMessagesBindingSource;
            this.errorGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorGrid.Location = new System.Drawing.Point(3, 3);
            this.errorGrid.MultiSelect = false;
            this.errorGrid.Name = "errorGrid";
            this.errorGrid.ReadOnly = true;
            this.errorGrid.RowHeadersWidth = 20;
            this.errorGrid.RowTemplate.Height = 18;
            this.errorGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.errorGrid.Size = new System.Drawing.Size(660, 558);
            this.errorGrid.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Device";
            this.dataGridViewTextBoxColumn8.HeaderText = "Device";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 66;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ReadableTimeStamp";
            this.dataGridViewTextBoxColumn7.HeaderText = "Time Stamp";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 88;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TimeStampHex";
            this.dataGridViewTextBoxColumn9.HeaderText = "Message ID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 89;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Message";
            this.dataGridViewTextBoxColumn13.HeaderText = "Message";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // tabGUI
            // 
            this.tabGUI.Controls.Add(this.guiGrid);
            this.tabGUI.Location = new System.Drawing.Point(4, 27);
            this.tabGUI.Name = "tabGUI";
            this.tabGUI.Padding = new System.Windows.Forms.Padding(3);
            this.tabGUI.Size = new System.Drawing.Size(666, 564);
            this.tabGUI.TabIndex = 5;
            this.tabGUI.Text = "GUI Messages";
            this.tabGUI.UseVisualStyleBackColor = true;
            // 
            // guiGrid
            // 
            this.guiGrid.AllowUserToAddRows = false;
            this.guiGrid.AllowUserToDeleteRows = false;
            this.guiGrid.AllowUserToResizeRows = false;
            this.guiGrid.AutoGenerateColumns = false;
            this.guiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guiGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.guiGrid.DataSource = this.driverMessagesBindingSource;
            this.guiGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guiGrid.Location = new System.Drawing.Point(3, 3);
            this.guiGrid.MultiSelect = false;
            this.guiGrid.Name = "guiGrid";
            this.guiGrid.ReadOnly = true;
            this.guiGrid.RowHeadersWidth = 20;
            this.guiGrid.RowTemplate.Height = 18;
            this.guiGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guiGrid.Size = new System.Drawing.Size(660, 558);
            this.guiGrid.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Device";
            this.dataGridViewTextBoxColumn14.HeaderText = "Device";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 66;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "ReadableTimeStamp";
            this.dataGridViewTextBoxColumn15.HeaderText = "Time Stamp";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 88;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn16.DataPropertyName = "TimeStampHex";
            this.dataGridViewTextBoxColumn16.HeaderText = "Message ID";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 89;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Message";
            this.dataGridViewTextBoxColumn17.HeaderText = "Message";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // groupBoxData
            // 
            this.groupBoxData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxData.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxData.Controls.Add(this.chkCaptureGUI);
            this.groupBoxData.Controls.Add(this.chkErrorMessages);
            this.groupBoxData.Controls.Add(this.chkWarningMessages);
            this.groupBoxData.Controls.Add(this.chkInfoMessages);
            this.groupBoxData.Controls.Add(this.chkDriverMessages);
            this.groupBoxData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(141)))));
            this.groupBoxData.Location = new System.Drawing.Point(14, 165);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(231, 147);
            this.groupBoxData.TabIndex = 7;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Data Gathering";
            // 
            // chkCaptureGUI
            // 
            this.chkCaptureGUI.AutoSize = true;
            this.chkCaptureGUI.Checked = true;
            this.chkCaptureGUI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCaptureGUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkCaptureGUI.Location = new System.Drawing.Point(9, 118);
            this.chkCaptureGUI.Name = "chkCaptureGUI";
            this.chkCaptureGUI.Size = new System.Drawing.Size(96, 17);
            this.chkCaptureGUI.TabIndex = 4;
            this.chkCaptureGUI.Text = "GUI Messages";
            this.chkCaptureGUI.UseVisualStyleBackColor = true;
            // 
            // chkErrorMessages
            // 
            this.chkErrorMessages.AutoSize = true;
            this.chkErrorMessages.Checked = global::NetStreamsDebugger.Properties.Settings.Default.CaptureError;
            this.chkErrorMessages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkErrorMessages.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::NetStreamsDebugger.Properties.Settings.Default, "CaptureError", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkErrorMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkErrorMessages.Location = new System.Drawing.Point(9, 94);
            this.chkErrorMessages.Name = "chkErrorMessages";
            this.chkErrorMessages.Size = new System.Drawing.Size(99, 17);
            this.chkErrorMessages.TabIndex = 3;
            this.chkErrorMessages.Text = "Error Messages";
            this.chkErrorMessages.UseVisualStyleBackColor = true;
            // 
            // chkWarningMessages
            // 
            this.chkWarningMessages.AutoSize = true;
            this.chkWarningMessages.Checked = global::NetStreamsDebugger.Properties.Settings.Default.CaptureWarning;
            this.chkWarningMessages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWarningMessages.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::NetStreamsDebugger.Properties.Settings.Default, "CaptureWarning", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWarningMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWarningMessages.Location = new System.Drawing.Point(9, 70);
            this.chkWarningMessages.Name = "chkWarningMessages";
            this.chkWarningMessages.Size = new System.Drawing.Size(117, 17);
            this.chkWarningMessages.TabIndex = 2;
            this.chkWarningMessages.Text = "Warning Messages";
            this.chkWarningMessages.UseVisualStyleBackColor = true;
            // 
            // chkInfoMessages
            // 
            this.chkInfoMessages.AutoSize = true;
            this.chkInfoMessages.Checked = global::NetStreamsDebugger.Properties.Settings.Default.CaptureInfo;
            this.chkInfoMessages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInfoMessages.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::NetStreamsDebugger.Properties.Settings.Default, "CaptureInfo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkInfoMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInfoMessages.Location = new System.Drawing.Point(9, 46);
            this.chkInfoMessages.Name = "chkInfoMessages";
            this.chkInfoMessages.Size = new System.Drawing.Size(95, 17);
            this.chkInfoMessages.TabIndex = 1;
            this.chkInfoMessages.Text = "Info Messages";
            this.chkInfoMessages.UseVisualStyleBackColor = true;
            // 
            // chkDriverMessages
            // 
            this.chkDriverMessages.AutoSize = true;
            this.chkDriverMessages.Checked = global::NetStreamsDebugger.Properties.Settings.Default.CaptureDriver;
            this.chkDriverMessages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDriverMessages.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::NetStreamsDebugger.Properties.Settings.Default, "CaptureDriver", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkDriverMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDriverMessages.Location = new System.Drawing.Point(9, 22);
            this.chkDriverMessages.Name = "chkDriverMessages";
            this.chkDriverMessages.Size = new System.Drawing.Size(105, 17);
            this.chkDriverMessages.TabIndex = 0;
            this.chkDriverMessages.Text = "Driver Messages";
            this.chkDriverMessages.UseVisualStyleBackColor = true;
            // 
            // lnkAbout
            // 
            this.lnkAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkAbout.AutoSize = true;
            this.lnkAbout.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.lnkAbout.Location = new System.Drawing.Point(53, 618);
            this.lnkAbout.Name = "lnkAbout";
            this.lnkAbout.Size = new System.Drawing.Size(166, 13);
            this.lnkAbout.TabIndex = 8;
            this.lnkAbout.TabStop = true;
            this.lnkAbout.Text = "NetStreams Debugger v{0} BETA";
            this.lnkAbout.VisitedLinkColor = System.Drawing.Color.Black;
            this.lnkAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAbout_LinkClicked);
            // 
            // grpFilter
            // 
            this.grpFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFilter.BackColor = System.Drawing.Color.Transparent;
            this.grpFilter.Controls.Add(this.lnkExcluded);
            this.grpFilter.Controls.Add(this.label1);
            this.grpFilter.Controls.Add(this.lnkClearFilters);
            this.grpFilter.Controls.Add(this.lblExcludedList);
            this.grpFilter.Controls.Add(this.cmboDevices);
            this.grpFilter.Controls.Add(this.lblIncludedList);
            this.grpFilter.Controls.Add(this.lnkIncluded);
            this.grpFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(141)))));
            this.grpFilter.Location = new System.Drawing.Point(14, 436);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(231, 179);
            this.grpFilter.TabIndex = 11;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter Messages";
            this.toolTip1.SetToolTip(this.grpFilter, "Use the drop down to show only matching messages, or click Manage to enable multi" +
                    "ple filters.");
            // 
            // lnkExcluded
            // 
            this.lnkExcluded.AutoSize = true;
            this.lnkExcluded.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.lnkExcluded.Location = new System.Drawing.Point(6, 77);
            this.lnkExcluded.Name = "lnkExcluded";
            this.lnkExcluded.Size = new System.Drawing.Size(119, 13);
            this.lnkExcluded.TabIndex = 13;
            this.lnkExcluded.TabStop = true;
            this.lnkExcluded.Text = "Excluded Messages";
            this.lnkExcluded.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClickManageFiltersLink);
            // 
            // lnkClearFilters
            // 
            this.lnkClearFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkClearFilters.AutoSize = true;
            this.lnkClearFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkClearFilters.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.lnkClearFilters.Location = new System.Drawing.Point(164, 20);
            this.lnkClearFilters.Name = "lnkClearFilters";
            this.lnkClearFilters.Size = new System.Drawing.Size(61, 13);
            this.lnkClearFilters.TabIndex = 12;
            this.lnkClearFilters.TabStop = true;
            this.lnkClearFilters.Text = "Clear Filters";
            this.lnkClearFilters.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClickClearFiltersLink);
            // 
            // lblExcludedList
            // 
            this.lblExcludedList.AutoEllipsis = true;
            this.lblExcludedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblExcludedList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(140)))));
            this.lblExcludedList.Location = new System.Drawing.Point(6, 90);
            this.lblExcludedList.Name = "lblExcludedList";
            this.lblExcludedList.Size = new System.Drawing.Size(218, 35);
            this.lblExcludedList.TabIndex = 11;
            this.lblExcludedList.Text = "Excluded";
            // 
            // lblIncludedList
            // 
            this.lblIncludedList.AutoEllipsis = true;
            this.lblIncludedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblIncludedList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(140)))));
            this.lblIncludedList.Location = new System.Drawing.Point(6, 33);
            this.lblIncludedList.Name = "lblIncludedList";
            this.lblIncludedList.Size = new System.Drawing.Size(218, 35);
            this.lblIncludedList.TabIndex = 10;
            this.lblIncludedList.Text = "Included";
            // 
            // lnkIncluded
            // 
            this.lnkIncluded.AutoSize = true;
            this.lnkIncluded.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.lnkIncluded.Location = new System.Drawing.Point(6, 20);
            this.lnkIncluded.Name = "lnkIncluded";
            this.lnkIncluded.Size = new System.Drawing.Size(116, 13);
            this.lnkIncluded.TabIndex = 6;
            this.lnkIncluded.TabStop = true;
            this.lnkIncluded.Text = "Included Messages";
            this.lnkIncluded.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClickManageFiltersLink);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = global::NetStreamsDebugger.Properties.Resources.OptionsBackground;
            this.panel1.Controls.Add(this.groupBoxDisplay);
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 144);
            this.panel1.TabIndex = 10;
            // 
            // groupBoxDisplay
            // 
            this.groupBoxDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDisplay.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDisplay.Controls.Add(this.label3);
            this.groupBoxDisplay.Controls.Add(this.cmbNetworkInterface);
            this.groupBoxDisplay.Controls.Add(this.chkLargeSystem);
            this.groupBoxDisplay.Controls.Add(this.chkAutoScroll);
            this.groupBoxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(141)))));
            this.groupBoxDisplay.Location = new System.Drawing.Point(14, 11);
            this.groupBoxDisplay.Name = "groupBoxDisplay";
            this.groupBoxDisplay.Size = new System.Drawing.Size(231, 110);
            this.groupBoxDisplay.TabIndex = 6;
            this.groupBoxDisplay.TabStop = false;
            this.groupBoxDisplay.Text = "Configuration";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Use Network Interface:";
            // 
            // cmbNetworkInterface
            // 
            this.cmbNetworkInterface.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.cmbNetworkInterface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNetworkInterface.FormattingEnabled = true;
            this.cmbNetworkInterface.Location = new System.Drawing.Point(6, 83);
            this.cmbNetworkInterface.Name = "cmbNetworkInterface";
            this.cmbNetworkInterface.Size = new System.Drawing.Size(215, 21);
            this.cmbNetworkInterface.TabIndex = 6;
            this.cmbNetworkInterface.SelectedIndexChanged += new System.EventHandler(this.cmbNetworkInterface_SelectedIndexChanged);
            // 
            // chkLargeSystem
            // 
            this.chkLargeSystem.AutoSize = true;
            this.chkLargeSystem.Checked = global::NetStreamsDebugger.Properties.Settings.Default.LargeSystemBehavior;
            this.chkLargeSystem.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::NetStreamsDebugger.Properties.Settings.Default, "LargeSystemBehavior", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkLargeSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLargeSystem.Location = new System.Drawing.Point(9, 43);
            this.chkLargeSystem.Name = "chkLargeSystem";
            this.chkLargeSystem.Size = new System.Drawing.Size(135, 17);
            this.chkLargeSystem.TabIndex = 6;
            this.chkLargeSystem.Text = "Large System Behavior";
            this.toolTip1.SetToolTip(this.chkLargeSystem, "Adjusts the data gathering approach for the tool by refreshing\r\nthe display less " +
                    "regularly. ");
            this.chkLargeSystem.UseVisualStyleBackColor = true;
            this.chkLargeSystem.CheckedChanged += new System.EventHandler(this.chkLargeSystem_CheckedChanged);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(140)))), ((int)(((byte)(183)))));
            this.pnlTop.BackgroundImage = global::NetStreamsDebugger.Properties.Resources.LiveWriterToolbarBack;
            this.pnlTop.Controls.Add(this.butMoreLess);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(260, 35);
            this.pnlTop.TabIndex = 9;
            // 
            // butMoreLess
            // 
            this.butMoreLess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.butMoreLess.BackColor = System.Drawing.Color.Transparent;
            this.butMoreLess.Cursor = System.Windows.Forms.Cursors.Default;
            this.butMoreLess.FlatAppearance.BorderSize = 0;
            this.butMoreLess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butMoreLess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butMoreLess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMoreLess.ForeColor = System.Drawing.Color.White;
            this.butMoreLess.Location = new System.Drawing.Point(-8, 0);
            this.butMoreLess.Margin = new System.Windows.Forms.Padding(0);
            this.butMoreLess.Name = "butMoreLess";
            this.butMoreLess.Size = new System.Drawing.Size(34, 34);
            this.butMoreLess.TabIndex = 9;
            this.butMoreLess.Text = ">>";
            this.toolTip1.SetToolTip(this.butMoreLess, "Hide this panel");
            this.butMoreLess.UseMnemonic = false;
            this.butMoreLess.UseVisualStyleBackColor = false;
            this.butMoreLess.Click += new System.EventHandler(this.CollapseExpandOptionsPane);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Debugging Options";
            // 
            // groupBoxLogging
            // 
            this.groupBoxLogging.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLogging.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxLogging.Controls.Add(this.chkApplyFilterToLog);
            this.groupBoxLogging.Controls.Add(this.chkLogOnlySelected);
            this.groupBoxLogging.Controls.Add(this.loggingDirLabel);
            this.groupBoxLogging.Controls.Add(this.lblWorkingDir);
            this.groupBoxLogging.Controls.Add(this.chkEnableLogging);
            this.groupBoxLogging.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLogging.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(141)))));
            this.groupBoxLogging.Location = new System.Drawing.Point(14, 318);
            this.groupBoxLogging.Name = "groupBoxLogging";
            this.groupBoxLogging.Size = new System.Drawing.Size(231, 112);
            this.groupBoxLogging.TabIndex = 8;
            this.groupBoxLogging.TabStop = false;
            this.groupBoxLogging.Text = "Logging";
            // 
            // chkApplyFilterToLog
            // 
            this.chkApplyFilterToLog.AutoSize = true;
            this.chkApplyFilterToLog.Checked = global::NetStreamsDebugger.Properties.Settings.Default.LogObeysFilterRules;
            this.chkApplyFilterToLog.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::NetStreamsDebugger.Properties.Settings.Default, "LogObeysFilterRules", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkApplyFilterToLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkApplyFilterToLog.Location = new System.Drawing.Point(9, 68);
            this.chkApplyFilterToLog.Name = "chkApplyFilterToLog";
            this.chkApplyFilterToLog.Size = new System.Drawing.Size(139, 17);
            this.chkApplyFilterToLog.TabIndex = 5;
            this.chkApplyFilterToLog.Text = "Apply Filters To Logging";
            this.toolTip1.SetToolTip(this.chkApplyFilterToLog, "Messages that are excluded by a filter are not logged to file");
            this.chkApplyFilterToLog.UseVisualStyleBackColor = true;
            // 
            // chkLogOnlySelected
            // 
            this.chkLogOnlySelected.AutoSize = true;
            this.chkLogOnlySelected.Checked = global::NetStreamsDebugger.Properties.Settings.Default.LogSelectedMessageTypesOnly;
            this.chkLogOnlySelected.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::NetStreamsDebugger.Properties.Settings.Default, "LogSelectedMessageTypesOnly", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkLogOnlySelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLogOnlySelected.Location = new System.Drawing.Point(9, 45);
            this.chkLogOnlySelected.Name = "chkLogOnlySelected";
            this.chkLogOnlySelected.Size = new System.Drawing.Size(191, 17);
            this.chkLogOnlySelected.TabIndex = 4;
            this.chkLogOnlySelected.Text = "Log Selected Message Types Only";
            this.toolTip1.SetToolTip(this.chkLogOnlySelected, "Only log to disk those message types that are checked in the data gathering secti" +
                    "on");
            this.chkLogOnlySelected.UseVisualStyleBackColor = true;
            // 
            // loggingDirLabel
            // 
            this.loggingDirLabel.AutoEllipsis = true;
            this.loggingDirLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NetStreamsDebugger.Properties.Settings.Default, "LogFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.loggingDirLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggingDirLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.loggingDirLabel.Location = new System.Drawing.Point(48, 88);
            this.loggingDirLabel.Name = "loggingDirLabel";
            this.loggingDirLabel.Size = new System.Drawing.Size(179, 13);
            this.loggingDirLabel.TabIndex = 3;
            this.loggingDirLabel.TabStop = true;
            this.loggingDirLabel.Text = global::NetStreamsDebugger.Properties.Settings.Default.LogFolder;
            this.toolTip1.SetToolTip(this.loggingDirLabel, "Click the directory name to open it in Windows explorer");
            this.loggingDirLabel.Click += new System.EventHandler(this.ExploreLoggingFolder);
            // 
            // lblWorkingDir
            // 
            this.lblWorkingDir.AutoSize = true;
            this.lblWorkingDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWorkingDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkingDir.Location = new System.Drawing.Point(6, 88);
            this.lblWorkingDir.Name = "lblWorkingDir";
            this.lblWorkingDir.Size = new System.Drawing.Size(44, 13);
            this.lblWorkingDir.TabIndex = 2;
            this.lblWorkingDir.Text = "Log To:";
            this.toolTip1.SetToolTip(this.lblWorkingDir, "Click To Change Logging Directory");
            this.lblWorkingDir.Click += new System.EventHandler(this.ClickSelectLoggingFolder);
            // 
            // chkEnableLogging
            // 
            this.chkEnableLogging.AutoSize = true;
            this.chkEnableLogging.Checked = global::NetStreamsDebugger.Properties.Settings.Default.LoggingEnabled;
            this.chkEnableLogging.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableLogging.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::NetStreamsDebugger.Properties.Settings.Default, "LoggingEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkEnableLogging.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableLogging.Location = new System.Drawing.Point(9, 21);
            this.chkEnableLogging.Name = "chkEnableLogging";
            this.chkEnableLogging.Size = new System.Drawing.Size(119, 17);
            this.chkEnableLogging.TabIndex = 0;
            this.chkEnableLogging.Text = "Enable File Logging";
            this.toolTip1.SetToolTip(this.chkEnableLogging, "Toggles logging of all messages to a file in the specified directory");
            this.chkEnableLogging.UseVisualStyleBackColor = true;
            this.chkEnableLogging.CheckedChanged += new System.EventHandler(this.EnableDisableLogging);
            // 
            // filterBindingSource
            // 
            this.filterBindingSource.DataSource = typeof(NetStreamsDebugger.Support.Filter);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Select the folder where debugging files will be saved";
            this.folderBrowserDialog.SelectedPath = "%DESKTOP%\\Lua Dev";
            // 
            // DebuggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(141)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(939, 636);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DebuggerForm";
            this.Text = "NetStreams Debugger";
            ((System.ComponentModel.ISupportInitialize)(this.allMessagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverMessagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoMessagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warningMessagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMessagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            this.splitContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabCntrl.ResumeLayout(false);
            this.tabAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.netStreamsPacketBindingSource)).EndInit();
            this.tabDriver.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.driverGrid)).EndInit();
            this.tabInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoGrid)).EndInit();
            this.tabWarning.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.warningGrid)).EndInit();
            this.tabError.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorGrid)).EndInit();
            this.tabGUI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guiGrid)).EndInit();
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBoxDisplay.ResumeLayout(false);
            this.groupBoxDisplay.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBoxLogging.ResumeLayout(false);
            this.groupBoxLogging.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butStartStop;
        private System.Windows.Forms.ComboBox cmboDevices;
        private System.Windows.Forms.BindingSource allMessagesBindingSource;
        private System.Windows.Forms.BindingSource driverMessagesBindingSource;
        private System.Windows.Forms.BindingSource infoMessagesBindingSource;
        private System.Windows.Forms.BindingSource errorMessagesBindingSource;
        private System.Windows.Forms.BindingSource warningMessagesBindingSource;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.CheckBox chkAutoScroll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TabControl tabCntrl;
        private System.Windows.Forms.TabPage tabAll;
        private System.Windows.Forms.DataGridView allGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStampHexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabDriver;
        private System.Windows.Forms.DataGridView driverGrid;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.DataGridView infoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.TabPage tabWarning;
        private System.Windows.Forms.DataGridView warningGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.TabPage tabError;
        private System.Windows.Forms.DataGridView errorGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.GroupBox groupBoxDisplay;
        private System.Windows.Forms.GroupBox groupBoxLogging;
        private System.Windows.Forms.CheckBox chkEnableLogging;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.CheckBox chkDriverMessages;
        private System.Windows.Forms.CheckBox chkLargeSystem;
        private System.Windows.Forms.CheckBox chkErrorMessages;
        private System.Windows.Forms.CheckBox chkWarningMessages;
        private System.Windows.Forms.CheckBox chkInfoMessages;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.LinkLabel loggingDirLabel;
        private System.Windows.Forms.Label lblWorkingDir;
        private System.Windows.Forms.Button butMoreLess;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lnkAbout;
        private System.Windows.Forms.CheckBox chkCaptureGUI;
        private System.Windows.Forms.TabPage tabGUI;
        private System.Windows.Forms.DataGridView guiGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Device;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReadableTimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStampHexDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReducedMessage;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.BindingSource filterBindingSource;
        private System.Windows.Forms.LinkLabel lnkIncluded;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblExcludedList;
        private System.Windows.Forms.Label lblIncludedList;
        private System.Windows.Forms.LinkLabel lnkClearFilters;
        private System.Windows.Forms.LinkLabel lnkExcluded;
        private System.Windows.Forms.ComboBox cmbNetworkInterface;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource netStreamsPacketBindingSource;
        private System.Windows.Forms.CheckBox chkLogOnlySelected;
        private System.Windows.Forms.CheckBox chkApplyFilterToLog;
    }
}

