using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using File = System.IO.File;

namespace MusicCast_Control
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.power_button = new System.Windows.Forms.Button();
            this.cypyright = new System.Windows.Forms.Label();
            this.inputChange = new System.Windows.Forms.ComboBox();
            this.info = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.Label();
            this.center_text = new System.Windows.Forms.Label();
            this.ip_address = new System.Windows.Forms.Label();
            this.mute_button = new System.Windows.Forms.Button();
            this.volumedown_button = new System.Windows.Forms.Button();
            this.volumeup_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // power_button
            // 
            this.power_button.AutoSize = true;
            this.power_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("power_button.BackgroundImage")));
            this.power_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.power_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.power_button.ForeColor = System.Drawing.Color.Fuchsia;
            this.power_button.Location = new System.Drawing.Point(250, 3);
            this.power_button.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.power_button.Name = "power_button";
            this.power_button.Size = new System.Drawing.Size(32, 24);
            this.power_button.TabIndex = 6;
            this.power_button.UseVisualStyleBackColor = true;
            this.power_button.Click += new System.EventHandler(this.power_button_Click);
            // 
            // cypyright
            // 
            this.cypyright.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cypyright.Location = new System.Drawing.Point(127, 137);
            this.cypyright.Margin = new System.Windows.Forms.Padding(0);
            this.cypyright.Name = "cypyright";
            this.cypyright.Size = new System.Drawing.Size(159, 13);
            this.cypyright.TabIndex = 7;
            this.cypyright.Text = "MusicCast Control 0.0.2";
            this.cypyright.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // inputChange
            // 
            this.inputChange.BackColor = System.Drawing.Color.Black;
            this.inputChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputChange.ForeColor = System.Drawing.Color.White;
            this.inputChange.FormattingEnabled = true;
            this.inputChange.Location = new System.Drawing.Point(76, 90);
            this.inputChange.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.inputChange.Name = "inputChange";
            this.inputChange.Size = new System.Drawing.Size(132, 23);
            this.inputChange.TabIndex = 11;
            this.inputChange.SelectedIndexChanged += new System.EventHandler(this.inputChange_SelectedIndexChanged);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info.Location = new System.Drawing.Point(-2, -1);
            this.info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.info.MinimumSize = new System.Drawing.Size(59, 0);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(111, 13);
            this.info.TabIndex = 12;
            this.info.Text = "Power: na; Input: na";
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // volume
            // 
            this.volume.AutoSize = true;
            this.volume.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.volume.Location = new System.Drawing.Point(111, 65);
            this.volume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.volume.MinimumSize = new System.Drawing.Size(62, 0);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(62, 19);
            this.volume.TabIndex = 14;
            this.volume.Text = "--.- dB";
            this.volume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // center_text
            // 
            this.center_text.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.center_text.Location = new System.Drawing.Point(42, 30);
            this.center_text.Name = "center_text";
            this.center_text.Size = new System.Drawing.Size(200, 29);
            this.center_text.TabIndex = 15;
            this.center_text.Text = "Not connected";
            this.center_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.center_text.Click += new System.EventHandler(this.center_text_Click);
            // 
            // ip_address
            // 
            this.ip_address.AutoSize = true;
            this.ip_address.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ip_address.Location = new System.Drawing.Point(-2, 139);
            this.ip_address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ip_address.Name = "ip_address";
            this.ip_address.Size = new System.Drawing.Size(40, 13);
            this.ip_address.TabIndex = 17;
            this.ip_address.Text = "0.0.0.0";
            // 
            // mute_button
            // 
            this.mute_button.AutoSize = true;
            this.mute_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mute_button.BackgroundImage")));
            this.mute_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mute_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mute_button.ForeColor = System.Drawing.Color.Red;
            this.mute_button.Location = new System.Drawing.Point(222, 5);
            this.mute_button.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.mute_button.Name = "mute_button";
            this.mute_button.Size = new System.Drawing.Size(28, 21);
            this.mute_button.TabIndex = 18;
            this.mute_button.UseVisualStyleBackColor = true;
            this.mute_button.Click += new System.EventHandler(this.mute_button_Click);
            // 
            // volumedown_button
            // 
            this.volumedown_button.AutoSize = true;
            this.volumedown_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("volumedown_button.BackgroundImage")));
            this.volumedown_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.volumedown_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.volumedown_button.ForeColor = System.Drawing.Color.Green;
            this.volumedown_button.Location = new System.Drawing.Point(76, 64);
            this.volumedown_button.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.volumedown_button.Name = "volumedown_button";
            this.volumedown_button.Size = new System.Drawing.Size(28, 21);
            this.volumedown_button.TabIndex = 19;
            this.volumedown_button.UseVisualStyleBackColor = true;
            this.volumedown_button.Click += new System.EventHandler(this.volumedown_button_Click);
            // 
            // volumeup_button
            // 
            this.volumeup_button.AutoSize = true;
            this.volumeup_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("volumeup_button.BackgroundImage")));
            this.volumeup_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.volumeup_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.volumeup_button.ForeColor = System.Drawing.Color.LawnGreen;
            this.volumeup_button.Location = new System.Drawing.Point(180, 64);
            this.volumeup_button.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.volumeup_button.Name = "volumeup_button";
            this.volumeup_button.Size = new System.Drawing.Size(28, 21);
            this.volumeup_button.TabIndex = 20;
            this.volumeup_button.UseVisualStyleBackColor = true;
            this.volumeup_button.Click += new System.EventHandler(this.volumeup_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.volumeup_button);
            this.Controls.Add(this.volumedown_button);
            this.Controls.Add(this.mute_button);
            this.Controls.Add(this.ip_address);
            this.Controls.Add(this.center_text);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.info);
            this.Controls.Add(this.inputChange);
            this.Controls.Add(this.cypyright);
            this.Controls.Add(this.power_button);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MusicCast Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private async void labels()
        {

            //
            // read the json settings file
            //
            string[] inputs = new string[50];
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
            } else
            {
                this.inputChange.Items.Add("Optical");
                mcip = "192.168.0.10";
            }
            ip_address.Text = mcip; // change ip info label


            //
            // get the amplifier status, device info and features
            //
            using var client = new HttpClient();
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

        #endregion
        private Button power_button;
        private Label info;
        private string maxVol;
        private string curVol;
        private Label cypyright;
        private string mcip;
        private ComboBox inputChange;
        private Label volume;
        private string currentInput;
        private Label center_text;
        private string input_list;
        private Label ip_address;
        private Button mute_button;
        private bool mute;
        private Button volumedown_button;
        private Button volumeup_button;
    }
}