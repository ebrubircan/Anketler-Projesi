namespace anketlerProjesi.Forms
{
    partial class FormFizikAnket
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
            this.pictureBoxFizik = new System.Windows.Forms.PictureBox();
            this.fizikButton3 = new System.Windows.Forms.Button();
            this.fizikButton2 = new System.Windows.Forms.Button();
            this.fizikButton1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFizik)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.pictureBoxFizik);
            this.panel1.Controls.Add(this.fizikButton3);
            this.panel1.Controls.Add(this.fizikButton2);
            this.panel1.Controls.Add(this.fizikButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1668, 912);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxFizik
            // 
            this.pictureBoxFizik.Location = new System.Drawing.Point(614, 439);
            this.pictureBoxFizik.Name = "pictureBoxFizik";
            this.pictureBoxFizik.Size = new System.Drawing.Size(449, 334);
            this.pictureBoxFizik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFizik.TabIndex = 3;
            this.pictureBoxFizik.TabStop = false;
            // 
            // fizikButton3
            // 
            this.fizikButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.fizikButton3.FlatAppearance.BorderSize = 7;
            this.fizikButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fizikButton3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fizikButton3.Location = new System.Drawing.Point(0, 180);
            this.fizikButton3.Name = "fizikButton3";
            this.fizikButton3.Size = new System.Drawing.Size(1668, 90);
            this.fizikButton3.TabIndex = 2;
            this.fizikButton3.Text = "MEMNUNİYET ANKETİ";
            this.fizikButton3.UseVisualStyleBackColor = true;
            this.fizikButton3.Click += new System.EventHandler(this.fizikButton3_Click);
            // 
            // fizikButton2
            // 
            this.fizikButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.fizikButton2.FlatAppearance.BorderSize = 7;
            this.fizikButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fizikButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fizikButton2.Location = new System.Drawing.Point(0, 90);
            this.fizikButton2.Name = "fizikButton2";
            this.fizikButton2.Size = new System.Drawing.Size(1668, 90);
            this.fizikButton2.TabIndex = 1;
            this.fizikButton2.Text = "MEMNUNİYET ANKETİ";
            this.fizikButton2.UseVisualStyleBackColor = true;
            this.fizikButton2.Click += new System.EventHandler(this.fizikButton2_Click);
            // 
            // fizikButton1
            // 
            this.fizikButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fizikButton1.FlatAppearance.BorderSize = 7;
            this.fizikButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fizikButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fizikButton1.Location = new System.Drawing.Point(0, 0);
            this.fizikButton1.Name = "fizikButton1";
            this.fizikButton1.Size = new System.Drawing.Size(1668, 90);
            this.fizikButton1.TabIndex = 0;
            this.fizikButton1.Text = "MEMNUNİYET ANKETİ";
            this.fizikButton1.UseVisualStyleBackColor = true;
            this.fizikButton1.Click += new System.EventHandler(this.fizikButton1_Click);
            // 
            // FormFizikAnket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1668, 912);
            this.Controls.Add(this.panel1);
            this.Name = "FormFizikAnket";
            this.Text = "FİZİK";
            this.Load += new System.EventHandler(this.FormFizikAnket_Load_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFizik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button fizikButton3;
        private System.Windows.Forms.Button fizikButton2;
        private System.Windows.Forms.Button fizikButton1;
        private System.Windows.Forms.PictureBox pictureBoxFizik;
        private System.Windows.Forms.Timer timer1;
    }
}