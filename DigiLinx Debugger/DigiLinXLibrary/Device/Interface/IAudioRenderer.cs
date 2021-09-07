using DigiLinXLibrary.Device.Enum;
namespace DigiLinXLibrary.Device.Interface {
    public interface IAudioRenderer {
        string ServiceName { get; set; }
        bool Enabled { get; set; }
        bool DefaultEnabled { get; set; }
        int DefaultVolume { get; set; }
        int DefaultBassLevel { get; set; }
        int DefaultTrebleLevel { get; set; }
        int DefaultBalance { get; set; }
        int DefaultBand1 { get; set; }
        int DefaultBand2 { get; set; }
        int DefaultBand3 { get; set; }
        int DefaultBand4 { get; set; }
        int DefaultBand5 { get; set; }
        bool PassThruEnabled { get; set; }
        int Impedence { get; set; }
        int VolumeLimit { get; set; }
        StereoMode StereoMode { get; set; }
        LineOutMode LineOut { get; set; }
        BridgedMode BridgedMode { get; set; }
        bool AmpDisabled { get; set; }
        RoomMateMode RoomMate { get; set; }
    }
}