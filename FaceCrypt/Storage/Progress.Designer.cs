namespace FaceCrypt.Storage
{
    partial class Progress
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
            this.Bar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bar
            // 
            this.Bar.Location = new System.Drawing.Point(12, 137);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(380, 23);
            this.Bar.TabIndex = 0;
            this.Bar.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(123, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kérem várjon...";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.BackColor = System.Drawing.Color.Transparent;
            this.time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.time_label.ForeColor = System.Drawing.Color.Red;
            this.time_label.Location = new System.Drawing.Point(12, 171);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(87, 13);
            this.time_label.TabIndex = 2;
            this.time_label.Text = "Hátralévő idő:";
            // 
            // Progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FaceCrypt.Properties.Resources.encrypted_data;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(404, 204);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Progress";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folyamat";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ProgressBar Bar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.Label time_label;
    }
}