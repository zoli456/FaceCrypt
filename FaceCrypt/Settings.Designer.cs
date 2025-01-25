namespace FaceCrypt
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.timer_textbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logoutvoice_checkbox = new System.Windows.Forms.CheckBox();
            this.autologout_checkbox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hibernatevoice_checkbox = new System.Windows.Forms.CheckBox();
            this.restartvoice_checkbox = new System.Windows.Forms.CheckBox();
            this.shutdownvoice_checkbox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kijelentkezés (hh:mm:ss):";
            // 
            // timer_textbox
            // 
            this.timer_textbox.Location = new System.Drawing.Point(137, 25);
            this.timer_textbox.Name = "timer_textbox";
            this.timer_textbox.Size = new System.Drawing.Size(147, 20);
            this.timer_textbox.TabIndex = 1;
            this.timer_textbox.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.logoutvoice_checkbox);
            this.groupBox1.Controls.Add(this.autologout_checkbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.timer_textbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 105);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inaktivitás";
            // 
            // logoutvoice_checkbox
            // 
            this.logoutvoice_checkbox.AutoSize = true;
            this.logoutvoice_checkbox.Location = new System.Drawing.Point(9, 74);
            this.logoutvoice_checkbox.Name = "logoutvoice_checkbox";
            this.logoutvoice_checkbox.Size = new System.Drawing.Size(132, 17);
            this.logoutvoice_checkbox.TabIndex = 3;
            this.logoutvoice_checkbox.Text = "Hangutsítással(logout)";
            this.logoutvoice_checkbox.UseVisualStyleBackColor = true;
            this.logoutvoice_checkbox.CheckedChanged += new System.EventHandler(this.logoutvoice_checkbox_CheckedChanged);
            // 
            // autologout_checkbox
            // 
            this.autologout_checkbox.AutoSize = true;
            this.autologout_checkbox.Location = new System.Drawing.Point(9, 51);
            this.autologout_checkbox.Name = "autologout_checkbox";
            this.autologout_checkbox.Size = new System.Drawing.Size(148, 17);
            this.autologout_checkbox.TabIndex = 2;
            this.autologout_checkbox.Text = "Automatikus kijelentkezés";
            this.autologout_checkbox.UseVisualStyleBackColor = true;
            this.autologout_checkbox.CheckedChanged += new System.EventHandler(this.autologout_checkbox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hibernatevoice_checkbox);
            this.groupBox2.Controls.Add(this.restartvoice_checkbox);
            this.groupBox2.Controls.Add(this.shutdownvoice_checkbox);
            this.groupBox2.Location = new System.Drawing.Point(12, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rendszer";
            // 
            // hibernatevoice_checkbox
            // 
            this.hibernatevoice_checkbox.AutoSize = true;
            this.hibernatevoice_checkbox.Location = new System.Drawing.Point(9, 65);
            this.hibernatevoice_checkbox.Name = "hibernatevoice_checkbox";
            this.hibernatevoice_checkbox.Size = new System.Drawing.Size(162, 17);
            this.hibernatevoice_checkbox.TabIndex = 5;
            this.hibernatevoice_checkbox.Text = "Hibernálás hangra(hibernate)";
            this.hibernatevoice_checkbox.UseVisualStyleBackColor = true;
            this.hibernatevoice_checkbox.CheckedChanged += new System.EventHandler(this.hybernatevoice_checkbox_CheckedChanged);
            // 
            // restartvoice_checkbox
            // 
            this.restartvoice_checkbox.AutoSize = true;
            this.restartvoice_checkbox.Location = new System.Drawing.Point(9, 42);
            this.restartvoice_checkbox.Name = "restartvoice_checkbox";
            this.restartvoice_checkbox.Size = new System.Drawing.Size(148, 17);
            this.restartvoice_checkbox.TabIndex = 4;
            this.restartvoice_checkbox.Text = "Újraindítás hangra(restart)";
            this.restartvoice_checkbox.UseVisualStyleBackColor = true;
            this.restartvoice_checkbox.CheckedChanged += new System.EventHandler(this.restartvoice_checkbox_CheckedChanged);
            // 
            // shutdownvoice_checkbox
            // 
            this.shutdownvoice_checkbox.AutoSize = true;
            this.shutdownvoice_checkbox.Location = new System.Drawing.Point(9, 19);
            this.shutdownvoice_checkbox.Name = "shutdownvoice_checkbox";
            this.shutdownvoice_checkbox.Size = new System.Drawing.Size(154, 17);
            this.shutdownvoice_checkbox.TabIndex = 3;
            this.shutdownvoice_checkbox.Text = "Leállítás hangra(shutdown)";
            this.shutdownvoice_checkbox.UseVisualStyleBackColor = true;
            this.shutdownvoice_checkbox.CheckedChanged += new System.EventHandler(this.shutdownvoice_checkbox_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 243);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beállítások";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox timer_textbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox logoutvoice_checkbox;
        private System.Windows.Forms.CheckBox autologout_checkbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox restartvoice_checkbox;
        private System.Windows.Forms.CheckBox shutdownvoice_checkbox;
        private System.Windows.Forms.CheckBox hibernatevoice_checkbox;
    }
}