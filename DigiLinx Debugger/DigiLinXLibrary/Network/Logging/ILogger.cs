namespace DigiLinXLibrary.Network.Logging {
    /// <summary>
    /// An ILogger is responsible for logging the various packet types that arrive on the wire.
    /// The interface requires that a unique method be called for each type.
    /// </summary>
    public interface ILogger {
        void Driver(string aMessage);
        void Info(string aMessage);
        void Warn(string aMessage);
        void Error(string aMessage);
        void Fatal(string aMessage);
        void GUI(string aMessage);
    }
}