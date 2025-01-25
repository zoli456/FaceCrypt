namespace FaceCrypt
{
    partial class Welcome
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
            this.login_button = new System.Windows.Forms.Button();
            this.register_buttton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_button.Location = new System.Drawing.Point(173, 122);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(132, 43);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "Bejelentkezés";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // register_buttton
            // 
            this.register_buttton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.register_buttton.Location = new System.Drawing.Point(173, 214);
            this.register_buttton.Name = "register_buttton";
            this.register_buttton.Size = new System.Drawing.Size(132, 41);
            this.register_buttton.TabIndex = 1;
            this.register_buttton.Text = "Regisztráció";
            this.register_buttton.UseVisualStyleBackColor = true;
            this.register_buttton.Click += new System.EventHandler(this.register_buttton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(101, 307);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 90);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Ha még nem regisztráltál egyetlen profilt sem a programban kattints a \'Regisztrác" +
    "ió\' gombra. Ha már regisztráltál katints a \'Bejelentkezés\' gombra.";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FaceCrypt.Properties.Resources.cas_padlock_icon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(481, 418);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.register_buttton);
            this.Controls.Add(this.login_button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Welcome";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kezdőképernyő";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button register_buttton;
        private System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Button login_button;
    }
}