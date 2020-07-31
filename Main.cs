using MCRC.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCRC
{
    public partial class Main : Form
    {
        private static readonly string rcon_path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "mcrcon.exe");
        private string rconHost;
        private int rconPort;
        private string rconPassword;

        private readonly ProcessStartInfo rconConnection = new ProcessStartInfo
        {
            FileName = rcon_path,
            UseShellExecute = false,
            RedirectStandardOutput = true,
            CreateNoWindow = true,
            WindowStyle = ProcessWindowStyle.Hidden
        };

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            AppCheck();
            lbl_appVersion.Text = this.Text + " " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            lbl_rconVersion.Text = "Remote Console " + GetRconVersion();
            aboutToolStripMenuItem.Text = "About " + this.Text;
            DisplayControls("menu");
        }

        private void Connection_Test(object sender, EventArgs e)
        {
            if (AppCheck())
            {
                if (CheckConnection())
                {
                    MessageBox.Show("Connection successful.",
                                    Application.OpenForms["Main"].Text,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
        }

        private void Connection_Console(object sender, EventArgs e)
        {
            Command_Run(true, "-t");
        }

        private void Fill_DefaultHost(object sender, EventArgs e)
        {
            txt_host.Text = SetDefaults("host");
        }

        private void Fill_DefaultPort(object sender, EventArgs e)
        {
            txt_port.Text = SetDefaults("port");
        }

        private void ShowPassword(object sender, EventArgs e)
        {
            if (chk_Password_Show.Checked == true)
            {
                txt_password.PasswordChar = '\0';
            }
            else
            {
                txt_password.PasswordChar = '*';
            }
        }

        private string SetDefaults(string field)
        {
            switch (field)
            {
                case "host":
                    return "localhost";
                case "port":
                    return "25575";
                default:
                    return null;
            }
        }

        private bool CheckForm()
        {
            if (!String.IsNullOrWhiteSpace(txt_host.Text))
            {
                if (!String.IsNullOrWhiteSpace(txt_password.Text))
                {
                    if (String.IsNullOrWhiteSpace(txt_port.Text))
                    {
                        txt_port.Text = "25575";
                    }
                    rconHost = txt_host.Text;
                    try
                    {
                        rconPort = int.Parse(txt_port.Text, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Invalid port value: " + e.Message, Application.OpenForms["Main"].Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    rconPassword = txt_password.Text;
                    return true;
                }
                else
                {
                    MessageBox.Show("Please enter a password.",
                                    Application.OpenForms["Main"].Text,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please enter a host ip address.",
                                Application.OpenForms["Main"].Text,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
        }

        private bool CheckConnection()
        {
            if (CheckForm())
            {
                RefreshProcessInfo();
                rconConnection.Arguments = "-H " + rconHost + " -P " + rconPort + " -p " + rconPassword + " \"\"";
                try
                {
                    var rconProcess = Process.Start(rconConnection);
                    rconProcess.WaitForExit();

                    if (rconProcess.ExitCode == 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Unable to connect to the server: " + rconProcess.StandardOutput.ReadToEnd(),
                                        Application.OpenForms["Main"].Text,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error has occured while trying to connect to the server: " + ex.Message,
                                    Application.OpenForms["Main"].Text,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private bool Command_Run(bool online, string command)
        {
            if (AppCheck())
            {
                if (online)
                {
                    if (CheckConnection())
                    {
                        try
                        {
                            rconConnection.Arguments = "-H " + rconHost + " -P " + rconPort + " -p " + rconPassword;

                            if (command == "-t")
                            {
                                rconConnection.Arguments += " -t";
                                rconConnection.UseShellExecute = true;
                                rconConnection.RedirectStandardOutput = false;
                                rconConnection.CreateNoWindow = false;
                                rconConnection.WindowStyle = ProcessWindowStyle.Normal;
                                this.Visible = false;
                                var rconProcess = Process.Start(rconConnection);
                                rconProcess.WaitForExit();
                                this.Visible = true;
                                return true;
                            }
                            else
                            {
                                rconConnection.Arguments += " \"" + command + "\"";
                                var rconProcess = Process.Start(rconConnection);
                                rconProcess.WaitForExit();

                                if (rconProcess.ExitCode == 0)
                                {
                                    MessageBox.Show("Command executed successfully.",
                                                    Application.OpenForms["Main"].Text,
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);
                                    return true;
                                }
                                else
                                {
                                    MessageBox.Show("Unable to connect to the server: " + rconProcess.StandardOutput.ReadToEnd(),
                                                    Application.OpenForms["Main"].Text,
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Error);
                                    return false;
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("An error has occured: " + e.Message, Application.OpenForms["Main"].Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    rconConnection.Arguments = command;
                    try
                    {
                        var rconProcess = Process.Start(rconConnection);
                        rconProcess.WaitForExit();

                        if (rconProcess.ExitCode == 0)
                        {
                            MessageBox.Show(rconProcess.StandardOutput.ReadToEnd(),
                                            Application.OpenForms["Main"].Text,
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show(rconProcess.StandardOutput.ReadToEnd(),
                                            Application.OpenForms["Main"].Text,
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Unable to run the command: " + e.Message,
                                        Application.OpenForms["Main"].Text,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
        }

        private bool AppCheck()
        {
            return File.Exists(rcon_path) || Mcrcon_Extract();
        }

        private bool Mcrcon_Extract()
        {
            try
            {
                using (FileStream fsDst = new FileStream(rcon_path, FileMode.CreateNew, FileAccess.Write))
                {
                    byte[] bytes = Resources.mcrcon;
                    fsDst.Write(bytes, 0, bytes.Length);
                }
                return File.Exists(rcon_path);
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to extract the executable: " + e.Message,
                                "Error | " + this.Text,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
        }

        private void RefreshProcessInfo()
        {
            rconConnection.FileName = rcon_path;
            rconConnection.UseShellExecute = false;
            rconConnection.RedirectStandardOutput = true;
            rconConnection.CreateNoWindow = true;
            rconConnection.WindowStyle = ProcessWindowStyle.Hidden;
        }

        private void DisplayControls(string controls = null)
        {
            bool menuVisibility = false;
            bool consoleVisibility = false;
            switch (controls)
            {
                case "menu":
                    menuVisibility = true;
                    consoleVisibility = false;
                    break;
                case "console":
                    menuVisibility = false;
                    consoleVisibility = true;
                    break;
                default:
                    break;
            }

            lbl_host.Visible = menuVisibility;
            lbl_port.Visible = menuVisibility;
            lbl_password.Visible = menuVisibility;
            lbl_rconVersion.Visible = menuVisibility;
            lbl_appVersion.Visible = menuVisibility;

            txt_host.Visible = menuVisibility;
            txt_port.Visible = menuVisibility;
            txt_password.Visible = menuVisibility;

            chk_Password_Show.Visible = menuVisibility;

            btn_host_this.Visible = menuVisibility;
            btn_port_default.Visible = menuVisibility;
            btn_connect_test.Visible = menuVisibility;
            btn_connect_console.Visible = menuVisibility;

            lbl_consoleInput.Visible = consoleVisibility;
            txt_consoleOutput.Visible = consoleVisibility;
            txt_consoleInput.Visible = consoleVisibility;
            btn_send.Visible = consoleVisibility;
            btn_disconnect.Visible = consoleVisibility;
        }

        private string GetRconVersion()
        {
            if (AppCheck())
            {
                rconConnection.Arguments = "-v";
                var proc = Process.Start(rconConnection);
                proc.WaitForExit();
                if (proc.ExitCode == 0)
                {
                    var output = proc.StandardOutput.ReadToEnd();
                    return GetBetween(output, " ", " (");
                }
            }
            return null;
        }

        // https://stackoverflow.com/a/10709874
        public static string GetBetween(string strSource, string strStart, string strEnd)
        {
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                int Start, End;
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            return "";
        }

        private void ShowAboutBox(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void AppExit(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                System.Environment.Exit(1);
            }
        }
    }
}
