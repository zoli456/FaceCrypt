namespace FaceCrypt.Face
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.login_button = new System.Windows.Forms.Button();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kamera = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username_text = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.login_button.Location = new System.Drawing.Point(122, 403);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(110, 53);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "Bejelentkezés";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.button1_Click);
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
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Transparent;
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.Location = new System.Drawing.Point(280, 258);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(38, 38);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refresh.TabIndex = 8;
            this.refresh.TabStop = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kamera";
            // 
            // kamera
            // 
            this.kamera.FormattingEnabled = true;
            this.kamera.Location = new System.Drawing.Point(98, 267);
            this.kamera.Name = "kamera";
            this.kamera.Size = new System.Drawing.Size(170, 21);
            this.kamera.TabIndex = 6;
            this.kamera.SelectedIndexChanged += new System.EventHandler(this.kamera_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(260, 439);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Arcfelismerés";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Felhasználónév";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Jelszó";
            // 
            // username_text
            // 
            this.username_text.Location = new System.Drawing.Point(99, 304);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(249, 20);
            this.username_text.TabIndex = 12;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(99, 338);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(249, 20);
            this.password_textbox.TabIndex = 13;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(98, 364);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(118, 17);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "Jelszó megjelenítés";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Login
            // 
            this.AcceptButton = this.login_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 468);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kamera);
            this.Controls.Add(this.imageBoxFrameGrabber);
            this.Controls.Add(this.login_button);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arcfelismerő Bejelentkezés";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.PictureBox refresh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox kamera;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

