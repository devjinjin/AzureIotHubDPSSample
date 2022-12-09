using Microsoft.Azure.Devices.Client;

namespace AimsIotHubRegApp.Data
{
    internal class Parameters
    {
        public string IdScope { get; set; }

        public string RegistrationId { get; set; }

        public string PrimaryKey { get; set; }

        public string GlobalDeviceEndpoint { get; set; } = "global.azure-devices-provisioning.net";

        public TransportType TransportType { get; set; } = Microsoft.Azure.Devices.Client.TransportType.Mqtt;
    }
}
