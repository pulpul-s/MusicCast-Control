using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace MusicCast_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            read_settings();
            var ping = new Ping();
            var pingresult = ping.Send(mcip);
            if (pingresult.Status == 0)
            {
                fetch_info();
                backgroundUpdate();
            }
            else
            {
                center_text.Text = "IP unreachable";
            }
        }


        //
        // read the json settings file
        //
        string[] inputs = new string[50];
        private void read_settings()
        {

            if (File.Exists("settings.json"))
            {
                string settingsjson = File.ReadAllText("settings.json");
                var settings = JsonObject.Parse(settingsjson);

                // add inputs to combobox
                inputs = Regex.Replace(Convert.ToString(settings["inputs"]), "[ \"\n\r\\[\\]\t]", "").Split(","); // fix this at some point
                foreach (var input in inputs)
                {
                    this.inputChange.Items.Add(input);

                }
                // set the ip address
                mcip = settings["ip_address"].ToString();
            }
            else
            {
                this.inputChange.Items.Add("Optical");
                mcip = "192.168.0.10";
            }
            ip_address.Text = mcip; // change ip info label
        }

        //
        // get the amplifier status, device info and features
        //
        private async void fetch_info()
        {
            using var client = new HttpClient();

            try
            {
                var statusjson = await client.GetStringAsync("http://" + mcip + "/YamahaExtendedControl/v1/main/getStatus");
                var deviceinfojson = await client.GetStringAsync("http://" + mcip + "/YamahaExtendedControl/v1/system/getDeviceInfo");
                var featuresjson = await client.GetStringAsync("http://" + mcip + "/YamahaExtendedControl/v1/system/getFeatures");

                var status = JsonObject.Parse(statusjson);
                var deviceinfo = JsonObject.Parse(deviceinfojson);
                var features = JsonObject.Parse(featuresjson);
                input_list = Convert.ToString(features["zone"][0]["input_list"]);


                // 
                // info fields
                // 
                // power and input on start
                info.Text = "Power: " + (string)status["power"] + "; Input: " + (string)status["input"];

                // device model
                center_text.Text = (string)deviceinfo["model_name"];

                // get the maximum, current volume and startup input source
                maxVol = Convert.ToString(status["max_volume"]);
                curVol = Convert.ToString(status["volume"]);
                currentInput = Convert.ToString(status["input"]);
                mute = (bool)status["mute"];

                // volume
                if (mute)
                {
                    volume.Text = "muted";
                }
                else
                {
                    volume.Text = Convert.ToString(status["actual_volume"]["value"]) + " dB";
                }

                // Show the selected input on input list as default
                foreach (var input in inputs)
                {
                    if (currentInput == input.ToLower())
                    {
                        inputChange.Text = input;
                    }
                }

            }

            catch (Exception ex)
            {
                center_text.Text = "No MusicCast";
            } finally
            {
                fetch_info();
            }
        }

        //
        // labels, buttons etc functionality
        //
        private async void power_button_Click(object sender, EventArgs e)
        {
            // power toggle
            using var client = new HttpClient();
            var powerToggle = await client.GetStringAsync("http://" + mcip + "/YamahaExtendedControl/v1/main/setPower?power=toggle");
        }

        private async void volumedown_button_Click(object sender, EventArgs e)
        {
            // volume -
            if (Convert.ToInt32(curVol) > 0)
            {
                int setVol = Convert.ToInt32(curVol) - 1;
                using var client = new HttpClient();
                var incVol = await client.GetStringAsync("http://" + mcip + "/YamahaExtendedControl/v1/main/setVolume?volume=" + setVol);
                curVol = Convert.ToString(setVol);
                mute = false;
                updateVolume();
            }
        }

        private async void volumeup_button_Click(object sender, EventArgs e)
        {
            // volume +
            if (Convert.ToInt32(curVol) < Convert.ToInt32(maxVol))
            {
                int setVol = Convert.ToInt32(curVol) + 1;
                using var client = new HttpClient();
                var incVol = await client.GetStringAsync("http://" + mcip + "/YamahaExtendedControl/v1/main/setVolume?volume=" + setVol);
                curVol = Convert.ToString(setVol);
                mute = false;
                updateVolume();
            }
        }

        private async void mute_button_Click(object sender, EventArgs e)
        {
            using var client = new HttpClient();
            if (!mute)
            {
                var muteVol = await client.GetStringAsync("http://" + mcip + "/YamahaExtendedControl/v1/main/setMute?enable=true");
                mute = true;
                volume.Text = "muted";
            }
            else
            {
                var muteVol = await client.GetStringAsync("http://" + mcip + "/YamahaExtendedControl/v1/main/setMute?enable=false");
                updateVolume();
                mute = false;
            }

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            // volume -
            if (Convert.ToInt32(curVol) > 0)
            {
                int setVol = Convert.ToInt32(curVol) - 1;
                using var client = new HttpClient();
                var incVol = await client.GetStringAsync("http://" + mcip + "/YamahaExtendedControl/v1/main/setVolume?volume=" + setVol);
                curVol = Convert.ToString(setVol);
                updateVolume();
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // volume +
            if (Convert.ToInt32(curVol) < Convert.ToInt32(maxVol))
            {
                int setVol = Convert.ToInt32(curVol) + 1;
                using var client = new HttpClient();
                var incVol = await client.GetStringAsync("http://" + mcip + "/YamahaExtendedControl/v1/main/setVolume?volume=" + setVol);
                curVol = Convert.ToString(setVol);
                updateVolume();
            }
        }

        private async void updateVolume()
        {
            using var client = new HttpClient();
            var statusjson = await client.GetStringAsync("http://" + mcip + "/YamahaExtendedControl/v1/main/getStatus");
            var status = JsonObject.Parse(statusjson);
            volume.Text = Convert.ToString(status["actual_volume"]["value"]) + " dB";
        }

        private async void inputChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActiveControl = null; // prevent focus after selection to make it prettier
            using var client = new HttpClient();

            // check which input is selected, convert it to lowercase in case and switch to it
            var selectedInput = ((string)inputChange.SelectedItem).ToLower();
            if (currentInput != selectedInput)
            {
                await client.GetStringAsync("http://" + mcip + "/YamahaExtendedControl/v1/main/setInput?input=" + selectedInput);
                currentInput = selectedInput;
            }
        }

        private void center_text_Click(object sender, EventArgs e)
        {
            if (center_text.Text != "Not connected")
            {
                MessageBox.Show(center_text.Text + "\nList of supported inputs\n" + Regex.Replace(input_list, "[\\[\\]]", ""), "Input list");
            }
        }


        BackgroundWorker? bg;
        private void backgroundUpdate()
        {
            bg = new BackgroundWorker();
            bg.DoWork += (obj, ea) => updateFieldsLoop();
            bg.RunWorkerAsync();
        }
        private async void updateFieldsLoop()
        {
            using var client = new HttpClient();
            while (true)
            {
                var statusjson = await client.GetStringAsync("http://" + mcip + "/YamahaExtendedControl/v1/main/getStatus");
                var status = JsonObject.Parse(statusjson);
                info.Text = "Power: " + (string)status["power"] + "; Input: " + (string)status["input"];
                if (mute)
                {
                    volume.Text = "muted";
                }
                else
                {
                    volume.Text = Convert.ToString(status["actual_volume"]["value"]) + " dB";
                }
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}