using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using FaceCrypt.Storage;
using Microsoft.Speech.Recognition;

namespace FaceCrypt
{
    public partial class Landing : Form
    {
        private static SpeechRecognitionEngine recognizer;
        private About about_form;
        internal Encrypt enc_form;
        private Settings settings_form;

        public Landing()
        {
            InitializeComponent();
        }

        private void fájltitkosítóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enc_form = new Encrypt();
            enc_form.Show();
        }

        private void névjegyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about_form = new About();
            about_form.Show();
        }

        private void gmh_TheMouseMoved()
        {
            Data.logouttimer = Data.logouttime;
        }

        private void Landing_Load(object sender, EventArgs e)
        {
            Data.personal_ini =
                new IniHandler(
                    $"{Application.StartupPath}\\{Data.facesdata_folder}\\{Data.verifieduser}\\{Data.settings_ini}");
            Data.logouttimer = Data.logouttime;
            Text = $"Belépve, mint {Data.verifieduser}";
            var gmh = new GlobalMouseHandler();
            gmh.TheMouseMoved += gmh_TheMouseMoved;
            Application.AddMessageFilter(gmh);
            if (
                !File.Exists(
                    $"{Application.StartupPath}\\{Data.facesdata_folder}\\{Data.verifieduser}\\{Data.settings_ini}"))
            {
                Data.logouttime = new TimeSpan(0, 0, 30);
                Data.personal_ini.IniWriteValue("Security", "Logout_hours", "0");
                Data.personal_ini.IniWriteValue("Security", "Logout_minutes", "0");
                Data.personal_ini.IniWriteValue("Security", "Logout_seconds", "30");
                Data.personal_ini.IniWriteValue("Security", "AutoLogout", "true");
                Data.personal_ini.IniWriteValue("Security", "Logout_on_Voice", "false");
                Data.personal_ini.IniWriteValue("System", "shutdown_on_voice", "false");
                Data.personal_ini.IniWriteValue("System", "restart_on_voice", "false");
                Data.personal_ini.IniWriteValue("System", "hibernate_on_voice", "false");
            }
            else
            {
                Data.logouttime = new TimeSpan(int.Parse(Data.personal_ini.IniReadValue("Security", "Logout_hours")),
                    int.Parse(Data.personal_ini.IniReadValue("Security", "Logout_minutes")),
                    int.Parse(Data.personal_ini.IniReadValue("Security", "Logout_seconds")));
                Data.autologout = Convert.ToBoolean(Data.personal_ini.IniReadValue("Security", "AutoLogout"));
                Data.logout_voice = Convert.ToBoolean(Data.personal_ini.IniReadValue("Security", "Logout_on_Voice"));
                Data.shutdown_voice = Convert.ToBoolean(Data.personal_ini.IniReadValue("System", "shutdown_on_voice"));
                Data.restart_voice = Convert.ToBoolean(Data.personal_ini.IniReadValue("System", "restart_on_voice"));
                Data.hibernate_voice =
                    Convert.ToBoolean(Data.personal_ini.IniReadValue("System", "hibernate_on_voice"));
            }

            Data.personal_ini.IniWriteValue("Login", "LastLogin", DateTime.Now.ToString());

            try
            {
                //hangfelismerés elindítása       
                recognizer = new SpeechRecognitionEngine(new CultureInfo("en-US"));
                var hangutasitas = new Choices("logout", "shutdown", "restart", "hibernate");
                var grammarbuilder = new GrammarBuilder(hangutasitas) { Culture = new CultureInfo("en-us") };
                recognizer.LoadGrammar(new Grammar(grammarbuilder));

                recognizer.SpeechRecognized += speechrecognised;
                // if speech is recognized, call the specified method
                recognizer.SetInputToDefaultAudioDevice(); // set the input to the default audio device
                recognizer.RecognizeAsync(RecognizeMode.Multiple); // recognize speech asynchronous
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                MessageBox.Show("A hangfelismerés nem sikerült elindítani!", "Hiba", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void speechrecognised(object sender, SpeechRecognizedEventArgs e)
        {
            Debug.WriteLine(e.Result.Text);
            switch (e.Result.Text)
            {
                case "logout":
                {
                    if (Data.logout_voice)
                    {
                        Program.welcome.Show();
                        clearlogin();
                    }

                    break;
                }
                case "shutdown":
                {
                    if (Data.shutdown_voice)
                    {
                        var proc = new ProcessStartInfo();
                        proc.WindowStyle = ProcessWindowStyle.Hidden;
                        proc.FileName = "cmd";
                        proc.Arguments = "/C shutdown -f -s -t 0";
                        Process.Start(proc);
                    }

                    break;
                }
                case "restart":
                {
                    if (Data.restart_voice)
                    {
                        var proc = new ProcessStartInfo();
                        proc.WindowStyle = ProcessWindowStyle.Hidden;
                        proc.FileName = "cmd";
                        proc.Arguments = "/C shutdown -f -r -t 0";
                        Process.Start(proc);
                    }

                    break;
                }
                case "hibernate":
                {
                    if (Data.hibernate_voice)
                    {
                        var proc = new ProcessStartInfo();
                        proc.WindowStyle = ProcessWindowStyle.Hidden;
                        proc.FileName = "cmd";
                        proc.Arguments = "/C shutdown -f -h -t 0";
                        Process.Start(proc);
                    }

                    break;
                }
            }
        }

        private void logout_timer_Tick(object sender, EventArgs e)
        {
            if (!Data.autologout) return;
            Data.logouttimer -= TimeSpan.FromSeconds(1);
            logout_label.Text = $"Kijelentkezés:{Data.logouttimer.ToString(@"hh\:mm\:ss")}";
            if (Data.logouttimer.TotalSeconds == 0)
            {
                Program.welcome.Show();
                clearlogin();
            }
        }

        private void clearlogin()
        {
            try
            {
                recognizer.SpeechRecognized -= speechrecognised;
            }
            catch
            {
            }

            Data.verifieduser = "";
            enc_form?.Dispose();
            about_form?.Dispose();
            settings_form?.Dispose();
            Dispose();
        }

        private void kijelentkezésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.welcome.Show();
            clearlogin();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearlogin();
            Program.welcome.Dispose();
        }

        private void Landing_FormClosing(object sender, FormClosingEventArgs e)
        {
            clearlogin();
            Program.welcome.Dispose();
        }

        private void beállításokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings_form = new Settings();
            settings_form.Show();
        }

        #region Egér mozdítás érzékelés

        public delegate void MouseMovedEvent();

        public class GlobalMouseHandler : IMessageFilter
        {
            private const int WM_MOUSEMOVE = 0x0200;

            public event MouseMovedEvent TheMouseMoved;

            public bool PreFilterMessage(ref Message m)
            {
                if (m.Msg == WM_MOUSEMOVE)
                    if (TheMouseMoved != null)
                        TheMouseMoved();
                // Always allow message to continue to the next filter control
                return false;
            }

            #endregion
        }
    }
}