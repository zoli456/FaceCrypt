using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace FaceCrypt
{
    public partial class Settings : Form
    {
        private string[] temp;

        public Settings()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            temp = timer_textbox.Text.Split(':');
            if (temp.Length != 3)
            {
                MessageBox.Show("Rossz formátum!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Data.logouttime = new TimeSpan(int.Parse(temp[0]), int.Parse(temp[1]), int.Parse(temp[2]));
                Data.logouttimer = Data.logouttime;
                Data.personal_ini.IniWriteValue("Security", "Logout_hours", temp[0]);
                Data.personal_ini.IniWriteValue("Security", "Logout_minutes", temp[1]);
                Data.personal_ini.IniWriteValue("Security", "Logout_seconds", temp[2]);
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                MessageBox.Show("Érvénytelen adat!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void autologout_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            Data.autologout = autologout_checkbox.Checked;
            Data.personal_ini.IniWriteValue("Security", "AutoLogout", autologout_checkbox.Checked ? "true" : "false");
        }

        private void logoutvoice_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            Data.logout_voice = logoutvoice_checkbox.Checked;
            Data.personal_ini.IniWriteValue("Security", "Logout_on_Voice",
                logoutvoice_checkbox.Checked ? "true" : "false");
        }

        private void shutdownvoice_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            Data.shutdown_voice = shutdownvoice_checkbox.Checked;
            Data.personal_ini.IniWriteValue("System", "shutdown_on_voice",
                shutdownvoice_checkbox.Checked ? "true" : "false");
        }

        private void restartvoice_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            Data.restart_voice = restartvoice_checkbox.Checked;
            Data.personal_ini.IniWriteValue("System", "restart_on_voice",
                restartvoice_checkbox.Checked ? "true" : "false");
        }

        private void hybernatevoice_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            Data.hibernate_voice = hibernatevoice_checkbox.Checked;
            Data.personal_ini.IniWriteValue("System", "hibernate_on_voice",
                hibernatevoice_checkbox.Checked ? "true" : "false");
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            timer_textbox.Text = $"{Data.logouttime.Hours}:{Data.logouttime.Minutes}:{Data.logouttime.Seconds}";
            autologout_checkbox.Checked = Data.autologout;
            logoutvoice_checkbox.Checked = Data.logout_voice;
            shutdownvoice_checkbox.Checked = Data.shutdown_voice;
            restartvoice_checkbox.Checked = Data.restart_voice;
            hibernatevoice_checkbox.Checked = Data.hibernate_voice;
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            temp = timer_textbox.Text.Split(':');
            if (temp.Length != 3)
            {
                MessageBox.Show("Rossz formátum!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Data.logouttime = new TimeSpan(int.Parse(temp[0]), int.Parse(temp[1]), int.Parse(temp[2]));
                Data.logouttimer = Data.logouttime;
                Data.personal_ini.IniWriteValue("Security", "Logout_hours", temp[0]);
                Data.personal_ini.IniWriteValue("Security", "Logout_minutes", temp[1]);
                Data.personal_ini.IniWriteValue("Security", "Logout_seconds", temp[2]);
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                MessageBox.Show("Érvénytelen adat!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Dispose();
        }
    }
}