namespace anketlerProjesi.Forms
{
    partial class FormCscAnket
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
            this.pictureBoxCsc = new System.Windows.Forms.PictureBox();
            this.cscButton3 = new System.Windows.Forms.Button();
            this.cscButton2 = new System.Windows.Forms.Button();
            this.cscButton1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCsc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.pictureBoxCsc);
            this.panel1.Controls.Add(this.cscButton3);
            this.panel1.Controls.Add(this.cscButton2);
            this.panel1.Controls.Add(this.cscButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1668, 912);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxCsc
            // 
            this.pictureBoxCsc.Location = new System.Drawing.Point(614, 439);
            this.pictureBoxCsc.Name = "pictureBoxCsc";
            this.pictureBoxCsc.Size = new System.Drawing.Size(449, 334);
            this.pictureBoxCsc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCsc.TabIndex = 3;
            this.pictureBoxCsc.TabStop = false;
            // 
            // cscButton3
            // 
            this.cscButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.cscButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cscButton3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cscButton3.Location = new System.Drawing.Point(0, 180);
            this.cscButton3.Name = "cscButton3";
            this.cscButton3.Size = new System.Drawing.Size(1668, 90);
            this.cscButton3.TabIndex = 2;
            this.cscButton3.Text = "MEMNUNİYET ANKETİ";
            this.cscButton3.UseVisualStyleBackColor = true;
            this.cscButton3.Click += new System.EventHandler(this.cscButton3_Click);
            // 
            // cscButton2
            // 
            this.cscButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.cscButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cscButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cscButton2.Location = new System.Drawing.Point(0, 90);
            this.cscButton2.Name = "cscButton2";
            this.cscButton2.Size = new System.Drawing.Size(1668, 90);
            this.cscButton2.TabIndex = 1;
            this.cscButton2.Text = "MEMNUNİYET ANKETİ";
            this.cscButton2.UseVisualStyleBackColor = true;
            this.cscButton2.Click += new System.EventHandler(this.cscButton2_Click);
            // 
            // cscButton1
            // 
            this.cscButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cscButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cscButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cscButton1.Location = new System.Drawing.Point(0, 0);
            this.cscButton1.Name = "cscButton1";
            this.cscButton1.Size = new System.Drawing.Size(1668, 90);
            this.cscButton1.TabIndex = 0;
            this.cscButton1.Text = "MEMNUNİYET ANKETİ";
            this.cscButton1.UseVisualStyleBackColor = true;
            this.cscButton1.Click += new System.EventHandler(this.cscButton1_Click);
            // 
            // FormCscAnket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1668, 912);
            this.Controls.Add(this.panel1);
            this.Name = "FormCscAnket";
            this.Text = "BİLGİSAYAR BİLİMLERİ";
            this.Load += new System.EventHandler(this.FormCscAnket_Load_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCsc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cscButton3;
        private System.Windows.Forms.Button cscButton2;
        private System.Windows.Forms.Button cscButton1;
        private System.Windows.Forms.PictureBox pictureBoxCsc;
        private System.Windows.Forms.Timer timer1;
    }
}