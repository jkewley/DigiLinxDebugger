using System.Windows.Forms;
using DigiLinXLibrary.Device.Interface;

namespace NetStreamsDebugger.Support.DeviceUI.Service {
    public partial class AudioRenderer : UserControl {
        public AudioRenderer(IAudioRenderer theAudioRenderer) {
            InitializeComponent();
            lblBalanceValue.Text = theAudioRenderer.DefaultBalance.ToString();
            lblBassValue.Text = theAudioRenderer.DefaultBassLevel.ToString();
            lblEnabledValue.Text = theAudioRenderer.Enabled.ToString();
            lblImpedanceValue.Text = theAudioRenderer.Impedence.ToString();
            lblLineOutValue.Text = theAudioRenderer.LineOut.ToString();
            lblPassThruValue.Text = theAudioRenderer.PassThruEnabled.ToString();
            lblServiceName.Text = theAudioRenderer.ServiceName;
            lblStereoModeValue.Text = theAudioRenderer.StereoMode.ToString();
            lblTrebleValue.Text = theAudioRenderer.DefaultTrebleLevel.ToString();
            lblVolumeLimitValue.Text = theAudioRenderer.VolumeLimit.ToString();
            lblVolumeValue.Text = theAudioRenderer.DefaultVolume.ToString();
        }
    }
}