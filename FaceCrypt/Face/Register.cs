using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using FaceCrypt.Face;
using FaceDetection;
using Microsoft.Speech.Recognition;

namespace FaceCrypt
{
    public partial class Register : Form
    {
        private static SpeechRecognitionEngine recognizer;
        private readonly string exe_helye = Application.StartupPath;
        private readonly List<Rectangle> eyes = new List<Rectangle>();
        private readonly List<Rectangle> faces = new List<Rectangle>();
        private readonly byte szukseges_kepek = 7;
        private Image<Bgr, byte> currentImage;
        private long detectionTime;
        private byte elkeszitett_kepek;
        private VideoCapture grabber;
        private Image<Gray, byte> gray;
        private int Kamera_index;

        public Register()
        {
            InitializeComponent();
        }


        private void Register_Load(object sender, EventArgs e)
        {
            üzenetek.Text =
                $"Első lépés, hogy megadja a profilnevét. Szükség lesz {szukseges_kepek} kép önről.  Próbáljon minnél több fényviszonyt és beállást lefényképezni a programmal.";
            szukseges_kepek_label.Text = string.Format("Még {0}/{1} kép kell", elkeszitett_kepek, szukseges_kepek);
            szukseges_kepek_progressbar.Maximum = szukseges_kepek;
            Kamerak_frissitese();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Kamerak_frissitese();
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
                start_webcam_button.Enabled = false;
                MessageBox.Show("Nem található webkamera!", "Nincs webkamera", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                start_webcam_button.Enabled = true;
            }
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (faces.Count != 1 || eyes.Count != 2) return;
            gray = grabber.QueryFrame().ToImage<Gray, byte>().Resize(320, 240, Inter.Cubic).Copy(faces[0]);
            //normalizes brightness and increases contrast of the image
            gray = gray.Resize(100, 100, Inter.Cubic);
            CvInvoke.EqualizeHist(gray, gray);
            imageBox1.Image = gray;
            //Write the labels of triained faces in a file text for further load
            gray.Save(
                $"{exe_helye}/{Data.facesdata_folder}/{regisztracios_nev.Text}/face{elkeszitett_kepek}.bmp");
            //Le menti a képeket
            File.AppendAllText($"{exe_helye}/{Data.facesdata_folder}/{regisztracios_nev.Text}/{Data.facename_data}",
                $"face{elkeszitett_kepek}.bmp");
            //Kész a kép
            elkeszitett_kepek++;
            szukseges_kepek_progressbar.Value = elkeszitett_kepek;
            szukseges_kepek_label.Text = $"Még {elkeszitett_kepek}/{szukseges_kepek} kép kell";

            if (elkeszitett_kepek == szukseges_kepek)
            {
                using (var sw = File.AppendText($"{exe_helye}/{Data.facesdata_folder}/{Data.profil_data}"))
                {
                    sw.Write("OK"); //Megerősítés, hogy elkészültek a képek
                }

                MessageBox.Show(
                    $"{regisztracios_nev.Text} profil sikeresen regisztrálva! Most már beléphet vele.",
                    "Megerősítés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.welcome.login_button.Enabled = true;
                Program.welcome.Show();
                Closewindow();
            }
            else
            {
                File.AppendAllText(
                    $"{exe_helye}/{Data.facesdata_folder}/{regisztracios_nev.Text}/{Data.facename_data}", "■");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (regisztracios_nev.Text.Length < 4 || passoword_textbox.Text.Length < 5)
            {
                MessageBox.Show(
                    "A felhasználói névnek legalább 4 karakternek kell lennie. A jelszónak pedig minimum 5 karakterből kell állnia",
                    "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists($"{Application.StartupPath}\\{Data.facesdata_folder}\\{Data.profil_data}"))
            {
                MessageBox.Show($"{Data.profil_data} fájl hiányik!", "Hiba", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (Directory.Exists($"{Application.StartupPath}\\{Data.facesdata_folder}\\{regisztracios_nev.Text}"))
            {
                MessageBox.Show("Ez a profil már létezik!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var newline = File.ReadAllLines($"{Application.StartupPath}\\{Data.facesdata_folder}\\{Data.profil_data}")
                .Length != 0;
            try
            {
                Directory.CreateDirectory($"{exe_helye}/{Data.facesdata_folder}/{regisztracios_nev.Text}");
                using (var sw = File.AppendText($"{exe_helye}/{Data.facesdata_folder}/{Data.profil_data}"))
                {
                    if (newline)
                        sw.WriteLine();
                    sw.Write($"{regisztracios_nev.Text} "); //Név
                    sw.Write($"{regisztracios_nev.Text} "); //Mappa név
                    sw.Write($"{szukseges_kepek} "); //Szükséges képek
                }
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                MessageBox.Show("Profil létrehozás sikertelen!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                File.WriteAllText(
                    $"{Application.StartupPath}\\{Data.facesdata_folder}\\{regisztracios_nev.Text}\\{Data.password_location}",
                    Crypto.EncryptStringAES(regisztracios_nev.Text, passoword_textbox.Text));
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                MessageBox.Show("Profil létrehozása sikertelen!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            regisztracios_nev.ReadOnly = true;
            passoword_textbox.ReadOnly = true;
            start_webcam_button.Enabled = false;
            //Initialize the capture device
            grabber = new VideoCapture(Kamera_index);
            grabber.QueryFrame();
            //Initialize the FrameGraber event
            Application.Idle += FrameGrabber;

            try
            {
                //hangfelismerés elindítása       
                recognizer = new SpeechRecognitionEngine(new CultureInfo("en-US"));
                var hangutasitas = new Choices("take");
                var grammarbuilder = new GrammarBuilder(hangutasitas) { Culture = new CultureInfo("en-us") };
                recognizer.LoadGrammar(new Grammar(grammarbuilder));

                recognizer.SpeechRecognized += _kepkeszites_hangutan;
                // if speech is recognized, call the specified method
                recognizer.SetInputToDefaultAudioDevice(); // set the input to the default audio device
                recognizer.RecognizeAsync(RecognizeMode.Multiple); // recognize speech asynchronous
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                MessageBox.Show("Hangfelismerés elindítása sikertelen.", "Hiba", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.welcome.Show();
            Closewindow();
        }

        private void _kepkeszites_hangutan(object sender, SpeechRecognizedEventArgs e)
        {
            Debug.WriteLine(e.Result.Text);
            if (e.Result.Text == "take")
                button1_Click_1(null, null);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            passoword_textbox.PasswordChar = checkBox1.Checked ? '\0' : '*';
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
            people_label.Text = faces.Count.ToString();
            foreach (var face in faces)
                CvInvoke.Rectangle(currentImage, face, new Bgr(Color.Red).MCvScalar, 2);

            foreach (var eye in eyes)
                CvInvoke.Rectangle(currentImage, eye, new Bgr(Color.Blue).MCvScalar, 2);


            imageBoxFrameGrabber.DisplayedImage = currentImage;
        }

        private void Closewindow()
        {
            try
            {
                recognizer.SpeechRecognized -= _kepkeszites_hangutan;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }

            Application.Idle -= FrameGrabber;
            grabber?.Dispose();
            Dispose();
        }
    }
}