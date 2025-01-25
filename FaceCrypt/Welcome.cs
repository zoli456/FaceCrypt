using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using FaceCrypt.Face;

namespace FaceCrypt
{
    public partial class Welcome : Form
    {
        internal Login login_form;
        private string[] profiles;
        private Register register_form;

        public Welcome()
        {
            InitializeComponent();
        }

        private void register_buttton_Click(object sender, EventArgs e)
        {
            Hide();
            register_form = new Register();
            register_form.Show();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            Hide();
            login_form = new Login();
            login_form.Show();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            try
            {
                profiles = File.ReadAllLines($"{Application.StartupPath}\\{Data.facesdata_folder}\\{Data.profil_data}");
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                MessageBox.Show(
                    $"Hiba!{Environment.NewLine}{Application.StartupPath}\\{Data.facesdata_folder}\\{Data.profil_data} fájl hibás!");
                Dispose();
            }

            if (!profiles.Any(x => x.Contains("OK")))
            {
                MessageBox.Show("A számítógépen nem található érvényes profil! Kérem regisztráljon.", "Hiba",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                login_button.Enabled = false;
            }
        }
    }
}