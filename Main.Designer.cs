namespace MCRC
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.chk_Password_Show = new System.Windows.Forms.CheckBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_connect_console = new System.Windows.Forms.Button();
            this.btn_connect_test = new System.Windows.Forms.Button();
            this.btn_port_default = new System.Windows.Forms.Button();
            this.lbl_port = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.btn_host_this = new System.Windows.Forms.Button();
            this.lbl_host = new System.Windows.Forms.Label();
            this.txt_host = new System.Windows.Forms.TextBox();
            this.lbl_appVersion = new System.Windows.Forms.Label();
            this.lbl_rconVersion = new System.Windows.Forms.Label();
            this.txt_consoleOutput = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.txt_consoleInput = new System.Windows.Forms.TextBox();
            this.lbl_consoleInput = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_Password_Show
            // 
            this.chk_Password_Show.AutoSize = true;
            this.chk_Password_Show.Location = new System.Drawing.Point(492, 232);
            this.chk_Password_Show.Name = "chk_Password_Show";
            this.chk_Password_Show.Size = new System.Drawing.Size(255, 36);
            this.chk_Password_Show.TabIndex = 21;
            this.chk_Password_Show.Text = "Show Password";
            this.chk_Password_Show.UseVisualStyleBackColor = true;
            this.chk_Password_Show.Click += new System.EventHandler(this.ShowPassword);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(40, 232);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(147, 32);
            this.lbl_password.TabIndex = 20;
            this.lbl_password.Text = "Password:";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(212, 229);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(258, 38);
            this.txt_password.TabIndex = 19;
            // 
            // btn_connect_console
            // 
            this.btn_connect_console.Location = new System.Drawing.Point(426, 314);
            this.btn_connect_console.Name = "btn_connect_console";
            this.btn_connect_console.Size = new System.Drawing.Size(238, 56);
            this.btn_connect_console.TabIndex = 18;
            this.btn_connect_console.Text = "Connect";
            this.btn_connect_console.UseVisualStyleBackColor = true;
            this.btn_connect_console.Click += new System.EventHandler(this.Connection_Console);
            // 
            // btn_connect_test
            // 
            this.btn_connect_test.Location = new System.Drawing.Point(157, 314);
            this.btn_connect_test.Name = "btn_connect_test";
            this.btn_connect_test.Size = new System.Drawing.Size(238, 56);
            this.btn_connect_test.TabIndex = 17;
            this.btn_connect_test.Text = "Test Connection";
            this.btn_connect_test.UseVisualStyleBackColor = true;
            this.btn_connect_test.Click += new System.EventHandler(this.Connection_Test);
            // 
            // btn_port_default
            // 
            this.btn_port_default.Location = new System.Drawing.Point(492, 157);
            this.btn_port_default.Name = "btn_port_default";
            this.btn_port_default.Size = new System.Drawing.Size(230, 49);
            this.btn_port_default.TabIndex = 16;
            this.btn_port_default.Text = "Default port";
            this.btn_port_default.UseVisualStyleBackColor = true;
            this.btn_port_default.Click += new System.EventHandler(this.Fill_DefaultPort);
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Location = new System.Drawing.Point(112, 166);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(75, 32);
            this.lbl_port.TabIndex = 15;
            this.lbl_port.Text = "Port:";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(212, 163);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(258, 38);
            this.txt_port.TabIndex = 14;
            // 
            // btn_host_this
            // 
            this.btn_host_this.Location = new System.Drawing.Point(492, 90);
            this.btn_host_this.Name = "btn_host_this";
            this.btn_host_this.Size = new System.Drawing.Size(230, 49);
            this.btn_host_this.TabIndex = 13;
            this.btn_host_this.Text = "This computer";
            this.btn_host_this.UseVisualStyleBackColor = true;
            this.btn_host_this.Click += new System.EventHandler(this.Fill_DefaultHost);
            // 
            // lbl_host
            // 
            this.lbl_host.AutoSize = true;
            this.lbl_host.Location = new System.Drawing.Point(106, 99);
            this.lbl_host.Name = "lbl_host";
            this.lbl_host.Size = new System.Drawing.Size(81, 32);
            this.lbl_host.TabIndex = 12;
            this.lbl_host.Text = "Host:";
            // 
            // txt_host
            // 
            this.txt_host.Location = new System.Drawing.Point(212, 96);
            this.txt_host.Name = "txt_host";
            this.txt_host.Size = new System.Drawing.Size(258, 38);
            this.txt_host.TabIndex = 11;
            // 
            // lbl_appVersion
            // 
            this.lbl_appVersion.AutoSize = true;
            this.lbl_appVersion.Location = new System.Drawing.Point(595, 409);
            this.lbl_appVersion.Name = "lbl_appVersion";
            this.lbl_appVersion.Size = new System.Drawing.Size(193, 32);
            this.lbl_appVersion.TabIndex = 22;
            this.lbl_appVersion.Text = "MCRC 0.0.0.0";
            // 
            // lbl_rconVersion
            // 
            this.lbl_rconVersion.AutoSize = true;
            this.lbl_rconVersion.Location = new System.Drawing.Point(12, 409);
            this.lbl_rconVersion.Name = "lbl_rconVersion";
            this.lbl_rconVersion.Size = new System.Drawing.Size(321, 32);
            this.lbl_rconVersion.TabIndex = 23;
            this.lbl_rconVersion.Text = "Remote Console 0.0.0.0";
            // 
            // txt_consoleOutput
            // 
            this.txt_consoleOutput.Location = new System.Drawing.Point(13, 52);
            this.txt_consoleOutput.Multiline = true;
            this.txt_consoleOutput.Name = "txt_consoleOutput";
            this.txt_consoleOutput.Size = new System.Drawing.Size(775, 270);
            this.txt_consoleOutput.TabIndex = 24;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(115, 382);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(238, 56);
            this.btn_send.TabIndex = 25;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(443, 382);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(238, 56);
            this.btn_disconnect.TabIndex = 26;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            // 
            // txt_consoleInput
            // 
            this.txt_consoleInput.Location = new System.Drawing.Point(166, 329);
            this.txt_consoleInput.Name = "txt_consoleInput";
            this.txt_consoleInput.Size = new System.Drawing.Size(622, 38);
            this.txt_consoleInput.TabIndex = 27;
            // 
            // lbl_consoleInput
            // 
            this.lbl_consoleInput.AutoSize = true;
            this.lbl_consoleInput.Location = new System.Drawing.Point(7, 332);
            this.lbl_consoleInput.Name = "lbl_consoleInput";
            this.lbl_consoleInput.Size = new System.Drawing.Size(153, 32);
            this.lbl_consoleInput.TabIndex = 28;
            this.lbl_consoleInput.Text = "Command:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 49);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(87, 45);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(230, 54);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.AppExit);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(104, 45);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(266, 54);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.ShowAboutBox);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chk_Password_Show);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.btn_connect_console);
            this.Controls.Add(this.btn_connect_test);
            this.Controls.Add(this.btn_port_default);
            this.Controls.Add(this.lbl_port);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.btn_host_this);
            this.Controls.Add(this.lbl_host);
            this.Controls.Add(this.txt_host);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbl_consoleInput);
            this.Controls.Add(this.txt_consoleInput);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.lbl_rconVersion);
            this.Controls.Add(this.lbl_appVersion);
            this.Controls.Add(this.txt_consoleOutput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "MCRC";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_Password_Show;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_connect_console;
        private System.Windows.Forms.Button btn_connect_test;
        private System.Windows.Forms.Button btn_port_default;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Button btn_host_this;
        private System.Windows.Forms.Label lbl_host;
        private System.Windows.Forms.TextBox txt_host;
        private System.Windows.Forms.Label lbl_appVersion;
        private System.Windows.Forms.Label lbl_rconVersion;
        private System.Windows.Forms.TextBox txt_consoleOutput;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.TextBox txt_consoleInput;
        private System.Windows.Forms.Label lbl_consoleInput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

