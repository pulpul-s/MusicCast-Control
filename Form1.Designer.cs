using System.Text.Json.Nodes;
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
            this.volup_btn = new System.Windows.Forms.Button();
            this.voldwn_btn = new System.Windows.Forms.Button();
            this.powerButton = new System.Windows.Forms.Button();
            this.cypyright = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ip_address = new System.Windows.Forms.TextBox();
            this.model_name = new System.Windows.Forms.TextBox();
            this.inputChange = new System.Windows.Forms.ComboBox();
            this.info = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // volup_btn
            // 
            this.volup_btn.AutoSize = true;
            this.volup_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volup_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.volup_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.volup_btn.Location = new System.Drawing.Point(176, 66);
            this.volup_btn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.volup_btn.Name = "volup_btn";
            this.volup_btn.Size = new System.Drawing.Size(44, 25);
            this.volup_btn.TabIndex = 0;
            this.volup_btn.Text = "+ Vol";
            this.volup_btn.UseVisualStyleBackColor = true;
            this.volup_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // voldwn_btn
            // 
            this.voldwn_btn.AutoSize = true;
            this.voldwn_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voldwn_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.voldwn_btn.ForeColor = System.Drawing.Color.Black;
            this.voldwn_btn.Location = new System.Drawing.Point(64, 66);
            this.voldwn_btn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.voldwn_btn.Name = "voldwn_btn";
            this.voldwn_btn.Size = new System.Drawing.Size(41, 25);
            this.voldwn_btn.TabIndex = 3;
            this.voldwn_btn.Text = "- Vol";
            this.voldwn_btn.UseVisualStyleBackColor = true;
            this.voldwn_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // powerButton
            // 
            this.powerButton.AutoSize = true;
            this.powerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.powerButton.ForeColor = System.Drawing.Color.Black;
            this.powerButton.Location = new System.Drawing.Point(232, 2);
            this.powerButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(50, 25);
            this.powerButton.TabIndex = 6;
            this.powerButton.Text = "Power";
            this.powerButton.UseVisualStyleBackColor = true;
            this.powerButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // cypyright
            // 
            this.cypyright.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cypyright.Location = new System.Drawing.Point(127, 137);
            this.cypyright.Margin = new System.Windows.Forms.Padding(0);
            this.cypyright.Name = "cypyright";
            this.cypyright.Size = new System.Drawing.Size(159, 13);
            this.cypyright.TabIndex = 7;
            this.cypyright.Text = "kyllisofta kopyraitti (SEE) 2022";
            this.cypyright.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ip_address
            // 
            this.ip_address.BackColor = System.Drawing.Color.Black;
            this.ip_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ip_address.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ip_address.ForeColor = System.Drawing.Color.White;
            this.ip_address.Location = new System.Drawing.Point(1, 139);
            this.ip_address.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ip_address.MaxLength = 15;
            this.ip_address.Name = "ip_address";
            this.ip_address.Size = new System.Drawing.Size(84, 14);
            this.ip_address.TabIndex = 9;
            this.ip_address.Text = "0.0.0.0";
            // 
            // model_name
            // 
            this.model_name.BackColor = System.Drawing.Color.Black;
            this.model_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.model_name.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.model_name.ForeColor = System.Drawing.Color.White;
            this.model_name.Location = new System.Drawing.Point(1, 128);
            this.model_name.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.model_name.MaxLength = 155;
            this.model_name.Name = "model_name";
            this.model_name.Size = new System.Drawing.Size(84, 14);
            this.model_name.TabIndex = 10;
            this.model_name.Text = "Model";
            // 
            // inputChange
            // 
            this.inputChange.BackColor = System.Drawing.Color.Black;
            this.inputChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputChange.ForeColor = System.Drawing.Color.White;
            this.inputChange.FormattingEnabled = true;
            this.inputChange.Items.AddRange(new object[] {
            "AUX",
            "Bluetooth",
            "Optical",
            "Spotify",
            "USB"});
            this.inputChange.Location = new System.Drawing.Point(64, 93);
            this.inputChange.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.inputChange.Name = "inputChange";
            this.inputChange.Size = new System.Drawing.Size(156, 23);
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
            this.volume.Location = new System.Drawing.Point(109, 69);
            this.volume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.volume.MinimumSize = new System.Drawing.Size(62, 0);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(62, 19);
            this.volume.TabIndex = 14;
            this.volume.Text = "--.- dB";
            this.volume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.info);
            this.Controls.Add(this.inputChange);
            this.Controls.Add(this.model_name);
            this.Controls.Add(this.ip_address);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cypyright);
            this.Controls.Add(this.powerButton);
            this.Controls.Add(this.voldwn_btn);
            this.Controls.Add(this.volup_btn);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MusicCast Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private async void labels()
        {
            //
            // read the musiccast ip address from settings.ini
            //
            if (File.Exists("settings.ini"))
            {
                mcip = File.ReadLines("settings.ini").Skip(1).Take(1).First();
            } else
            { // fall back to a generic local network ip
                mcip = "192.168.0.10";
            }
            ip_address.Text = mcip;

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



            // 
            // info fields
            // 
            // power and input on start
            info.Text = "Power: " + (string)status["power"] + "; Input: " + (string)status["input"];
            
            // device model
            model_name.Text = (string)deviceinfo["model_name"];

            // volume
            volume.Text = Convert.ToString(status["actual_volume"]["value"]) + " dB";

            // get the maximum, current volume and startup input source
            maxVol = Convert.ToString(status["max_volume"]);
            curVol = Convert.ToString(status["volume"]);
            currentInput = Convert.ToString(status["input"]);

            // select the appropriate input device
            switch ((string)status["input"])
            {
                case "AUX":
                    inputChange.Text = "AUX";
                    break;
                case "Bluetooth":
                    inputChange.Text = "Bluetooth";
                    break;
                case "optical":
                    inputChange.Text = "Optical";
                    break;
                case "Spotify":
                    inputChange.Text = "Spotify";
                    break;
                case "USB":
                    inputChange.Text = "USB";
                    break;
            }
                
        }

        #endregion

        private Button volup_btn;
        private Button voldwn_btn;
        private Button powerButton;
        private Label info;
        private string maxVol;
        private string curVol;
        private Label cypyright;
        private PictureBox pictureBox1;
        private TextBox ip_address;
        private string mcip;
        private TextBox model_name;
        private ComboBox inputChange;
        private Label volume;
        private string currentInput;
    }
}