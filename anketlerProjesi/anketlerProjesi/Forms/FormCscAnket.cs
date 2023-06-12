using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace anketlerProjesi.Forms
{
    public partial class FormCscAnket : Form
    {
        public FormCscAnket()
        {
            InitializeComponent();
        }

        private void ButtonClickHandler(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (!button.Enabled)
                return;

            button.Enabled = false;

            // Buton tıklandığında yapılacak işlemler

            var timer = new Timer();
            timer.Interval = 5000;
            timer.Tag = button;
            timer.Tick += TimerTickHandler;
            timer.Start();
        }

        private void TimerTickHandler(object sender, EventArgs e)
        {
            var timer = (Timer)sender;
            var button = (Button)timer.Tag;
            button.Enabled = true;
            timer.Stop();
        }

        private void cscButton1_Click(object sender, EventArgs e)
        {
            FormAnaMenu anaForm = (FormAnaMenu)this.Owner;
            Bitmap qrCodeImage = FormAnaMenu.GenerateQRCode("https://debis.deu.edu.tr/debis.php");
            pictureBoxCsc.Image = qrCodeImage;
        }

        private void cscButton2_Click(object sender, EventArgs e)
        {
            FormAnaMenu anaForm = (FormAnaMenu)this.Owner;
            Bitmap qrCodeImage = FormAnaMenu.GenerateQRCode("https://fen.deu.edu.tr/tr/");
            pictureBoxCsc.Image = qrCodeImage;
        }

        private void cscButton3_Click(object sender, EventArgs e)
        {
            FormAnaMenu anaForm = (FormAnaMenu)this.Owner;
            Bitmap qrCodeImage = FormAnaMenu.GenerateQRCode("https://csc.deu.edu.tr/tr/");
            pictureBoxCsc.Image = qrCodeImage;
        }

     

        private void FormCscAnket_Load_1(object sender, EventArgs e)
        {
            cscButton1.Click += ButtonClickHandler;
            cscButton2.Click += ButtonClickHandler;
            cscButton3.Click += ButtonClickHandler;
        }
    }
}
