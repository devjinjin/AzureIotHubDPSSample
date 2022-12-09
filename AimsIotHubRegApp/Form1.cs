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

            firstPrimaryKeyTextBot.Text = primaryKey;
            scopeTextBox.Text = scopeId;

            button1.Enabled = false;
            messageSendButton.Enabled = false;
            GenerateDeviceKeyButton.Enabled = false;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (IsValidInputValue())
            {
                _parameters.IdScope = scopeTextBox.Text;
                _parameters.RegistrationId = registrationIdTextBox.Text;
                _parameters.PrimaryKey = privateKeyTextBox.Text;

                try
                {
                    var result = await RunRegistrationAsync();

                    if (result.Item1)
                    {
                        MessageBox.Show(this,"등록이 완료되었습니다");
                    }
                    else {
                        MessageBox.Show(this, "등록이 실패 하였습니다");
                    }

                    if (result.Item2.Length > 0) {
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
                MessageBox.Show(this, "입력되지않는 값이 있습니다.");
            }
        }


        private bool IsValidInputValue()
        {
            if (scopeTextBox.Text == String.Empty
                || registrationIdTextBox.Text == String.Empty
                || privateKeyTextBox.Text == String.Empty)
            {
                return false;
            }
            return true;
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
                    //만약 기등록 되었다면
                    Console.WriteLine($"Registration status did not assign a hub, so exiting this sample.");
                    return (false, result.AssignedHub);
                }

                //jylee 5 디바이스 등록
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

                //메세지 전송

                Console.WriteLine("Sending a telemetry message...");

                using var message = new Microsoft.Azure.Devices.Client.Message(Encoding.UTF8.GetBytes("TestMessage"));

               

                await iotClient.SendEventAsync(message);

                await iotClient.CloseAsync();

                */
                //전송끝
                Console.WriteLine("Finished.");

                return (true, result.AssignedHub);
            }
            catch (Exception ex)
            {

                return (false, "");

            }

        }

        private void GenerateDeviceKeyButton_Click(object sender, EventArgs e)
        {
            if (firstPrimaryKeyTextBot.Text == String.Empty
            || firstRegistrationTextBox.Text == String.Empty)
            {
                MessageBox.Show(this, "입력되지않은 값이 있습니다.");
            }
            else {
                RunConvertHMACSHA256Async(firstPrimaryKeyTextBot.Text, firstRegistrationTextBox.Text);
            }

        }

        public void RunConvertHMACSHA256Async(string primaryKey, string RegId)
        {
            using (HMACSHA256 hash = new HMACSHA256()) {
                byte[] byte64 = Convert.FromBase64String(primaryKey);
                hash.Key = byte64;
                byte[] regIdByte = ASCIIEncoding.ASCII.GetBytes(RegId);
                var sig = hash.ComputeHash(regIdByte);
                var derivedkey = Convert.ToBase64String(sig);
                Console.WriteLine(derivedkey);

                if (derivedkey != null && derivedkey.Length > 0) { 
                    privateKeyTextBox.Text = derivedkey;
                    registrationIdTextBox.Text = RegId;
                    button1.Enabled = true;
                }
                MessageBox.Show(this, derivedkey);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            //데이터 전송하기
            if (registrationIdTextBox.Text != String.Empty 
                || privateKeyTextBox.Text != String.Empty
                || iotHubUrlTextBox.Text != String.Empty) {
                var deviceId = registrationIdTextBox.Text;
                var deviceKey = privateKeyTextBox.Text;
                var IotHubUri = iotHubUrlTextBox.Text;

                if (await SendMessage(deviceId, deviceKey, IotHubUri)) { 
                    MessageBox.Show(this, "메세지 전송완료");
                }
            }
        }

        private async Task<bool> SendMessage(string _deviceId, string _deviceKey, string _IotHubUri) {

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
            catch (Exception)
            {

                return false;
            }
        }

        private void iotHubUrlTextBox_TextChanged(object sender, EventArgs e)
        {
            if (iotHubUrlTextBox.Text.Length > 0)
            {
                messageSendButton.Enabled = true;
            }
            else {
                messageSendButton.Enabled = false;
            }
        }

        private void firstRegistrationTextBox_TextChanged(object sender, EventArgs e)
        {
            if (firstRegistrationTextBox.Text.Length > 0)
            {
                GenerateDeviceKeyButton.Enabled = true;
            }
            else
            {
                GenerateDeviceKeyButton.Enabled = false;
            }
        }

        private void primaryKeySaveButton_Click(object sender, EventArgs e)
        {
            if (firstPrimaryKeyTextBot.Text.Length > 0)
            {
                Properties.Settings.Default.primaryKey = firstPrimaryKeyTextBot.Text;
                Properties.Settings.Default.Save();
                
                MessageBox.Show("기본키 저장 완료");
            }

        }

        private void scopeIdButton_Click(object sender, EventArgs e)
        {
            if (scopeTextBox.Text.Length > 0) {
                Properties.Settings.Default.scopeId = scopeTextBox.Text;
                Properties.Settings.Default.Save();

                MessageBox.Show("ID 범위 저장 완료");
            }
        }
    }
}