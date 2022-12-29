using AimsIotHubRegApp.Data;
using Microsoft.Azure.Devices.Client;
using Microsoft.Azure.Devices.Provisioning.Client;
using Microsoft.Azure.Devices.Provisioning.Client.Transport;
using Microsoft.Azure.Devices.Shared;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text;

namespace AimsIotHubRegApp
{
    public partial class Form1 : Form
    {
        private Parameters _parameters = new Parameters();

        public Form1()
        {
            InitializeComponent();

            var primaryKey = Properties.Settings.Default.primaryKey;
            var scopeId = Properties.Settings.Default.scopeId;

            scopeTextBox.Text = scopeId;
            messageSendButton.Enabled = false;
            DeviceRegistRequestButton.Enabled = false;
            messageSendButton.Enabled = false;
        }


        private ProvisioningTransportHandler GetTransportHandler()
        {
            return _parameters.TransportType switch
            {
                TransportType.Mqtt => new ProvisioningTransportHandlerMqtt(),
                TransportType.Mqtt_Tcp_Only => new ProvisioningTransportHandlerMqtt(TransportFallbackType.TcpOnly),
                TransportType.Mqtt_WebSocket_Only => new ProvisioningTransportHandlerMqtt(TransportFallbackType.WebSocketOnly),
                TransportType.Amqp => new ProvisioningTransportHandlerAmqp(),
                TransportType.Amqp_Tcp_Only => new ProvisioningTransportHandlerAmqp(TransportFallbackType.TcpOnly),
                TransportType.Amqp_WebSocket_Only => new ProvisioningTransportHandlerAmqp(TransportFallbackType.WebSocketOnly),
                TransportType.Http1 => new ProvisioningTransportHandlerHttp(),
                _ => throw new NotSupportedException($"Unsupported transport type {_parameters.TransportType}"),
            };
        }


        //********************************[ start VCU ���̵� ��ȯ  ]******************************************
        /// <summary>
        /// VCU ���̵� ���� ��ĪŰ ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SymmetricKeyGeneratedButton_Click(object sender, EventArgs e)
        {
            if (VcuIdTextBox.Text == String.Empty)
            {
                MessageBox.Show(this, "VCU ���̵� ���� �Է����ּ���.");
            }
            else
            {
                RunConvertHMACSHA256ForVCUIDAsync(VcuIdTextBox.Text);
            }
        }

        /// <summary>
        /// VCU ���̵� sha256 ��ȯ
        /// </summary>
        /// <param name="vcuIdText"></param>
        public void RunConvertHMACSHA256ForVCUIDAsync(string vcuIdText)
        {
            using SHA256 sha = new SHA256Managed();
            byte[] hash = sha.ComputeHash(Encoding.ASCII.GetBytes(vcuIdText));
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte b in hash)
            {
                stringBuilder.AppendFormat("{0:x2}", b);
            }
            var encryptString = stringBuilder.ToString();

            if (encryptString != null && encryptString.Length > 0)
            {
                SymmetricKeyResultTextBox.Text = encryptString.ToUpper();
                SymmetricKeyTextBox.Text = encryptString.ToUpper();
                MessageBox.Show(this, encryptString.ToUpper());
            }
       
        }
        //********************************[ End VCU ���̵� ��ȯ  ]******************************************

        //********************************[ start ����̽� ���� ]******************************************
        private void scopeIdButton_Click(object sender, EventArgs e)
        {
            if (scopeTextBox.Text.Length > 0)
            {
                Properties.Settings.Default.scopeId = scopeTextBox.Text;
                Properties.Settings.Default.Save();

                MessageBox.Show("ID ���� ���� �Ϸ�");
            }
        }

        private void RegistrationIdTextBox_TextChanged(object sender, EventArgs e)
        {
            DeviceRegistRequestButton.Enabled = IsValidInputDeviceRegistrationValue();
            messageSendButton.Enabled = IsValidInputMessageValue();
        }

        private void scopeTextBox_TextChanged(object sender, EventArgs e)
        {
            DeviceRegistRequestButton.Enabled = IsValidInputDeviceRegistrationValue();
            messageSendButton.Enabled = IsValidInputMessageValue();
        }
        private void SymmetricKeyTextBox_TextChanged(object sender, EventArgs e)
        {
            DeviceRegistRequestButton.Enabled = IsValidInputDeviceRegistrationValue();
            messageSendButton.Enabled = IsValidInputMessageValue();
        }


        private async void DeviceRegistRequestButton_Click(object sender, EventArgs e)
        {
            await DeviceRegistrationAsync();
        }

        private async Task DeviceRegistrationAsync() {
            if (IsValidInputDeviceRegistrationValue())
            {
                _parameters.IdScope = scopeTextBox.Text;
                _parameters.RegistrationId = RegistrationIdTextBox.Text;
                _parameters.PrimaryKey = SymmetricKeyResultTextBox.Text;

                try
                {
                    var result = await RunRegistrationAsync();

                    if (result.Item1)
                    {
                        MessageBox.Show(this, "����� �Ϸ�Ǿ����ϴ�");
                    }
                    else
                    {
                        MessageBox.Show(this, "����� ���� �Ͽ����ϴ�");
                    }

                    if (result.Item2.Length > 0)
                    {
                        iotHubUrlTextBox.Text = result.Item2;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }

            }
            else
            {
                MessageBox.Show(this, "�Էµ����ʴ� ���� �ֽ��ϴ�.");
            }
        }
        private bool IsValidInputDeviceRegistrationValue()
        {
            if (scopeTextBox.Text == String.Empty
                || RegistrationIdTextBox.Text == String.Empty
                || SymmetricKeyTextBox.Text == String.Empty)
            {
                return false;
            }
            return true;
        }

        public async Task<(bool, string)> RunRegistrationAsync()
        {
            try
            {
                //jylee 1
                Console.WriteLine($"Initializing the device provisioning client...");

                // For group enrollments, the second parameter must be the derived device key.
                // See the ComputeDerivedSymmetricKeySample for how to generate the derived key.
                // The secondary key could be included, but was left out for the simplicity of this sample.
                using var security = new SecurityProviderSymmetricKey(
                    _parameters.RegistrationId,
                    _parameters.PrimaryKey,
                    null);

                using ProvisioningTransportHandler transportHandler = GetTransportHandler();

                var provClient = ProvisioningDeviceClient.Create(
                    _parameters.GlobalDeviceEndpoint,
                    _parameters.IdScope,
                    security,
                    transportHandler);

                //jylee 2
                Console.WriteLine($"Initialized for registration Id {security.GetRegistrationID()}.");

                //jylee 3
                Console.WriteLine("Registering with the device provisioning service...");
                DeviceRegistrationResult result = await provClient.RegisterAsync();

                //jylee 4
                Console.WriteLine($"Registration status: {result.Status}.");


                if (result.Status != ProvisioningRegistrationStatusType.Assigned)
                {
                    //���� ���� �Ǿ��ٸ�
                    Console.WriteLine($"Registration status did not assign a hub, so exiting this sample.");
                    return (false, result.AssignedHub);
                }

                //jylee 5 ����̽� ���
                //Device device001 registered to aims-motors-iot-hub.azure-devices.net
                Console.WriteLine($"Device {result.DeviceId} registered to {result.AssignedHub}.");

                //jylee 6
                Console.WriteLine("Creating symmetric key authentication for IoT Hub...");
                IAuthenticationMethod auth = new DeviceAuthenticationWithRegistrySymmetricKey(
                    result.DeviceId,
                    security.GetPrimaryKey());
                Console.WriteLine("Sending a telemetry message...");

                //jylee 7
                /*
                Console.WriteLine($"Testing the provisioned device with IoT Hub...");
                using var iotClient = DeviceClient.Create(result.AssignedHub, auth, _parameters.TransportType);

                //�޼��� ����

                Console.WriteLine("Sending a telemetry message...");

                using var message = new Microsoft.Azure.Devices.Client.Message(Encoding.UTF8.GetBytes("TestMessage"));

               

                await iotClient.SendEventAsync(message);

                await iotClient.CloseAsync();

                */
                //���۳�
                Console.WriteLine("Finished.");

                return (true, result.AssignedHub);
            }
            catch (Exception ex)
            {

                return (false, "");

            }

        }

        //********************************[ End ����̽� ���� ]******************************************

        //********************************[ start �޼��� ���ۺ�  ]******************************************


        private async Task<bool> SendMessage(string _deviceId, string _deviceKey, string _IotHubUri)
        {

            var random = new Random();
            var _temperature = (float)(30.0 + random.NextDouble() * 5.0);
            var _humidity = (float)(20.0 + random.NextDouble() * 10.0);
            var _pressure = (float)(1005.0 + random.NextDouble() * 2.5);

            var telemetryDataPoint = new
            {
                deviceId = _deviceId,
                temperature = _temperature,
                humidity = _humidity,
                pressure = _pressure,
            };

            var messageString = JsonConvert.SerializeObject(telemetryDataPoint);
            var message = new Microsoft.Azure.Devices.Client.Message(Encoding.ASCII.GetBytes(messageString))
            {
                ContentType = "application/json",
                ContentEncoding = "utf-8",
            };
            message.Properties.Add("DeviceId", _deviceId);
            message.Properties.Add("Topic", "WaterUsage");
            message.ContentEncoding = "utf-8";
            message.ContentType = "application/json";
            //message.Properties.Add("temperatureAlert", (currentTemperature > 30) ? "true" : "false");


            try
            {

                var _deviceClient = DeviceClient.Create(_IotHubUri, new DeviceAuthenticationWithRegistrySymmetricKey(_deviceId, _deviceKey), TransportType.Mqtt);

                await _deviceClient.SendEventAsync(message);

                await _deviceClient.CloseAsync();

                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
        }

        private bool IsValidInputMessageValue()
        {
            if (RegistrationIdTextBox.Text.Length > 0
                 && SymmetricKeyTextBox.Text.Length > 0
                 && iotHubUrlTextBox.Text.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        private void iotHubUrlTextBox_TextChanged(object sender, EventArgs e)
        {
            messageSendButton.Enabled = IsValidInputMessageValue();
        }

        private async void messageSendButton_ClickAsync(object sender, EventArgs e)
        {

            if (RegistrationIdTextBox.Text != String.Empty
                || SymmetricKeyTextBox.Text != String.Empty
                || iotHubUrlTextBox.Text != String.Empty)
            {
                var deviceId = RegistrationIdTextBox.Text;
                var deviceKey = SymmetricKeyTextBox.Text;
                var IotHubUri = iotHubUrlTextBox.Text;

                if (await SendMessage(deviceId, deviceKey, IotHubUri))
                {
                    MessageBox.Show(this, "�޼��� ���ۿϷ�");
                }
                else
                {
                    MessageBox.Show(this, "�޼��� ���۽���");
                }
            }
        }
    }
}