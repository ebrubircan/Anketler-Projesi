namespace anketlerProjesi.Forms
{
    partial class FormGenelAnket
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
            this.pictureBoxGenelAnket = new System.Windows.Forms.PictureBox();
            this.genelAnketButton3 = new System.Windows.Forms.Button();
            this.genelAnketButton2 = new System.Windows.Forms.Button();
            this.genelAnketButton1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGenelAnket)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.pictureBoxGenelAnket);
            this.panel1.Controls.Add(this.genelAnketButton3);
            this.panel1.Controls.Add(this.genelAnketButton2);
            this.panel1.Controls.Add(this.genelAnketButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1668, 912);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxGenelAnket
            // 
            this.pictureBoxGenelAnket.Location = new System.Drawing.Point(614, 439);
            this.pictureBoxGenelAnket.Name = "pictureBoxGenelAnket";
            this.pictureBoxGenelAnket.Size = new System.Drawing.Size(449, 334);
            this.pictureBoxGenelAnket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGenelAnket.TabIndex = 3;
            this.pictureBoxGenelAnket.TabStop = false;
            // 
            // genelAnketButton3
            // 
            this.genelAnketButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.genelAnketButton3.FlatAppearance.BorderSize = 7;
            this.genelAnketButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.genelAnketButton3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.genelAnketButton3.Location = new System.Drawing.Point(0, 180);
            this.genelAnketButton3.Name = "genelAnketButton3";
            this.genelAnketButton3.Size = new System.Drawing.Size(1668, 90);
            this.genelAnketButton3.TabIndex = 2;
            this.genelAnketButton3.Text = "MEMNUNİYET ANKETİ";
            this.genelAnketButton3.UseVisualStyleBackColor = true;
            this.genelAnketButton3.Click += new System.EventHandler(this.genelAnketButton3_Click);
            // 
            // genelAnketButton2
            // 
            this.genelAnketButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.genelAnketButton2.FlatAppearance.BorderSize = 7;
            this.genelAnketButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.genelAnketButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.genelAnketButton2.Location = new System.Drawing.Point(0, 90);
            this.genelAnketButton2.Name = "genelAnketButton2";
            this.genelAnketButton2.Size = new System.Drawing.Size(1668, 90);
            this.genelAnketButton2.TabIndex = 1;
            this.genelAnketButton2.Text = "MEMNUNİYET ANKETİ";
            this.genelAnketButton2.UseVisualStyleBackColor = true;
            this.genelAnketButton2.Click += new System.EventHandler(this.genelAnketButton2_Click);
            // 
            // genelAnketButton1
            // 
            this.genelAnketButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.genelAnketButton1.FlatAppearance.BorderSize = 7;
            this.genelAnketButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.genelAnketButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.genelAnketButton1.Location = new System.Drawing.Point(0, 0);
            this.genelAnketButton1.Name = "genelAnketButton1";
            this.genelAnketButton1.Size = new System.Drawing.Size(1668, 90);
            this.genelAnketButton1.TabIndex = 0;
            this.genelAnketButton1.Text = "MEMNUNİYET ANKETİ";
            this.genelAnketButton1.UseVisualStyleBackColor = true;
            this.genelAnketButton1.Click += new System.EventHandler(this.genelAnketButton1_Click);
            // 
            // FormGenelAnket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1668, 912);
            this.Controls.Add(this.panel1);
            this.Name = "FormGenelAnket";
            this.Text = "GENEL ANKETLER";
            this.Load += new System.EventHandler(this.FormGenelAnket_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGenelAnket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button genelAnketButton3;
        private System.Windows.Forms.Button genelAnketButton2;
        private System.Windows.Forms.Button genelAnketButton1;
        private System.Windows.Forms.PictureBox pictureBoxGenelAnket;
        private System.Windows.Forms.Timer timer1;
    }
}