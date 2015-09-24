namespace DeviceExplorerPortal.Models
{
    using System;
    using System.Text;
    using Microsoft.Azure.Devices;

    public class DeviceEntity
    {
        private readonly string _iotHubConnectionString;
        private readonly string _protocolGatewayHostName;

        public DeviceEntity()
        {
            _iotHubConnectionString = @"HostName=iot-device-client.df.azure-devices-int.net;SharedAccessKeyName=iothubowner;SharedAccessKey=XDjSeiBsFJNcNqjgr5yQNt/dcIxLyVASbMQVkeGLCCc=";
            _protocolGatewayHostName = string.Empty;
        }

        public DeviceEntity(string iotHubConnectionString, string protocolGatewayHostName)
        {
            _iotHubConnectionString = iotHubConnectionString;
            _protocolGatewayHostName = protocolGatewayHostName;
        }

        public string Id { get; set; }
        public string PrimaryKey { get; set; }
        public string SecondaryKey { get; set; }
        public string ConnectionState { get; set; }
        public DateTime LastActivityTime { get; set; }
        public DateTime LastConnectionStateUpdatedTime { get; set; }
        public DateTime LastStateUpdatedTime { get; set; }
        public int MessageCount { get; set; }
        public string State { get; set; }
        public string SuspensionReason { get; set; }
        public AuthenticationMechanism Authentication { get; set; }

        public string ConnectionString
        {
            get
            {
                var deviceConnectionString = new StringBuilder();

                var hostName = string.Empty;
                var tokenArray = _iotHubConnectionString.Split(';');
                foreach (var t in tokenArray)
                {
                    var keyValueArray = t.Split('=');
                    if (keyValueArray[0] == "HostName")
                    {
                        hostName = t + ';';
                        break;
                    }
                }

                if (!string.IsNullOrWhiteSpace(hostName))
                {
                    deviceConnectionString.Append(hostName);
                    deviceConnectionString.Append("CredentialScope=Device;");
                    deviceConnectionString.AppendFormat("DeviceId={0}", Id);

                    if (Authentication?.SymmetricKey != null)
                    {
                        deviceConnectionString.AppendFormat(";SharedAccessKey={0}", Authentication.SymmetricKey.PrimaryKey);
                    }

                    if (_protocolGatewayHostName.Length > 0)
                    {
                        deviceConnectionString.AppendFormat(";GatewayHostName=ssl://{0}:8883", _protocolGatewayHostName);
                    }
                }

                return deviceConnectionString.ToString();
            }
        }

        public override string ToString()
        {
            return
                $"Device ID = {Id}, " +
                $"Primary Key = {PrimaryKey}, " +
                $"Secondary Key = {SecondaryKey}, " +
                $"ConnectionString = {ConnectionString}, " +
                $"ConnState = {ConnectionState}, " +
                $"ActivityTime = {LastActivityTime}, " +
                $"LastConnState = {LastConnectionStateUpdatedTime}, " +
                $"LastStateUpdatedTime = {LastStateUpdatedTime}, " +
                $"MessageCount = {MessageCount}, " +
                $"State = {State}, " +
                $"SuspensionReason = {SuspensionReason}, " + 
                $"Authentication = {Authentication}\r\n";
        }
    }
}