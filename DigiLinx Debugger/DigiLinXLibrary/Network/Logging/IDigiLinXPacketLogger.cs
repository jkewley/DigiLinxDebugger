using DigiLinXLibrary.Network.Packets;

namespace DigiLinXLibrary.Network.Logging {
    /// <summary>
    /// Interface of an object that is designed to log NetStreams packets.
    /// The class that implements this interface is also responsible for imlpementing an ILogger
    /// which it will pass into the NetStreamsPacket that it is handed. 
    /// The ILogger does the actual logging, the IDigiLinXPacketLogger just hands the ILogger to the packet.
    /// </summary>
    public interface IDigiLinXPacketLogger {
        void LogPacket(NetStreamsPacket thePacket);
    }
}