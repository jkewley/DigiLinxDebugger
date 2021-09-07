using System.Drawing;
using System.Windows.Forms;
using DigiLinXLibrary.Device.Interface;
using DigiLinXLibrary.Network.Packets;
using NetStreamsDebugger.Support.DeviceUI.Service;

namespace NetStreamsDebugger {
    public partial class DeviceDetailForm : Form {
        private readonly NetStreamsPacket thePacket;

        public DeviceDetailForm(NetStreamsPacket aPacket) {
            InitializeComponent();
            thePacket = aPacket;
            lblDeviceName.Text = aPacket.Device.DeviceName;
            if (thePacket.Device is IAudioRenderer) theLayoutPanel.Controls.Add(new AudioRenderer(aPacket.Device as IAudioRenderer));
        }

        //        protected override void OnPaintBackground(PaintEventArgs pevent) {
        //            base.OnPaintBackground(pevent); // not required
        //
        //            Image image = BackgroundImage;
        //            Bitmap bitmap = new Bitmap(image);
        //            Color color = bitmap.GetPixel(0, 0);
        //            bitmap.MakeTransparent(color);
        //            pevent.Graphics.DrawImage(bitmap, bitmap.Width, 0, bitmap.Width, bitmap.Height);
        //        }
    }
}