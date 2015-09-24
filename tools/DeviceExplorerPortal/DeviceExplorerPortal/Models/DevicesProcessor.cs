using System.Web.UI.WebControls;

namespace DeviceExplorerPortal.Models
{
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.Azure.Devices;

    public class DevicesProcessor
    {
        private readonly List<DeviceEntity> _listOfDevices;
        private readonly RegistryManager _registryManager;
        private readonly string _iotHubConnectionString;
        private readonly int _maxCountOfDevices;
        private readonly string _protocolGatewayHostName;

        public DevicesProcessor()
        {
            _listOfDevices = new List<DeviceEntity>();
            _iotHubConnectionString = @"HostName=iot-device-client.df.azure-devices-int.net;SharedAccessKeyName=iothubowner;SharedAccessKey=XDjSeiBsFJNcNqjgr5yQNt/dcIxLyVASbMQVkeGLCCc=";
            _maxCountOfDevices = 1000;
            _protocolGatewayHostName = string.Empty;
            _registryManager = RegistryManager.CreateFromConnectionString(_iotHubConnectionString);
        }

        public DevicesProcessor(string iotHubConnenctionString, int devicesCount, string protocolGatewayName)
        {
            _listOfDevices = new List<DeviceEntity>();
            _iotHubConnectionString = iotHubConnenctionString;
            _maxCountOfDevices = devicesCount;
            _protocolGatewayHostName = protocolGatewayName;
            _registryManager = RegistryManager.CreateFromConnectionString(_iotHubConnectionString);
        }

        public async Task<List<DeviceEntity>> GetDevices()
        {
            var devices = await _registryManager.GetDevicesAsync(_maxCountOfDevices);

            if (devices != null)
            {
                foreach (var device in devices)
                {
                    var deviceEntity = new DeviceEntity(_iotHubConnectionString, _protocolGatewayHostName)
                    {
                        Id = device.Id,
                        ConnectionState = device.ConnectionState.ToString(),
                        LastActivityTime = device.LastActivityTime,
                        LastConnectionStateUpdatedTime = device.ConnectionStateUpdatedTime,
                        LastStateUpdatedTime = device.StatusUpdatedTime,
                        MessageCount = device.CloudToDeviceMessageCount,
                        State = device.Status.ToString(),
                        SuspensionReason = device.StatusReason
                    };

                    if (device.Authentication?.SymmetricKey != null)
                    {
                        deviceEntity.PrimaryKey = device.Authentication.SymmetricKey.PrimaryKey;
                        deviceEntity.SecondaryKey = device.Authentication.SymmetricKey.SecondaryKey;
                    }

                    _listOfDevices.Add(deviceEntity);
                }
            }
            return _listOfDevices;
        }
    }
}