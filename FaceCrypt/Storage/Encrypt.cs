using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using ComponentAce.Compression.Archiver;
using ComponentAce.Compression.ZipForge;

namespace FaceCrypt.Storage
{
    public partial class Encrypt : Form
    {
        private readonly ZipForge archiver = new ZipForge();
        private readonly string extension = ".az";
        private Progress progress_form;

        public Encrypt()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (filename_label.Text == "Forrás" || destination_label.Text == "Cél")
            {
                MessageBox.Show("Kérem adja meg a forrást és a célt", "Hiba", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            destination_button.Enabled = false;
            go_button.Enabled = false;
            password_textbox.Enabled = false;
            encrypt_radiobutton.Enabled = false;
            decrypt_radiobutton.Enabled = false;
            browse_button.Enabled = false;
            progress_form = new Progress();
            progress_form.Show();
            if (encrypt_radiobutton.Checked)
                Encrypter(destination_label.Text, filename_label.Text, Path.GetDirectoryName(destination_label.Text));
            if (decrypt_radiobutton.Checked)
                Decrypter(destination_label.Text, filename_label.Text);
        }

        private void Encrypt_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Title = "Válasszon egy fájlt a ttikosításhoz";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filename_label.Text = dialog.FileName;
                if (encrypt_radiobutton.Checked)
                    destination_label.Text =
                        $"{Path.GetDirectoryName(dialog.FileName)}\\{Path.GetFileName(dialog.FileName)}{extension}";
            }
        }

        private string callculate_password()
        {
            var password = "0";
            var asciiBytes = new byte[0];
            var files =
                File.ReadAllLines(
                    $"{Application.StartupPath}\\{Data.facesdata_folder}\\{Data.verifieduser}\\{Data.facename_data}")[
                    0];
            var faces = files.Split('■');
            foreach (var image in faces)
            {
                asciiBytes =
                    Encoding.ASCII.GetBytes(
                        GetMD5($"{Application.StartupPath}\\{Data.facesdata_folder}\\{Data.verifieduser}\\{image}"));
                foreach (var value in asciiBytes)
                    password = (Convert.ToInt32(password) + value).ToString();
            }

            return $"{password}{password_textbox.Text}";
        }

        private string GetMD5(string path)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(path))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "‌​").ToLower();
                }
            }
        }

        private void Decrypter(string destination, string source_file)
        {
            try
            {
                Program.welcome.login_form.landing.logout_timer.Enabled = false;
                archiver.FileName = source_file;
                archiver.OnFileProgress += archiver_OnFileProgress;
                archiver.OpenArchive(FileMode.Open);
                archiver.BaseDir = destination;
                archiver.EncryptionAlgorithm = EncryptionAlgorithm.Aes256;
                archiver.Password = callculate_password();
                archiver.ExtractFiles("*.*");
                archiver.CloseArchive();
                destination_button.Enabled = true;
                go_button.Enabled = true;
                password_textbox.Enabled = true;
                encrypt_radiobutton.Enabled = true;
                decrypt_radiobutton.Enabled = true;
                browse_button.Enabled = true;
                progress_form.Dispose();
                MessageBox.Show("Művelet sikeresen befejeződött!", "Információ", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ae)
            {
                progress_form.Dispose();
                Debug.WriteLine(ae);
                MessageBox.Show($"Hiba történt! {Environment.NewLine}{ae}", "Hiba", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                destination_button.Enabled = true;
                go_button.Enabled = true;
                password_textbox.Enabled = true;
                encrypt_radiobutton.Enabled = true;
                decrypt_radiobutton.Enabled = true;
                browse_button.Enabled = true;
                Program.welcome.login_form.landing.logout_timer.Enabled = true;
                return;
            }

            if (deleteafter.Checked)
                try
                {
                    File.Delete(source_file);
                }
                catch (Exception e)
                {
                    MessageBox.Show("A fájl törlése sikertelen! Kérlek tegye meg kézileg!");
                }

            Program.welcome.login_form.landing.logout_timer.Enabled = true;
        }

        private void Encrypter(string new_file, string path, string base_dir)
        {
            try
            {
                Program.welcome.login_form.landing.logout_timer.Enabled = false;
                archiver.FileName = new_file;
                archiver.OnFileProgress += archiver_OnFileProgress;
                archiver.OpenArchive(FileMode.Create);
                archiver.BaseDir = base_dir;
                archiver.EncryptionAlgorithm = EncryptionAlgorithm.Aes256;
                archiver.Password = callculate_password();
                archiver.AddFiles(path);
                archiver.CloseArchive();
                destination_button.Enabled = true;
                go_button.Enabled = true;
                password_textbox.Enabled = true;
                encrypt_radiobutton.Enabled = true;
                decrypt_radiobutton.Enabled = true;
                browse_button.Enabled = true;
                progress_form.Dispose();
                MessageBox.Show("Művelet sikeresen befejeződött!", "Információ", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ae)
            {
                progress_form.Dispose();
                Debug.WriteLine(ae);
                MessageBox.Show($"Hiba történt! {Environment.NewLine}{ae}", "Hiba", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                destination_button.Enabled = true;
                go_button.Enabled = true;
                password_textbox.Enabled = true;
                encrypt_radiobutton.Enabled = true;
                decrypt_radiobutton.Enabled = true;
                browse_button.Enabled = true;
                Program.welcome.login_form.landing.logout_timer.Enabled = true;
                return;
            }

            if (deleteafter.Checked)
                try
                {
                    File.Delete(path);
                }
                catch (Exception e)
                {
                    MessageBox.Show("A fájl törlése sikertelen! Kérjük tegye meg kézileg!");
                }

            Program.welcome.login_form.landing.logout_timer.Enabled = true;
        }

        private void archiver_OnFileProgress(object sender, string fileName, double progress,
            TimeSpan timeElapsed, TimeSpan timeLeft, ProcessOperation operation,
            ProgressPhase progressPhase, ref bool cancel)
        {
            progress_form.time_label.Text = $"Hátralévő idő: {timeLeft.ToString(@"hh\:mm\:ss")}";
            progress_form.Bar.Value = Convert.ToInt16(progress);
            progress_form.Refresh();
        }

        private void destination_button_Click(object sender, EventArgs e)
        {
            if (encrypt_radiobutton.Checked)
            {
                var dialog = new SaveFileDialog();
                dialog.Title = "Hová szeretné menteni a fájlt?";
                if (dialog.ShowDialog() == DialogResult.OK)
                    destination_label.Text = dialog.FileName;
            }

            if (decrypt_radiobutton.Checked)
                using (var fbd = new FolderBrowserDialog())
                {
                    var result = fbd.ShowDialog();
                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                        destination_label.Text = fbd.SelectedPath;
                }
        }

        private void encrypt_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            destination_label.Text = "Cél";
        }

        private void decrypt_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            destination_label.Text = "Cél";
        }
    }
}