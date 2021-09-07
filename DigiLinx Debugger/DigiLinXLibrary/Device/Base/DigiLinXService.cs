using DigiLinXLibrary.Device.Enum;

namespace DigiLinXLibrary.Device.Base {
    /// <summary>
    /// Base class for a service that a DigiLinXDevice makes available
    /// <seealso cref="ServiceType"/>
    /// </summary>
    public class DigiLinXService {
        private bool isEnabled;
        private string theServiceName;
        private int theServiceNumber;
        public ServiceType theServiceType;

        public string ServiceName {
            get { return theServiceName; }
            set { theServiceName = value; }
        }

        public bool Enabled {
            get { return isEnabled; }
            set { isEnabled = value; }
        }

        public int ServiceNumber {
            get { return theServiceNumber; }
            set { theServiceNumber = value; }
        }
    }
}