namespace FaceCrypt.Storage
{
    partial class Encrypt
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
            this.filename_label = new System.Windows.Forms.Label();
            this.browse_button = new System.Windows.Forms.Button();
            this.encrypt_radiobutton = new System.Windows.Forms.RadioButton();
            this.decrypt_radiobutton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.go_button = new System.Windows.Forms.Button();
            this.destination_label = new System.Windows.Forms.Label();
            this.destination_button = new System.Windows.Forms.Button();
            this.operation_label = new System.Windows.Forms.Label();
            this.deleteafter = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // filename_label
            // 
            this.filename_label.AutoSize = true;
            this.filename_label.BackColor = System.Drawing.Color.Transparent;
            this.filename_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filename_label.ForeColor = System.Drawing.Color.Red;
            this.filename_label.Location = new System.Drawing.Point(12, 21);
            this.filename_label.Name = "filename_label";
            this.filename_label.Size = new System.Drawing.Size(53, 16);
            this.filename_label.TabIndex = 0;
            this.filename_label.Text = "Forrás";
            // 
            // browse_button
            // 
            this.browse_button.ForeColor = System.Drawing.Color.Maroon;
            this.browse_button.Location = new System.Drawing.Point(15, 52);
            this.browse_button.Name = "browse_button";
            this.browse_button.Size = new System.Drawing.Size(80, 28);
            this.browse_button.TabIndex = 1;
            this.browse_button.Text = "Tallózás";
            this.browse_button.UseVisualStyleBackColor = true;
            this.browse_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // encrypt_radiobutton
            // 
            this.encrypt_radiobutton.AutoSize = true;
            this.encrypt_radiobutton.BackColor = System.Drawing.Color.Transparent;
            this.encrypt_radiobutton.Checked = true;
            this.encrypt_radiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.encrypt_radiobutton.ForeColor = System.Drawing.Color.Red;
            this.encrypt_radiobutton.Location = new System.Drawing.Point(23, 190);
            this.encrypt_radiobutton.Name = "encrypt_radiobutton";
            this.encrypt_radiobutton.Size = new System.Drawing.Size(94, 20);
            this.encrypt_radiobutton.TabIndex = 2;
            this.encrypt_radiobutton.TabStop = true;
            this.encrypt_radiobutton.Text = "Titkosítás";
            this.encrypt_radiobutton.UseVisualStyleBackColor = false;
            this.encrypt_radiobutton.CheckedChanged += new System.EventHandler(this.encrypt_radiobutton_CheckedChanged);
            // 
            // decrypt_radiobutton
            // 
            this.decrypt_radiobutton.AutoSize = true;
            this.decrypt_radiobutton.BackColor = System.Drawing.Color.Transparent;
            this.decrypt_radiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.decrypt_radiobutton.ForeColor = System.Drawing.Color.Red;
            this.decrypt_radiobutton.Location = new System.Drawing.Point(23, 213);
            this.decrypt_radiobutton.Name = "decrypt_radiobutton";
            this.decrypt_radiobutton.Size = new System.Drawing.Size(128, 20);
            this.decrypt_radiobutton.TabIndex = 3;
            this.decrypt_radiobutton.Text = "Visszakódolás";
            this.decrypt_radiobutton.UseVisualStyleBackColor = false;
            this.decrypt_radiobutton.CheckedChanged += new System.EventHandler(this.decrypt_radiobutton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(23, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Egyedi jelszó(nem kötelező):";
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(237, 264);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(369, 20);
            this.password_textbox.TabIndex = 5;
            // 
            // go_button
            // 
            this.go_button.ForeColor = System.Drawing.Color.Maroon;
            this.go_button.Location = new System.Drawing.Point(258, 303);
            this.go_button.Name = "go_button";
            this.go_button.Size = new System.Drawing.Size(86, 36);
            this.go_button.TabIndex = 6;
            this.go_button.Text = "Mehet";
            this.go_button.UseVisualStyleBackColor = true;
            this.go_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // destination_label
            // 
            this.destination_label.AutoSize = true;
            this.destination_label.BackColor = System.Drawing.Color.Transparent;
            this.destination_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.destination_label.ForeColor = System.Drawing.Color.Red;
            this.destination_label.Location = new System.Drawing.Point(12, 93);
            this.destination_label.Name = "destination_label";
            this.destination_label.Size = new System.Drawing.Size(31, 16);
            this.destination_label.TabIndex = 7;
            this.destination_label.Text = "Cél";
            // 
            // destination_button
            // 
            this.destination_button.ForeColor = System.Drawing.Color.Maroon;
            this.destination_button.Location = new System.Drawing.Point(15, 122);
            this.destination_button.Name = "destination_button";
            this.destination_button.Size = new System.Drawing.Size(80, 28);
            this.destination_button.TabIndex = 8;
            this.destination_button.Text = "Tallózás";
            this.destination_button.UseVisualStyleBackColor = true;
            this.destination_button.Click += new System.EventHandler(this.destination_button_Click);
            // 
            // operation_label
            // 
            this.operation_label.AutoSize = true;
            this.operation_label.BackColor = System.Drawing.Color.Transparent;
            this.operation_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.operation_label.ForeColor = System.Drawing.Color.Red;
            this.operation_label.Location = new System.Drawing.Point(12, 165);
            this.operation_label.Name = "operation_label";
            this.operation_label.Size = new System.Drawing.Size(66, 16);
            this.operation_label.TabIndex = 9;
            this.operation_label.Text = "Művelet:";
            // 
            // deleteafter
            // 
            this.deleteafter.AutoSize = true;
            this.deleteafter.BackColor = System.Drawing.Color.Transparent;
            this.deleteafter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteafter.ForeColor = System.Drawing.Color.Red;
            this.deleteafter.Location = new System.Drawing.Point(27, 303);
            this.deleteafter.Name = "deleteafter";
            this.deleteafter.Size = new System.Drawing.Size(124, 20);
            this.deleteafter.TabIndex = 10;
            this.deleteafter.Text = "Forrás törlése";
            this.deleteafter.UseVisualStyleBackColor = false;
            // 
            // Encrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FaceCrypt.Properties.Resources.encrypt_primary_100022114_gallery_100024895_orig;
            this.ClientSize = new System.Drawing.Size(618, 351);
            this.Controls.Add(this.deleteafter);
            this.Controls.Add(this.operation_label);
            this.Controls.Add(this.destination_button);
            this.Controls.Add(this.destination_label);
            this.Controls.Add(this.go_button);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.decrypt_radiobutton);
            this.Controls.Add(this.encrypt_radiobutton);
            this.Controls.Add(this.browse_button);
            this.Controls.Add(this.filename_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Encrypt";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fájltitkosító";
            this.Load += new System.EventHandler(this.Encrypt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label filename_label;
        private System.Windows.Forms.Button browse_button;
        private System.Windows.Forms.RadioButton encrypt_radiobutton;
        private System.Windows.Forms.RadioButton decrypt_radiobutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_textbox;
        internal System.Windows.Forms.Button go_button;
        private System.Windows.Forms.Label destination_label;
        private System.Windows.Forms.Button destination_button;
        private System.Windows.Forms.Label operation_label;
        private System.Windows.Forms.CheckBox deleteafter;
    }
}