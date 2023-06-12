namespace anketlerProjesi.Forms
{
    partial class FormBiyolojiAnket
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
            this.pictureBoxBiyoloji = new System.Windows.Forms.PictureBox();
            this.biyolojiButton3 = new System.Windows.Forms.Button();
            this.biyolojiButton2 = new System.Windows.Forms.Button();
            this.biyolojiButton1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBiyoloji)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.pictureBoxBiyoloji);
            this.panel1.Controls.Add(this.biyolojiButton3);
            this.panel1.Controls.Add(this.biyolojiButton2);
            this.panel1.Controls.Add(this.biyolojiButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1668, 912);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxBiyoloji
            // 
            this.pictureBoxBiyoloji.Location = new System.Drawing.Point(614, 439);
            this.pictureBoxBiyoloji.Name = "pictureBoxBiyoloji";
            this.pictureBoxBiyoloji.Size = new System.Drawing.Size(449, 334);
            this.pictureBoxBiyoloji.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBiyoloji.TabIndex = 3;
            this.pictureBoxBiyoloji.TabStop = false;
            // 
            // biyolojiButton3
            // 
            this.biyolojiButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.biyolojiButton3.FlatAppearance.BorderSize = 7;
            this.biyolojiButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.biyolojiButton3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.biyolojiButton3.Location = new System.Drawing.Point(0, 180);
            this.biyolojiButton3.Name = "biyolojiButton3";
            this.biyolojiButton3.Size = new System.Drawing.Size(1668, 90);
            this.biyolojiButton3.TabIndex = 2;
            this.biyolojiButton3.Text = "MEMNUNİYET ANKETİ";
            this.biyolojiButton3.UseVisualStyleBackColor = true;
            this.biyolojiButton3.Click += new System.EventHandler(this.biyolojiButton3_Click);
            // 
            // biyolojiButton2
            // 
            this.biyolojiButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.biyolojiButton2.FlatAppearance.BorderSize = 7;
            this.biyolojiButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.biyolojiButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.biyolojiButton2.Location = new System.Drawing.Point(0, 90);
            this.biyolojiButton2.Name = "biyolojiButton2";
            this.biyolojiButton2.Size = new System.Drawing.Size(1668, 90);
            this.biyolojiButton2.TabIndex = 1;
            this.biyolojiButton2.Text = "MEMNUNİYET ANKETİ";
            this.biyolojiButton2.UseVisualStyleBackColor = true;
            this.biyolojiButton2.Click += new System.EventHandler(this.biyolojiButton2_Click);
            // 
            // biyolojiButton1
            // 
            this.biyolojiButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.biyolojiButton1.FlatAppearance.BorderSize = 7;
            this.biyolojiButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.biyolojiButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.biyolojiButton1.Location = new System.Drawing.Point(0, 0);
            this.biyolojiButton1.Name = "biyolojiButton1";
            this.biyolojiButton1.Size = new System.Drawing.Size(1668, 90);
            this.biyolojiButton1.TabIndex = 0;
            this.biyolojiButton1.Text = "MEMNUNİYET ANKETİ";
            this.biyolojiButton1.UseVisualStyleBackColor = true;
            this.biyolojiButton1.Click += new System.EventHandler(this.biyolojiButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            // 
            // FormBiyolojiAnket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1668, 912);
            this.Controls.Add(this.panel1);
            this.Name = "FormBiyolojiAnket";
            this.Text = "BİYOLOJİ";
            this.Load += new System.EventHandler(this.FormBiyolojiAnket_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBiyoloji)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button biyolojiButton3;
        private System.Windows.Forms.Button biyolojiButton2;
        private System.Windows.Forms.Button biyolojiButton1;
        private System.Windows.Forms.PictureBox pictureBoxBiyoloji;
        private System.Windows.Forms.Timer timer1;
    }
}