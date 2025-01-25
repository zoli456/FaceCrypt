using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using FaceDetection;

namespace FaceCrypt.Face
{
    public partial class Login : Form
    {
        private readonly List<Rectangle> eyes = new List<Rectangle>();
        private readonly List<int> faceIDs = new List<int>();
        private readonly List<Rectangle> faces = new List<Rectangle>();
        private readonly Font font = new Font("Arial", 12, FontStyle.Bold);
        private readonly List<string> labels = new List<string>();
        private readonly List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        private int ContTrain;
        private Image<Bgr, byte> currentImage;
        private long detectionTime;
        private EigenFaceRecognizer facedetector;
        private VideoCapture grabber;
        private Image<Gray, byte> gray;
        private string[] images;
        private int Kamera_index;
        internal Landing landing;
        private string password;
        private string[] profiles;

        public Login()
        {
            InitializeComponent();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Kamerak_frissitese();
        }

        private void drawText(Image<Bgr, byte> img, Rectangle rect, string text)
        {
            var g = Graphics.FromImage(img.Bitmap);

            var tWidth = (int)g.MeasureString(text, font).Width;
            int x;
            if (tWidth >= rect.Width)
                x = rect.Left - (tWidth - rect.Width) / 2;
            else
                x = rect.Width / 2 - tWidth / 2 + rect.Left;

            g.DrawString(text, font, Brushes.Red, new PointF(x, rect.Top - 18));
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Kamerak_frissitese();
            string[] temp;
            var temp2 = new string[0];
            try
            {
                profiles =
                    File.ReadAllLines($"{Application.StartupPath}\\{Data.facesdata_folder}\\{Data.profil_data}");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                MessageBox.Show($"{Data.facesdata_folder}\\{Data.profil_data} fájl hibás!", "Hiba",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.welcome.Show();
                Closewindow();
            }

            labels.Add("Ismeretlen");
            foreach (var t2 in profiles)
            {
                temp = t2.Split(' ');
                try
                {
                    ContTrain += Convert.ToInt32(temp[2]); //Képek összeszámolása
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{Data.facesdata_folder}\\{Data.profil_data} fájl hibás!", "Hiba",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Debug.WriteLine(ex);
                    Program.welcome.Show();
                    Closewindow();
                    return;
                }

                try
                {
                    images = File.ReadAllLines($"{Data.facesdata_folder}\\{temp[0]}\\{Data.facename_data}");
                    if (images.Length != 1)
                        throw new Exception($"{Data.facename_data} csak 1 sorból állhat!");
                    temp2 = images[0].Split('■');
                    if (temp2.Length.ToString() != temp[2])
                        throw new Exception($"{temp[1]} profil hibás!");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                    MessageBox.Show($"{Data.facesdata_folder}\\{temp[0]}\\{Data.facename_data} fájl hibás!", "Hiba",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.welcome.Show();
                    Closewindow();
                    return;
                }

                foreach (var t1 in temp2)
                {
                    faceIDs.Add(faceIDs.Count + 1);
                    trainingImages.Add(
                        new Image<Gray, byte>($"{Application.StartupPath}\\{Data.facesdata_folder}\\{temp[1]}\\{t1}")
                            .Resize(100, 100, Inter.Cubic));
                    labels.Add(temp[1]);
                }
            }

            facedetector = new EigenFaceRecognizer(ContTrain, 3000); //Megendgedett eltérés
            facedetector.Train(trainingImages.ToArray(), faceIDs.ToArray());
        }

        private void kamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //-> Get the selected item in the combobox
                var SelectedItem = (KeyValuePair<int, string>)kamera.SelectedItem;

                //-> Assign selected cam index to defined var
                Kamera_index = SelectedItem.Key;
            }
            catch (Exception ex)
            {
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.welcome.Show();
            Closewindow();
        }

        private void Kamerak_frissitese()
        {
            //-> clear the combobox
            kamera.DataSource = null;
            kamera.Items.Clear();

            //-> bind the combobox
            kamera.DataSource = new BindingSource(Webcam.Get_Kamera_lista(), null);
            kamera.DisplayMember = "Value";
            kamera.ValueMember = "Key";
            if (kamera.Items.Count == 0)
            {
                login_button.Enabled = false;
                MessageBox.Show("Nem található webkamera!", "Nincs webkamera", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                login_button.Enabled = true;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            login_button.Enabled = false;
            checkBox1.Enabled = false;
            kamera.Enabled = false;
            username_text.Enabled = false;
            password_textbox.Enabled = false;
            refresh.Enabled = false;
            if (!Directory.Exists($"{Application.StartupPath}\\{Data.facesdata_folder}\\{username_text.Text}"))
            {
                MessageBox.Show("A felhasználó nem létezik!", "Bejelentkezés", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                login_button.Enabled = true;
                checkBox1.Enabled = true;
                kamera.Enabled = true;
                username_text.Enabled = true;
                password_textbox.Enabled = true;
                refresh.Enabled = true;
                return;
            }

            try
            {
                password =
                    File.ReadAllText(
                        $"{Application.StartupPath}\\{Data.facesdata_folder}\\{username_text.Text}\\{Data.password_location}");
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                MessageBox.Show($"Hiba!{Environment.NewLine}{exception}", "Hiba", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                login_button.Enabled = true;
                checkBox1.Enabled = true;
                kamera.Enabled = true;
                username_text.Enabled = true;
                password_textbox.Enabled = true;
                refresh.Enabled = true;
            }

            try
            {
                if (Crypto.DecryptStringAES(password, password_textbox.Text) != username_text.Text)
                {
                    MessageBox.Show("Helytelen jelszó!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    login_button.Enabled = true;
                    checkBox1.Enabled = true;
                    kamera.Enabled = true;
                    username_text.Enabled = true;
                    password_textbox.Enabled = true;
                    refresh.Enabled = true;
                }
                else
                {
                    Data.verifieduser = username_text.Text;
                    landing = new Landing();
                    landing.Show();
                    Closewindow();
                }
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                MessageBox.Show("Helytelen jelszó!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                login_button.Enabled = true;
                checkBox1.Enabled = true;
                kamera.Enabled = true;
                username_text.Enabled = true;
                password_textbox.Enabled = true;
                refresh.Enabled = true;
            }
        }

        public int RecognizeUser(Image<Gray, byte> userImage)
        {
            var result = facedetector.Predict(userImage.Resize(100, 100, Inter.Cubic));
            Debug.WriteLine(result.Label);
            if (result.Label != 0) Debug.WriteLine($"Siker {labels[result.Label]} {result.Label}");
            return result.Label;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Enabled = false;
                //Initialize the capture device
                grabber = new VideoCapture(Kamera_index);
                grabber.QueryFrame();
                //Initialize the FrameGraber event
                Application.Idle += FrameGrabber;
                checkBox1.Enabled = true;
            }
            else
            {
                Application.Idle -= FrameGrabber;
                grabber?.Dispose();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            password_textbox.PasswordChar = checkBox2.Checked ? '\0' : '*';
        }

        private void FrameGrabber(object sender, EventArgs e)
        {
            faces.Clear();
            eyes.Clear();

            //Get the current frame form capture device
            currentImage = grabber.QueryFrame().ToImage<Bgr, byte>().Resize(320, 240, Inter.Cubic);
            //Face Detector
            DetectFace.Detect(
                currentImage, "haarcascade_frontalface_default.xml", "haarcascade_eye.xml",
                faces, eyes,
                out detectionTime);

            foreach (var face in faces)
            {
                CvInvoke.Rectangle(currentImage, face, new Bgr(Color.Red).MCvScalar, 2);
                gray = currentImage.Copy(face).Resize(100, 100, Inter.Cubic).Convert<Gray, byte>();
                gray._EqualizeHist();
                //  gray = gray.SmoothBilatral(3, 255, 5);
                var recognisedid = RecognizeUser(gray);
                drawText(currentImage, face, labels[recognisedid]);
                if (checkBox1.Checked && labels[recognisedid] != "Ismeretlen")
                {
                    Data.verifieduser = labels[recognisedid];
                    username_text.Text = labels[recognisedid];
                }
            }

            foreach (var eye in eyes)
                CvInvoke.Rectangle(currentImage, eye, new Bgr(Color.Blue).MCvScalar, 2);

            imageBoxFrameGrabber.DisplayedImage = currentImage;
        }

        private void Closewindow()
        {
            Application.Idle -= FrameGrabber;
            grabber?.Dispose();
            Dispose();
        }
    }
}