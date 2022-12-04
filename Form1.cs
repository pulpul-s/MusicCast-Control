#region

using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using MusicCast_Control.Config;
using YamahaReceiverLib;
using YamahaReceiverLib.System;
using YamahaReceiverLib.Zone;

#endregion

namespace MusicCast_Control;

public partial class Form1 : Form
{
    private BackgroundWorker? bg;

    private HttpClient client = new();

    private readonly ConfigBuild config = new();


    //
    // read the json settings file
    //
    private readonly string[] inputs = new string[50];

    private readonly SystemConfig systemconfig = new();
    private YamahaAV yamahaAV = new();

    private readonly ZoneConfig zoneconfig = new();

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        config.InitializeAsync();
        YamahaAV.ip = config.Config.IP;
        mcip = config.Config.IP;
        fetch_info();
        backgroundUpdate();
    }
    /*

    private void read_settings()
    {
        if (File.Exists("settings.json"))
        {
            string settingsjson = File.ReadAllText("settings.json");
            var settings = JsonNode.Parse(settingsjson);

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
            mcip = "192.168.1.50";
        }
        ip_address.Text = mcip; // change ip info label
    }

    */

    //
    // get the amplifier status, device info and features
    //
    private async void fetch_info()
    {
        try
        {
            ip_address.Text = mcip;
            var statusjson = await zoneconfig.getStatus(ZoneConfig.zone.main);
            var deviceinfojson = await systemconfig.getDeviceInfo();
            var featuresjson = await systemconfig.getFeatures();
            var signalinfojson = await zoneconfig.getSignalInfo(ZoneConfig.zone.main);

            var status = JsonNode.Parse(statusjson);
            var deviceinfo = JsonNode.Parse(deviceinfojson);
            var features = JsonNode.Parse(featuresjson);
            var signalinfo = JsonNode.Parse(signalinfojson);
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
            BassLabel.Text = $"Bass Lvl :{Convert.ToString(status["subwoofer_volume"])}";
            curBass = int.Parse(Convert.ToString(status["subwoofer_volume"]));

            PureDirect = (bool)status["pure_direct"];
            Enhancer = (bool)status["enhancer"];
            ExtraBass = (bool)status["extra_bass"];
            Adaptivedrc = (bool)status["adaptive_drc"];

            PureDirectLabel.Text = $"Pure Direct: {PureDirect}";
            EnhancerLabel.Text = $"Enhancer: {Enhancer}";
            AdaDRCLabal.Text = $"Adaptive drc: {ExtraBass}";
            ExtraBassLabal.Text = $"Extra Bass: {Adaptivedrc}";

            SignalInfoLabel.Text = $"format: {signalinfo["audio"]["format"]}\nfs: {signalinfo["audio"]["fs"]}";


            // volume
            if (mute)
                volume.Text = "muted";
            else
                volume.Text = Convert.ToString(status["actual_volume"]["value"]) + " dB";

            // Show the selected input on input list as default
            foreach (var input in inputs)
                if (currentInput == input.ToLower())
                    inputChange.Text = input;
        }

        catch (Exception ex)
        {
            center_text.Text = "No MusicCast";
        }
        finally
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

        var powerToggle = await zoneconfig.setPower(ZoneConfig.zone.main);
    }

    private async void volumedown_button_Click(object sender, EventArgs e)
    {
        // volume -
        if (Convert.ToInt32(curVol) > 0)
        {
            var setVol = Convert.ToInt32(curVol) - 1;

            var incVol = await zoneconfig.setVolume(ZoneConfig.zone.main, setVol);
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
            var setVol = Convert.ToInt32(curVol) + 1;

            var incVol = await zoneconfig.setVolume(ZoneConfig.zone.main, setVol);
            curVol = Convert.ToString(setVol);
            mute = false;
            updateVolume();
        }
    }

    private async void mute_button_Click(object sender, EventArgs e)
    {
        if (!mute)
        {
            var muteVol = await zoneconfig.setMute(ZoneConfig.zone.main, "true");
            mute = true;
            volume.Text = "muted";
        }
        else
        {
            var muteVol = await zoneconfig.setMute(ZoneConfig.zone.main, "false");
            updateVolume();
            mute = false;
        }
    }

    private async void button2_Click(object sender, EventArgs e)
    {
        // volume -
        if (Convert.ToInt32(curVol) > 0)
        {
            var setVol = Convert.ToInt32(curVol) - 1;

            var incVol = await zoneconfig.setVolume(ZoneConfig.zone.main, setVol);
            curVol = Convert.ToString(setVol);
            updateVolume();
        }
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        // volume +
        if (Convert.ToInt32(curVol) < Convert.ToInt32(maxVol))
        {
            var setVol = Convert.ToInt32(curVol) + 1;

            var incVol = await zoneconfig.setVolume(ZoneConfig.zone.main, setVol);
            curVol = Convert.ToString(setVol);
            updateVolume();
        }
    }

    private async void updateVolume()
    {
        var statusjson = await zoneconfig.getStatus(ZoneConfig.zone.main);
        var status = JsonNode.Parse(statusjson);
        volume.Text = Convert.ToString(status["actual_volume"]["value"]) + " dB";
    }

    private async void inputChange_SelectedIndexChanged(object sender, EventArgs e)
    {
        ActiveControl = null; // prevent focus after selection to make it prettier


        // check which input is selected, convert it to lowercase in case and switch to it
        var selectedInput = ((string)inputChange.SelectedItem).ToLower();
        if (currentInput != selectedInput)
        {
            await zoneconfig.setInput(ZoneConfig.zone.main, "true", selectedInput);
            currentInput = selectedInput;
        }
    }

    private void center_text_Click(object sender, EventArgs e)
    {
        if (center_text.Text != "Not connected")
            MessageBox.Show(
                center_text.Text + "\nList of supported inputs\n" + Regex.Replace(input_list, "[\\[\\]]", ""),
                "Input list");
    }

    private void backgroundUpdate()
    {
        bg = new BackgroundWorker();
        bg.DoWork += (obj, ea) => updateFieldsLoop();
        bg.RunWorkerAsync();
    }

    private async void updateFieldsLoop()
    {
        while (true)
        {
            var statusjson = await zoneconfig.getStatus(ZoneConfig.zone.main);
            var status = JsonNode.Parse(statusjson);
            info.Text = "Power: " + (string)status["power"] + "; Input: " + (string)status["input"];
            if (mute)
                volume.Text = "muted";
            else
                volume.Text = Convert.ToString(status["actual_volume"]["value"]) + " dB";
            Thread.Sleep(1000);
        }
    }

    private void BassUp_Click(object sender, EventArgs e)
    {
        if (curBass >= minBass || curBass <= maxBass)
        {
            curBass = curBass + 1;
            zoneconfig.setSubwooferVolume(ZoneConfig.zone.main, curBass);
        }
    }

    private void BassDown_Click(object sender, EventArgs e)
    {
        if (curBass >= minBass || curBass <= maxBass)
        {
            curBass = curBass - 1;
            zoneconfig.setSubwooferVolume(ZoneConfig.zone.main, curBass);
        }
    }

    private void PureDirectToggle_Click(object sender, EventArgs e)
    {
        if (!PureDirect)
            zoneconfig.setPureDirect(ZoneConfig.zone.main, "true");
        else
            zoneconfig.setPureDirect(ZoneConfig.zone.main, "false");
        PureDirectLabel.Text = $"Pure Direct: {PureDirect}";
    }

    private void EnhancerToggle_Click(object sender, EventArgs e)
    {
        if (!Enhancer)
            zoneconfig.setEnhancer(ZoneConfig.zone.main, "true");
        else
            zoneconfig.setEnhancer(ZoneConfig.zone.main, "false");
        EnhancerLabel.Text = $"Enhancer: {Enhancer}";
    }

    private void AdaptativeDRCToggle_Click(object sender, EventArgs e)
    {
        AdaDRCLabal.Text = $"Adaptive drc: {Adaptivedrc}";
    }

    private void ExtreBassToggle_Click(object sender, EventArgs e)
    {
        if (!ExtraBass)
            zoneconfig.setBassExtension(ZoneConfig.zone.main, "true");
        else
            zoneconfig.setBassExtension(ZoneConfig.zone.main, "false");
        ExtraBassLabal.Text = $"Extra Bass: {ExtraBass}";
    }
}