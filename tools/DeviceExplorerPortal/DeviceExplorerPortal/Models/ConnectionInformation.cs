using System.Net.NetworkInformation;

namespace DeviceExplorerPortal.Models
{
    public class ConnectionInformation
    {
        public string ConnectionString { get; set; }

        public string ProtocolGateway { get; set; }

        public string KeyName { get; set; }

        public string KeyValue { get; set; }

        public string Target { get; set; }

        public int TtlDays { get; set; }
    }
}