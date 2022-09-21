using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace MusicCast_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labels();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundUpdate();
        }

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


        BackgroundWorker bg;
        private async void backgroundUpdate()
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

 

        private void center_text_Click(object sender, EventArgs e)
        {
            if (center_text.Text != "Not connected")
            {
                MessageBox.Show(center_text.Text + "\nList of supported inputs\n" + Regex.Replace(input_list, "[\\[\\]]", ""), "Input list");
            }
        }
    }
}