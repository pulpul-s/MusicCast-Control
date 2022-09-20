using System.ComponentModel;
using System.Text.Json.Nodes;

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

        private async void button3_Click(object sender, EventArgs e)
        {
            using var client = new HttpClient();
            var powerToggle = await client.GetStringAsync("http://" + mcip + "/YamahaExtendedControl/v1/main/setPower?power=toggle");
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
            string input = (string)inputChange.SelectedItem;
            switch (input)
            {
                case "AUX":
                    if (currentInput != "aux")
                    {
                        var inputchange = await client.GetStringAsync("http://" + mcip + "/YamahaExtendedControl/v1/main/setInput?input=aux");
                        currentInput = "aux";
                    }
                    break;

                case "Bluetooth":
                    if (currentInput != "bluetooth")
                    {
                        var inputchange = await client.GetStringAsync("http://" + mcip + "/YamahaExtendedControl/v1/main/setInput?input=bluetooth");
                        currentInput = "bluetooth";
                    }
                    break;

                case "Optical":
                    if (currentInput != "optical")
                    {
                        var inputchange = await client.GetStringAsync("http://" + mcip + "/YamahaExtendedControl/v1/main/setInput?input=optical");
                        currentInput = "optical";
                    }
                    break;

                case "USB":
                    if (currentInput != "usb")
                    {
                        var inputchange = await client.GetStringAsync("http://" + mcip + "/YamahaExtendedControl/v1/main/setInput?input=usb");
                        currentInput = "usb";
                    }
                    break;

                case "Spotify":
                    if (currentInput != "spotify")
                    {
                        var inputchange = await client.GetStringAsync("http://" + mcip + "/YamahaExtendedControl/v1/main/setInput?input=spotify");
                        currentInput = "spotify";
                    }
                    break;

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
                volume.Text = Convert.ToString(status["actual_volume"]["value"]) + " dB";
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}