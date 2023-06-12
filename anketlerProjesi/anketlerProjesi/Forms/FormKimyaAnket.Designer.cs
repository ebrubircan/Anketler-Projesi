namespace anketlerProjesi.Forms
{
    partial class FormKimyaAnket
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
            this.pictureBoxKimya = new System.Windows.Forms.PictureBox();
            this.kimyaButton3 = new System.Windows.Forms.Button();
            this.kimyaButton2 = new System.Windows.Forms.Button();
            this.kimyaButton1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKimya)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.pictureBoxKimya);
            this.panel1.Controls.Add(this.kimyaButton3);
            this.panel1.Controls.Add(this.kimyaButton2);
            this.panel1.Controls.Add(this.kimyaButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1668, 912);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxKimya
            // 
            this.pictureBoxKimya.Location = new System.Drawing.Point(614, 439);
            this.pictureBoxKimya.Name = "pictureBoxKimya";
            this.pictureBoxKimya.Size = new System.Drawing.Size(449, 334);
            this.pictureBoxKimya.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKimya.TabIndex = 3;
            this.pictureBoxKimya.TabStop = false;
            // 
            // kimyaButton3
            // 
            this.kimyaButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.kimyaButton3.FlatAppearance.BorderSize = 7;
            this.kimyaButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kimyaButton3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kimyaButton3.Location = new System.Drawing.Point(0, 180);
            this.kimyaButton3.Name = "kimyaButton3";
            this.kimyaButton3.Size = new System.Drawing.Size(1668, 90);
            this.kimyaButton3.TabIndex = 2;
            this.kimyaButton3.Text = "MEMNUNİYET ANKETİ";
            this.kimyaButton3.UseVisualStyleBackColor = true;
            this.kimyaButton3.Click += new System.EventHandler(this.kimyaButton3_Click);
            // 
            // kimyaButton2
            // 
            this.kimyaButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kimyaButton2.FlatAppearance.BorderSize = 7;
            this.kimyaButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kimyaButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kimyaButton2.Location = new System.Drawing.Point(0, 90);
            this.kimyaButton2.Name = "kimyaButton2";
            this.kimyaButton2.Size = new System.Drawing.Size(1668, 90);
            this.kimyaButton2.TabIndex = 1;
            this.kimyaButton2.Text = "MEMNUNİYET ANKETİ";
            this.kimyaButton2.UseVisualStyleBackColor = true;
            this.kimyaButton2.Click += new System.EventHandler(this.kimyaButton2_Click);
            // 
            // kimyaButton1
            // 
            this.kimyaButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kimyaButton1.FlatAppearance.BorderSize = 7;
            this.kimyaButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kimyaButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kimyaButton1.Location = new System.Drawing.Point(0, 0);
            this.kimyaButton1.Name = "kimyaButton1";
            this.kimyaButton1.Size = new System.Drawing.Size(1668, 90);
            this.kimyaButton1.TabIndex = 0;
            this.kimyaButton1.Text = "MEMNUNİYET ANKETİ";
            this.kimyaButton1.UseVisualStyleBackColor = true;
            this.kimyaButton1.Click += new System.EventHandler(this.kimyaButton1_Click);
            // 
            // FormKimyaAnket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1668, 912);
            this.Controls.Add(this.panel1);
            this.Name = "FormKimyaAnket";
            this.Text = "KİMYA";
            this.Load += new System.EventHandler(this.FormKimyaAnket_Load_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKimya)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button kimyaButton3;
        private System.Windows.Forms.Button kimyaButton2;
        private System.Windows.Forms.Button kimyaButton1;
        private System.Windows.Forms.PictureBox pictureBoxKimya;
        private System.Windows.Forms.Timer timer1;
    }
}