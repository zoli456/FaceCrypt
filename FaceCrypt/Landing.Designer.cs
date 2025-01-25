namespace FaceCrypt
{
    partial class Landing
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
            this.components = new System.ComponentModel.Container();
            this.logout_label = new System.Windows.Forms.Label();
            this.logout_timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.műveletekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kijelentkezésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.műveletekToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fájltitkosítóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beállításokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.névjegyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logout_label
            // 
            this.logout_label.AutoSize = true;
            this.logout_label.BackColor = System.Drawing.Color.Transparent;
            this.logout_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logout_label.ForeColor = System.Drawing.Color.Red;
            this.logout_label.Location = new System.Drawing.Point(12, 332);
            this.logout_label.Name = "logout_label";
            this.logout_label.Size = new System.Drawing.Size(170, 20);
            this.logout_label.TabIndex = 0;
            this.logout_label.Text = "Kijelentkezés: 15:00";
            // 
            // logout_timer
            // 
            this.logout_timer.Enabled = true;
            this.logout_timer.Interval = 1000;
            this.logout_timer.Tick += new System.EventHandler(this.logout_timer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.műveletekToolStripMenuItem,
            this.műveletekToolStripMenuItem1,
            this.névjegyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(553, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // műveletekToolStripMenuItem
            // 
            this.műveletekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kijelentkezésToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.műveletekToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.műveletekToolStripMenuItem.Name = "műveletekToolStripMenuItem";
            this.műveletekToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.műveletekToolStripMenuItem.Text = "&Program";
            // 
            // kijelentkezésToolStripMenuItem
            // 
            this.kijelentkezésToolStripMenuItem.Name = "kijelentkezésToolStripMenuItem";
            this.kijelentkezésToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.kijelentkezésToolStripMenuItem.Text = "Kijelentkezé&s";
            this.kijelentkezésToolStripMenuItem.Click += new System.EventHandler(this.kijelentkezésToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.kilépésToolStripMenuItem.Text = "&Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // műveletekToolStripMenuItem1
            // 
            this.műveletekToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájltitkosítóToolStripMenuItem,
            this.beállításokToolStripMenuItem});
            this.műveletekToolStripMenuItem1.Name = "műveletekToolStripMenuItem1";
            this.műveletekToolStripMenuItem1.Size = new System.Drawing.Size(70, 20);
            this.műveletekToolStripMenuItem1.Text = "&Eszközök";
            // 
            // fájltitkosítóToolStripMenuItem
            // 
            this.fájltitkosítóToolStripMenuItem.Name = "fájltitkosítóToolStripMenuItem";
            this.fájltitkosítóToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.fájltitkosítóToolStripMenuItem.Text = "&Fájltitkosító";
            this.fájltitkosítóToolStripMenuItem.Click += new System.EventHandler(this.fájltitkosítóToolStripMenuItem_Click);
            // 
            // beállításokToolStripMenuItem
            // 
            this.beállításokToolStripMenuItem.Name = "beállításokToolStripMenuItem";
            this.beállításokToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.beállításokToolStripMenuItem.Text = "&Beállítások";
            this.beállításokToolStripMenuItem.Click += new System.EventHandler(this.beállításokToolStripMenuItem_Click);
            // 
            // névjegyToolStripMenuItem
            // 
            this.névjegyToolStripMenuItem.Name = "névjegyToolStripMenuItem";
            this.névjegyToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.névjegyToolStripMenuItem.Text = "&Névjegy";
            this.névjegyToolStripMenuItem.Click += new System.EventHandler(this.névjegyToolStripMenuItem_Click);
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FaceCrypt.Properties.Resources.danger_of_death__keep_out_by_facial_tic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(553, 361);
            this.Controls.Add(this.logout_label);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Landing";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Belépve, mint Valaki";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Landing_FormClosing);
            this.Load += new System.EventHandler(this.Landing_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logout_label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem műveletekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kijelentkezésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem műveletekToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fájltitkosítóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beállításokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem névjegyToolStripMenuItem;
        internal System.Windows.Forms.Timer logout_timer;
    }
}