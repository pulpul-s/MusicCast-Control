

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
            this.BassLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ExtreBassToggle = new System.Windows.Forms.Button();
            this.AdaptativeDRCToggle = new System.Windows.Forms.Button();
            this.EnhancerToggle = new System.Windows.Forms.Button();
            this.PureDirectToggle = new System.Windows.Forms.Button();
            this.PureDirectLabel = new System.Windows.Forms.Label();
            this.EnhancerLabel = new System.Windows.Forms.Label();
            this.AdaDRCLabal = new System.Windows.Forms.Label();
            this.ExtraBassLabal = new System.Windows.Forms.Label();
            this.SignalInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // power_button
            // 
            this.power_button.AutoSize = true;
            this.power_button.BackgroundImage = global::MusicCast_Control.Properties.Resources.power;
            this.power_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.power_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.power_button.ForeColor = System.Drawing.Color.Fuchsia;
            this.power_button.Location = new System.Drawing.Point(326, -1);
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
            this.cypyright.Location = new System.Drawing.Point(201, 389);
            this.cypyright.Margin = new System.Windows.Forms.Padding(0);
            this.cypyright.Name = "cypyright";
            this.cypyright.Size = new System.Drawing.Size(159, 13);
            this.cypyright.TabIndex = 7;
            this.cypyright.Text = "MusicCast Control 0.0.3";
            this.cypyright.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // inputChange
            // 
            this.inputChange.BackColor = System.Drawing.Color.Black;
            this.inputChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputChange.ForeColor = System.Drawing.Color.White;
            this.inputChange.FormattingEnabled = true;
            this.inputChange.Location = new System.Drawing.Point(32, 88);
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
            this.volume.Location = new System.Drawing.Point(67, 63);
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
            this.center_text.Location = new System.Drawing.Point(-2, 28);
            this.center_text.Name = "center_text";
            this.center_text.Size = new System.Drawing.Size(200, 29);
            this.center_text.TabIndex = 15;
            this.center_text.Text = "Connecting";
            this.center_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.center_text.Click += new System.EventHandler(this.center_text_Click);
            // 
            // ip_address
            // 
            this.ip_address.AutoSize = true;
            this.ip_address.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ip_address.Location = new System.Drawing.Point(5, 389);
            this.ip_address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ip_address.Name = "ip_address";
            this.ip_address.Size = new System.Drawing.Size(40, 13);
            this.ip_address.TabIndex = 17;
            this.ip_address.Text = "0.0.0.0";
            // 
            // mute_button
            // 
            this.mute_button.AutoSize = true;
            this.mute_button.BackgroundImage = global::MusicCast_Control.Properties.Resources.volmute;
            this.mute_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mute_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mute_button.ForeColor = System.Drawing.Color.Red;
            this.mute_button.Location = new System.Drawing.Point(298, 1);
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
            this.volumedown_button.BackgroundImage = global::MusicCast_Control.Properties.Resources.voldown;
            this.volumedown_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.volumedown_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.volumedown_button.ForeColor = System.Drawing.Color.Green;
            this.volumedown_button.Location = new System.Drawing.Point(32, 62);
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
            this.volumeup_button.BackgroundImage = global::MusicCast_Control.Properties.Resources.volup;
            this.volumeup_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.volumeup_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.volumeup_button.ForeColor = System.Drawing.Color.LawnGreen;
            this.volumeup_button.Location = new System.Drawing.Point(136, 62);
            this.volumeup_button.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.volumeup_button.Name = "volumeup_button";
            this.volumeup_button.Size = new System.Drawing.Size(28, 21);
            this.volumeup_button.TabIndex = 20;
            this.volumeup_button.UseVisualStyleBackColor = true;
            this.volumeup_button.Click += new System.EventHandler(this.volumeup_button_Click);
            // 
            // BassLabel
            // 
            this.BassLabel.AutoSize = true;
            this.BassLabel.Location = new System.Drawing.Point(81, 334);
            this.BassLabel.Name = "BassLabel";
            this.BassLabel.Size = new System.Drawing.Size(60, 15);
            this.BassLabel.TabIndex = 21;
            this.BassLabel.Text = "Bass Level";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackgroundImage = global::MusicCast_Control.Properties.Resources.volup;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.LawnGreen;
            this.button1.Location = new System.Drawing.Point(46, 331);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 21);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BassUp_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackgroundImage = global::MusicCast_Control.Properties.Resources.voldown;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(11, 331);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 21);
            this.button2.TabIndex = 25;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BassDown_Click);
            // 
            // ExtreBassToggle
            // 
            this.ExtreBassToggle.BackgroundImage = global::MusicCast_Control.Properties.Resources.power;
            this.ExtreBassToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExtreBassToggle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExtreBassToggle.Location = new System.Drawing.Point(11, 292);
            this.ExtreBassToggle.Name = "ExtreBassToggle";
            this.ExtreBassToggle.Size = new System.Drawing.Size(25, 25);
            this.ExtreBassToggle.TabIndex = 26;
            this.ExtreBassToggle.UseVisualStyleBackColor = true;
            this.ExtreBassToggle.Click += new System.EventHandler(this.ExtreBassToggle_Click);
            // 
            // AdaptativeDRCToggle
            // 
            this.AdaptativeDRCToggle.BackgroundImage = global::MusicCast_Control.Properties.Resources.power;
            this.AdaptativeDRCToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AdaptativeDRCToggle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdaptativeDRCToggle.Location = new System.Drawing.Point(11, 261);
            this.AdaptativeDRCToggle.Name = "AdaptativeDRCToggle";
            this.AdaptativeDRCToggle.Size = new System.Drawing.Size(25, 25);
            this.AdaptativeDRCToggle.TabIndex = 27;
            this.AdaptativeDRCToggle.UseVisualStyleBackColor = true;
            this.AdaptativeDRCToggle.Click += new System.EventHandler(this.AdaptativeDRCToggle_Click);
            // 
            // EnhancerToggle
            // 
            this.EnhancerToggle.BackgroundImage = global::MusicCast_Control.Properties.Resources.power;
            this.EnhancerToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EnhancerToggle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EnhancerToggle.Location = new System.Drawing.Point(11, 230);
            this.EnhancerToggle.Name = "EnhancerToggle";
            this.EnhancerToggle.Size = new System.Drawing.Size(25, 25);
            this.EnhancerToggle.TabIndex = 28;
            this.EnhancerToggle.UseVisualStyleBackColor = true;
            this.EnhancerToggle.Click += new System.EventHandler(this.EnhancerToggle_Click);
            // 
            // PureDirectToggle
            // 
            this.PureDirectToggle.BackgroundImage = global::MusicCast_Control.Properties.Resources.power;
            this.PureDirectToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PureDirectToggle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PureDirectToggle.Location = new System.Drawing.Point(11, 199);
            this.PureDirectToggle.Name = "PureDirectToggle";
            this.PureDirectToggle.Size = new System.Drawing.Size(25, 25);
            this.PureDirectToggle.TabIndex = 29;
            this.PureDirectToggle.UseVisualStyleBackColor = true;
            this.PureDirectToggle.Click += new System.EventHandler(this.PureDirectToggle_Click);
            // 
            // PureDirectLabel
            // 
            this.PureDirectLabel.AutoSize = true;
            this.PureDirectLabel.Location = new System.Drawing.Point(81, 204);
            this.PureDirectLabel.Name = "PureDirectLabel";
            this.PureDirectLabel.Size = new System.Drawing.Size(38, 15);
            this.PureDirectLabel.TabIndex = 30;
            this.PureDirectLabel.Text = "label1";
            // 
            // EnhancerLabel
            // 
            this.EnhancerLabel.AutoSize = true;
            this.EnhancerLabel.Location = new System.Drawing.Point(81, 235);
            this.EnhancerLabel.Name = "EnhancerLabel";
            this.EnhancerLabel.Size = new System.Drawing.Size(38, 15);
            this.EnhancerLabel.TabIndex = 31;
            this.EnhancerLabel.Text = "label2";
            // 
            // AdaDRCLabal
            // 
            this.AdaDRCLabal.AutoSize = true;
            this.AdaDRCLabal.Location = new System.Drawing.Point(80, 266);
            this.AdaDRCLabal.Name = "AdaDRCLabal";
            this.AdaDRCLabal.Size = new System.Drawing.Size(38, 15);
            this.AdaDRCLabal.TabIndex = 32;
            this.AdaDRCLabal.Text = "label3";
            // 
            // ExtraBassLabal
            // 
            this.ExtraBassLabal.AutoSize = true;
            this.ExtraBassLabal.Location = new System.Drawing.Point(80, 297);
            this.ExtraBassLabal.Name = "ExtraBassLabal";
            this.ExtraBassLabal.Size = new System.Drawing.Size(38, 15);
            this.ExtraBassLabal.TabIndex = 33;
            this.ExtraBassLabal.Text = "label4";
            // 
            // SignalInfoLabel
            // 
            this.SignalInfoLabel.Location = new System.Drawing.Point(178, 28);
            this.SignalInfoLabel.Name = "SignalInfoLabel";
            this.SignalInfoLabel.Size = new System.Drawing.Size(179, 56);
            this.SignalInfoLabel.TabIndex = 34;
            this.SignalInfoLabel.Text = "blap";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(369, 402);
            this.Controls.Add(this.SignalInfoLabel);
            this.Controls.Add(this.ExtraBassLabal);
            this.Controls.Add(this.AdaDRCLabal);
            this.Controls.Add(this.EnhancerLabel);
            this.Controls.Add(this.PureDirectLabel);
            this.Controls.Add(this.PureDirectToggle);
            this.Controls.Add(this.EnhancerToggle);
            this.Controls.Add(this.AdaptativeDRCToggle);
            this.Controls.Add(this.ExtreBassToggle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BassLabel);
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

        

        #endregion
        private Button power_button;
        private Label info;
        private string maxVol;
        private string curVol;
        private Label cypyright;
        private string mcip = "192.168.1.50";
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
        private Label BassLabel;
        private Button button1;
        private Button button2;
        private Button ExtreBassToggle;
        private Button AdaptativeDRCToggle;
        private Button EnhancerToggle;
        private Button PureDirectToggle;
        private bool PureDirect;
        private bool Enhancer;
        private bool ExtraBass;
        private bool Adaptivedrc;
        private int maxBass = 12;
        private int minBass = -12;
        private int curBass;
        private Label PureDirectLabel;
        private Label EnhancerLabel;
        private Label AdaDRCLabal;
        private Label ExtraBassLabal;
        private Label SignalInfoLabel;
    }
}