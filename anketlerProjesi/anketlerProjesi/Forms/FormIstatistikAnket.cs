using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anketlerProjesi.Forms
{
    public partial class FormIstatistikAnket : Form
    {
        public FormIstatistikAnket()
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
        private void istatistiButton1_Click(object sender, EventArgs e)
        {
            FormAnaMenu anaForm = (FormAnaMenu)this.Owner;
            Bitmap qrCodeImage = FormAnaMenu.GenerateQRCode("https://debis.deu.edu.tr/debis.php");
            pictureBoxIstatistik.Image = qrCodeImage;
        }

        private void istatistiButton2_Click(object sender, EventArgs e)
        {
            FormAnaMenu anaForm = (FormAnaMenu)this.Owner;
            Bitmap qrCodeImage = FormAnaMenu.GenerateQRCode("https://fen.deu.edu.tr/tr/");
            pictureBoxIstatistik.Image = qrCodeImage;
        }

        private void istatistiButton3_Click(object sender, EventArgs e)
        {
            FormAnaMenu anaForm = (FormAnaMenu)this.Owner;
            Bitmap qrCodeImage = FormAnaMenu.GenerateQRCode("https://csc.deu.edu.tr/tr/");
            pictureBoxIstatistik.Image = qrCodeImage; 
        }
  

        private void FormIstatistikAnket_Load(object sender, EventArgs e)
        {
            istatistiButton1.Click += ButtonClickHandler;
            istatistiButton2.Click += ButtonClickHandler;
            istatistiButton3.Click += ButtonClickHandler;
        }
    }
}
