namespace FaceCrypt
{
    partial class Register
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.regisztracios_nev = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.people_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.start_webcam_button = new System.Windows.Forms.Button();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Fotozas_button = new System.Windows.Forms.Button();
            this.szukseges_kepek_label = new System.Windows.Forms.Label();
            this.szukseges_kepek_progressbar = new System.Windows.Forms.ProgressBar();
            this.üzenetek = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kamera = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passoword_textbox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            this.SuspendLayout();
            // 
            // regisztracios_nev
            // 
            this.regisztracios_nev.Location = new System.Drawing.Point(43, 158);
            this.regisztracios_nev.Name = "regisztracios_nev";
            this.regisztracios_nev.Size = new System.Drawing.Size(131, 20);
            this.regisztracios_nev.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.passoword_textbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.regisztracios_nev);
            this.groupBox1.Controls.Add(this.imageBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(342, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 242);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Felhasználó";
            // 
            // imageBox1
            // 
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.Location = new System.Drawing.Point(11, 18);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(163, 134);
            this.imageBox1.TabIndex = 5;
            this.imageBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Név";
            // 
            // people_label
            // 
            this.people_label.AutoSize = true;
            this.people_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.people_label.ForeColor = System.Drawing.Color.Red;
            this.people_label.Location = new System.Drawing.Point(106, 89);
            this.people_label.Name = "people_label";
            this.people_label.Size = new System.Drawing.Size(16, 16);
            this.people_label.TabIndex = 15;
            this.people_label.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Személy(ek):";
            // 
            // start_webcam_button
            // 
            this.start_webcam_button.Enabled = false;
            this.start_webcam_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.start_webcam_button.Location = new System.Drawing.Point(55, 183);
            this.start_webcam_button.Name = "start_webcam_button";
            this.start_webcam_button.Size = new System.Drawing.Size(110, 53);
            this.start_webcam_button.TabIndex = 2;
            this.start_webcam_button.Text = "Indítás";
            this.start_webcam_button.UseVisualStyleBackColor = true;
            this.start_webcam_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(12, 12);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(320, 240);
            this.imageBoxFrameGrabber.TabIndex = 4;
            this.imageBoxFrameGrabber.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Fotozas_button);
            this.groupBox3.Controls.Add(this.szukseges_kepek_label);
            this.groupBox3.Controls.Add(this.szukseges_kepek_progressbar);
            this.groupBox3.Controls.Add(this.üzenetek);
            this.groupBox3.Controls.Add(this.checkedListBox1);
            this.groupBox3.Controls.Add(this.people_label);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(10, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(751, 242);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Információk";
            // 
            // Fotozas_button
            // 
            this.Fotozas_button.Location = new System.Drawing.Point(577, 191);
            this.Fotozas_button.Name = "Fotozas_button";
            this.Fotozas_button.Size = new System.Drawing.Size(118, 36);
            this.Fotozas_button.TabIndex = 22;
            this.Fotozas_button.Text = "Fotózás";
            this.Fotozas_button.UseVisualStyleBackColor = true;
            this.Fotozas_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // szukseges_kepek_label
            // 
            this.szukseges_kepek_label.AutoSize = true;
            this.szukseges_kepek_label.Location = new System.Drawing.Point(146, 191);
            this.szukseges_kepek_label.Name = "szukseges_kepek_label";
            this.szukseges_kepek_label.Size = new System.Drawing.Size(89, 13);
            this.szukseges_kepek_label.TabIndex = 21;
            this.szukseges_kepek_label.Text = "Még 5/X kép kell";
            // 
            // szukseges_kepek_progressbar
            // 
            this.szukseges_kepek_progressbar.Location = new System.Drawing.Point(13, 207);
            this.szukseges_kepek_progressbar.Name = "szukseges_kepek_progressbar";
            this.szukseges_kepek_progressbar.Size = new System.Drawing.Size(382, 29);
            this.szukseges_kepek_progressbar.TabIndex = 20;
            // 
            // üzenetek
            // 
            this.üzenetek.Location = new System.Drawing.Point(401, 77);
            this.üzenetek.Multiline = true;
            this.üzenetek.Name = "üzenetek";
            this.üzenetek.Size = new System.Drawing.Size(344, 99);
            this.üzenetek.TabIndex = 19;
            this.üzenetek.Text = " Első lépés, hogy megadja a profil nevét. Szükség lesz 7 képre önről.  Próbáljon " +
    "minnél több fényviszony és beállást lefényképezni a programmal.";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(537, 157);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.refresh);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.kamera);
            this.groupBox2.Controls.Add(this.start_webcam_button);
            this.groupBox2.Location = new System.Drawing.Point(532, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 242);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Webkamera";
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Transparent;
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.Location = new System.Drawing.Point(187, 73);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(38, 38);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refresh.TabIndex = 5;
            this.refresh.TabStop = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Kamera";
            // 
            // kamera
            // 
            this.kamera.FormattingEnabled = true;
            this.kamera.Location = new System.Drawing.Point(55, 46);
            this.kamera.Name = "kamera";
            this.kamera.Size = new System.Drawing.Size(170, 21);
            this.kamera.TabIndex = 3;
            this.kamera.SelectedIndexChanged += new System.EventHandler(this.kamera_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Jelszó";
            // 
            // passoword_textbox
            // 
            this.passoword_textbox.Location = new System.Drawing.Point(43, 187);
            this.passoword_textbox.Name = "passoword_textbox";
            this.passoword_textbox.PasswordChar = '*';
            this.passoword_textbox.Size = new System.Drawing.Size(131, 20);
            this.passoword_textbox.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(43, 218);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Jelszó megjelenítése";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 530);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imageBoxFrameGrabber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regisztráció";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.Load += new System.EventHandler(this.Register_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.TextBox regisztracios_nev;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label people_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button start_webcam_button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox kamera;
        private System.Windows.Forms.PictureBox refresh;
        private System.Windows.Forms.Label szukseges_kepek_label;
        private System.Windows.Forms.ProgressBar szukseges_kepek_progressbar;
        private System.Windows.Forms.TextBox üzenetek;
        private System.Windows.Forms.Button Fotozas_button;
        private System.Windows.Forms.TextBox passoword_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

