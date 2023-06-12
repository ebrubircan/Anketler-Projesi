namespace anketlerProjesi.Forms
{
    partial class FormIstatistikAnket
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxIstatistik = new System.Windows.Forms.PictureBox();
            this.istatistiButton3 = new System.Windows.Forms.Button();
            this.istatistiButton2 = new System.Windows.Forms.Button();
            this.istatistiButton1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIstatistik)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.pictureBoxIstatistik);
            this.panel1.Controls.Add(this.istatistiButton3);
            this.panel1.Controls.Add(this.istatistiButton2);
            this.panel1.Controls.Add(this.istatistiButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1668, 912);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxIstatistik
            // 
            this.pictureBoxIstatistik.Location = new System.Drawing.Point(614, 439);
            this.pictureBoxIstatistik.Name = "pictureBoxIstatistik";
            this.pictureBoxIstatistik.Size = new System.Drawing.Size(449, 334);
            this.pictureBoxIstatistik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIstatistik.TabIndex = 3;
            this.pictureBoxIstatistik.TabStop = false;
            // 
            // istatistiButton3
            // 
            this.istatistiButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.istatistiButton3.FlatAppearance.BorderSize = 7;
            this.istatistiButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.istatistiButton3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.istatistiButton3.Location = new System.Drawing.Point(0, 180);
            this.istatistiButton3.Name = "istatistiButton3";
            this.istatistiButton3.Size = new System.Drawing.Size(1668, 90);
            this.istatistiButton3.TabIndex = 2;
            this.istatistiButton3.Text = "MEMNUNİYET ANKETİ";
            this.istatistiButton3.UseVisualStyleBackColor = true;
            this.istatistiButton3.Click += new System.EventHandler(this.istatistiButton3_Click);
            // 
            // istatistiButton2
            // 
            this.istatistiButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.istatistiButton2.FlatAppearance.BorderSize = 7;
            this.istatistiButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.istatistiButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.istatistiButton2.Location = new System.Drawing.Point(0, 90);
            this.istatistiButton2.Name = "istatistiButton2";
            this.istatistiButton2.Size = new System.Drawing.Size(1668, 90);
            this.istatistiButton2.TabIndex = 1;
            this.istatistiButton2.Text = "MEMNUNİYET ANKETİ";
            this.istatistiButton2.UseVisualStyleBackColor = true;
            this.istatistiButton2.Click += new System.EventHandler(this.istatistiButton2_Click);
            // 
            // istatistiButton1
            // 
            this.istatistiButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.istatistiButton1.FlatAppearance.BorderSize = 7;
            this.istatistiButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.istatistiButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.istatistiButton1.Location = new System.Drawing.Point(0, 0);
            this.istatistiButton1.Name = "istatistiButton1";
            this.istatistiButton1.Size = new System.Drawing.Size(1668, 90);
            this.istatistiButton1.TabIndex = 0;
            this.istatistiButton1.Text = "MEMNUNİYET ANKETİ";
            this.istatistiButton1.UseVisualStyleBackColor = true;
            this.istatistiButton1.Click += new System.EventHandler(this.istatistiButton1_Click);
            // 
            // FormIstatistikAnket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1668, 912);
            this.Controls.Add(this.panel1);
            this.Name = "FormIstatistikAnket";
            this.Text = "İSTATİSTİK";
            this.Load += new System.EventHandler(this.FormIstatistikAnket_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIstatistik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button istatistiButton3;
        private System.Windows.Forms.Button istatistiButton2;
        private System.Windows.Forms.Button istatistiButton1;
        private System.Windows.Forms.PictureBox pictureBoxIstatistik;
        private System.Windows.Forms.Timer timer1;
    }
}