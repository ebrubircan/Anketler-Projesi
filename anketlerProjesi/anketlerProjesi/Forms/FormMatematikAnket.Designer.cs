namespace anketlerProjesi.Forms
{
    partial class FormMatematikAnket
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
            this.pictureBoxMatematik = new System.Windows.Forms.PictureBox();
            this.matematikButton3 = new System.Windows.Forms.Button();
            this.matematikButton2 = new System.Windows.Forms.Button();
            this.matematikButton1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatematik)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.pictureBoxMatematik);
            this.panel1.Controls.Add(this.matematikButton3);
            this.panel1.Controls.Add(this.matematikButton2);
            this.panel1.Controls.Add(this.matematikButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1668, 912);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxMatematik
            // 
            this.pictureBoxMatematik.Location = new System.Drawing.Point(614, 439);
            this.pictureBoxMatematik.Name = "pictureBoxMatematik";
            this.pictureBoxMatematik.Size = new System.Drawing.Size(449, 334);
            this.pictureBoxMatematik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMatematik.TabIndex = 3;
            this.pictureBoxMatematik.TabStop = false;
            // 
            // matematikButton3
            // 
            this.matematikButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.matematikButton3.FlatAppearance.BorderSize = 7;
            this.matematikButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.matematikButton3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.matematikButton3.Location = new System.Drawing.Point(0, 180);
            this.matematikButton3.Name = "matematikButton3";
            this.matematikButton3.Size = new System.Drawing.Size(1668, 90);
            this.matematikButton3.TabIndex = 2;
            this.matematikButton3.Text = "MEMNUNİYET ANKETİ";
            this.matematikButton3.UseVisualStyleBackColor = true;
            this.matematikButton3.Click += new System.EventHandler(this.matematikButton3_Click);
            // 
            // matematikButton2
            // 
            this.matematikButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.matematikButton2.FlatAppearance.BorderSize = 7;
            this.matematikButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.matematikButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.matematikButton2.Location = new System.Drawing.Point(0, 90);
            this.matematikButton2.Name = "matematikButton2";
            this.matematikButton2.Size = new System.Drawing.Size(1668, 90);
            this.matematikButton2.TabIndex = 1;
            this.matematikButton2.Text = "MEMNUNİYET ANKETİ";
            this.matematikButton2.UseVisualStyleBackColor = true;
            this.matematikButton2.Click += new System.EventHandler(this.matematikButton2_Click);
            // 
            // matematikButton1
            // 
            this.matematikButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.matematikButton1.FlatAppearance.BorderSize = 7;
            this.matematikButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.matematikButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.matematikButton1.Location = new System.Drawing.Point(0, 0);
            this.matematikButton1.Name = "matematikButton1";
            this.matematikButton1.Size = new System.Drawing.Size(1668, 90);
            this.matematikButton1.TabIndex = 0;
            this.matematikButton1.Text = "MEMNUNİYET ANKETİ";
            this.matematikButton1.UseVisualStyleBackColor = true;
            this.matematikButton1.Click += new System.EventHandler(this.matematikButton1_Click);
            // 
            // FormMatematikAnket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1668, 912);
            this.Controls.Add(this.panel1);
            this.Name = "FormMatematikAnket";
            this.Text = "MATEMATİK";
            this.Load += new System.EventHandler(this.FormMatematikAnket_Load_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatematik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button matematikButton3;
        private System.Windows.Forms.Button matematikButton2;
        private System.Windows.Forms.Button matematikButton1;
        private System.Windows.Forms.PictureBox pictureBoxMatematik;
        private System.Windows.Forms.Timer timer1;
    }
}