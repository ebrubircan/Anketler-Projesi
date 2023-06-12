namespace anketlerProjesi
{
    partial class FormAnaMenu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnaMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelIsim = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.buttonCloseChildForm = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxFenFakultesi = new System.Windows.Forms.PictureBox();
            this.buttonAnaSayfa = new System.Windows.Forms.Button();
            this.matButon = new System.Windows.Forms.Button();
            this.kimyaButon = new System.Windows.Forms.Button();
            this.istatistikButon = new System.Windows.Forms.Button();
            this.fizikButon = new System.Windows.Forms.Button();
            this.biyoButon = new System.Windows.Forms.Button();
            this.cscButon = new System.Windows.Forms.Button();
            this.genelAnketButton = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelIsim.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFenFakultesi)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.buttonAnaSayfa);
            this.panelMenu.Controls.Add(this.matButon);
            this.panelMenu.Controls.Add(this.kimyaButon);
            this.panelMenu.Controls.Add(this.istatistikButon);
            this.panelMenu.Controls.Add(this.fizikButon);
            this.panelMenu.Controls.Add(this.biyoButon);
            this.panelMenu.Controls.Add(this.cscButon);
            this.panelMenu.Controls.Add(this.genelAnketButton);
            this.panelMenu.Controls.Add(this.panelIsim);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 1041);
            this.panelMenu.TabIndex = 0;
            // 
            // panelIsim
            // 
            this.panelIsim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelIsim.Controls.Add(this.label1);
            this.panelIsim.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIsim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelIsim.Location = new System.Drawing.Point(0, 0);
            this.panelIsim.Name = "panelIsim";
            this.panelIsim.Size = new System.Drawing.Size(220, 90);
            this.panelIsim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "FEN FAKÜLTESİ";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Lavender;
            this.panelTitleBar.Controls.Add(this.buttonCloseChildForm);
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1684, 90);
            this.panelTitleBar.TabIndex = 1;
            // 
            // buttonCloseChildForm
            // 
            this.buttonCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonCloseChildForm.FlatAppearance.BorderSize = 0;
            this.buttonCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseChildForm.Image = global::anketlerProjesi.Properties.Resources.carpi;
            this.buttonCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.buttonCloseChildForm.Name = "buttonCloseChildForm";
            this.buttonCloseChildForm.Size = new System.Drawing.Size(70, 90);
            this.buttonCloseChildForm.TabIndex = 1;
            this.buttonCloseChildForm.UseVisualStyleBackColor = true;
            this.buttonCloseChildForm.Click += new System.EventHandler(this.buttonCloseChildForm_Click_1);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(732, 27);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(167, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "ANKETLER";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.panel1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 90);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1684, 951);
            this.panelDesktop.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBoxFenFakultesi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1684, 951);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(362, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(935, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "HOŞGELDİNİZ, LÜTFEN GÖRÜNTÜLEMEK İSTEDİĞİNİZ ANKETİ SEÇİNİZ.";
            // 
            // pictureBoxFenFakultesi
            // 
            this.pictureBoxFenFakultesi.Image = global::anketlerProjesi.Properties.Resources.logo;
            this.pictureBoxFenFakultesi.Location = new System.Drawing.Point(515, 160);
            this.pictureBoxFenFakultesi.Name = "pictureBoxFenFakultesi";
            this.pictureBoxFenFakultesi.Size = new System.Drawing.Size(600, 600);
            this.pictureBoxFenFakultesi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFenFakultesi.TabIndex = 0;
            this.pictureBoxFenFakultesi.TabStop = false;
            // 
            // buttonAnaSayfa
            // 
            this.buttonAnaSayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnaSayfa.Image = ((System.Drawing.Image)(resources.GetObject("buttonAnaSayfa.Image")));
            this.buttonAnaSayfa.Location = new System.Drawing.Point(10, 900);
            this.buttonAnaSayfa.Name = "buttonAnaSayfa";
            this.buttonAnaSayfa.Size = new System.Drawing.Size(100, 100);
            this.buttonAnaSayfa.TabIndex = 8;
            this.buttonAnaSayfa.UseVisualStyleBackColor = true;
            this.buttonAnaSayfa.Click += new System.EventHandler(this.buttonAnaSayfa_Click);
            // 
            // matButon
            // 
            this.matButon.Dock = System.Windows.Forms.DockStyle.Top;
            this.matButon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.matButon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.matButon.ForeColor = System.Drawing.Color.Gainsboro;
            this.matButon.Image = ((System.Drawing.Image)(resources.GetObject("matButon.Image")));
            this.matButon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.matButon.Location = new System.Drawing.Point(0, 570);
            this.matButon.Name = "matButon";
            this.matButon.Padding = new System.Windows.Forms.Padding(12, 1, 1, 1);
            this.matButon.Size = new System.Drawing.Size(220, 80);
            this.matButon.TabIndex = 7;
            this.matButon.Text = "  MATEMATİK";
            this.matButon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.matButon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.matButon.UseVisualStyleBackColor = true;
            this.matButon.Click += new System.EventHandler(this.matButon_Click);
            // 
            // kimyaButon
            // 
            this.kimyaButon.Dock = System.Windows.Forms.DockStyle.Top;
            this.kimyaButon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kimyaButon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.kimyaButon.ForeColor = System.Drawing.Color.Gainsboro;
            this.kimyaButon.Image = ((System.Drawing.Image)(resources.GetObject("kimyaButon.Image")));
            this.kimyaButon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kimyaButon.Location = new System.Drawing.Point(0, 490);
            this.kimyaButon.Name = "kimyaButon";
            this.kimyaButon.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.kimyaButon.Size = new System.Drawing.Size(220, 80);
            this.kimyaButon.TabIndex = 6;
            this.kimyaButon.Text = "  KİMYA";
            this.kimyaButon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kimyaButon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.kimyaButon.UseVisualStyleBackColor = true;
            this.kimyaButon.Click += new System.EventHandler(this.kimyaButon_Click);
            // 
            // istatistikButon
            // 
            this.istatistikButon.Dock = System.Windows.Forms.DockStyle.Top;
            this.istatistikButon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.istatistikButon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.istatistikButon.ForeColor = System.Drawing.Color.Gainsboro;
            this.istatistikButon.Image = ((System.Drawing.Image)(resources.GetObject("istatistikButon.Image")));
            this.istatistikButon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.istatistikButon.Location = new System.Drawing.Point(0, 410);
            this.istatistikButon.Name = "istatistikButon";
            this.istatistikButon.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.istatistikButon.Size = new System.Drawing.Size(220, 80);
            this.istatistikButon.TabIndex = 7;
            this.istatistikButon.Text = "  İSTATİSTİK";
            this.istatistikButon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.istatistikButon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.istatistikButon.UseVisualStyleBackColor = true;
            this.istatistikButon.Click += new System.EventHandler(this.istatistikButon_Click);
            // 
            // fizikButon
            // 
            this.fizikButon.Dock = System.Windows.Forms.DockStyle.Top;
            this.fizikButon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fizikButon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fizikButon.ForeColor = System.Drawing.Color.Gainsboro;
            this.fizikButon.Image = ((System.Drawing.Image)(resources.GetObject("fizikButon.Image")));
            this.fizikButon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fizikButon.Location = new System.Drawing.Point(0, 330);
            this.fizikButon.Name = "fizikButon";
            this.fizikButon.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.fizikButon.Size = new System.Drawing.Size(220, 80);
            this.fizikButon.TabIndex = 4;
            this.fizikButon.Text = "  FİZİK";
            this.fizikButon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fizikButon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.fizikButon.UseVisualStyleBackColor = true;
            this.fizikButon.Click += new System.EventHandler(this.fizikButon_Click);
            // 
            // biyoButon
            // 
            this.biyoButon.Dock = System.Windows.Forms.DockStyle.Top;
            this.biyoButon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.biyoButon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.biyoButon.ForeColor = System.Drawing.Color.Gainsboro;
            this.biyoButon.Image = ((System.Drawing.Image)(resources.GetObject("biyoButon.Image")));
            this.biyoButon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.biyoButon.Location = new System.Drawing.Point(0, 250);
            this.biyoButon.Name = "biyoButon";
            this.biyoButon.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.biyoButon.Size = new System.Drawing.Size(220, 80);
            this.biyoButon.TabIndex = 3;
            this.biyoButon.Text = " BİYOLOJİ";
            this.biyoButon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.biyoButon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.biyoButon.UseVisualStyleBackColor = true;
            this.biyoButon.Click += new System.EventHandler(this.biyoButon_Click);
            // 
            // cscButon
            // 
            this.cscButon.Dock = System.Windows.Forms.DockStyle.Top;
            this.cscButon.FlatAppearance.BorderSize = 0;
            this.cscButon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cscButon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cscButon.ForeColor = System.Drawing.Color.Gainsboro;
            this.cscButon.Image = ((System.Drawing.Image)(resources.GetObject("cscButon.Image")));
            this.cscButon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cscButon.Location = new System.Drawing.Point(0, 170);
            this.cscButon.Name = "cscButon";
            this.cscButon.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.cscButon.Size = new System.Drawing.Size(220, 80);
            this.cscButon.TabIndex = 4;
            this.cscButon.Text = "  BİLGİSAYAR BİLİMLERİ";
            this.cscButon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cscButon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cscButon.UseVisualStyleBackColor = true;
            this.cscButon.Click += new System.EventHandler(this.cscButon_Click);
            // 
            // genelAnketButton
            // 
            this.genelAnketButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.genelAnketButton.FlatAppearance.BorderSize = 0;
            this.genelAnketButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.genelAnketButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.genelAnketButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.genelAnketButton.Image = global::anketlerProjesi.Properties.Resources.genel_anket;
            this.genelAnketButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.genelAnketButton.Location = new System.Drawing.Point(0, 90);
            this.genelAnketButton.Name = "genelAnketButton";
            this.genelAnketButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.genelAnketButton.Size = new System.Drawing.Size(220, 80);
            this.genelAnketButton.TabIndex = 3;
            this.genelAnketButton.Text = "  GENEL ANKETLER";
            this.genelAnketButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.genelAnketButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.genelAnketButton.UseVisualStyleBackColor = true;
            this.genelAnketButton.Click += new System.EventHandler(this.genelAnketButton_Click);
            // 
            // FormAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormAnaMenu";
            this.Text = "ANKETLER";
            this.panelMenu.ResumeLayout(false);
            this.panelIsim.ResumeLayout(false);
            this.panelIsim.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFenFakultesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button matButon;
        private System.Windows.Forms.Button kimyaButon;
        private System.Windows.Forms.Button istatistikButon;
        private System.Windows.Forms.Button fizikButon;
        private System.Windows.Forms.Button biyoButon;
        private System.Windows.Forms.Button cscButon;
        private System.Windows.Forms.Button genelAnketButton;
        private System.Windows.Forms.Panel panelIsim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button buttonCloseChildForm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonAnaSayfa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxFenFakultesi;
        private System.Windows.Forms.Label label2;
    }
}

