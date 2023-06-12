using anketSon;
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
    public partial class FormGenelAnket : Form
    {
        public FormGenelAnket()
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
        private void genelAnketButton1_Click(object sender, EventArgs e)
        {
            FormAnaMenu anaForm = (FormAnaMenu)this.Owner;
            Bitmap qrCodeImage = FormAnaMenu.GenerateQRCode("https://debis.deu.edu.tr/debis.php");
            pictureBoxGenelAnket.Image = qrCodeImage;
        }

        private void genelAnketButton2_Click(object sender, EventArgs e)
        {
            FormAnaMenu anaForm = (FormAnaMenu)this.Owner;
            Bitmap qrCodeImage = FormAnaMenu.GenerateQRCode("https://fen.deu.edu.tr/tr/");
            pictureBoxGenelAnket.Image = qrCodeImage;
        }

        private void genelAnketButton3_Click(object sender, EventArgs e)
        {
            FormAnaMenu anaForm = (FormAnaMenu)this.Owner;
            Bitmap qrCodeImage = FormAnaMenu.GenerateQRCode("https://csc.deu.edu.tr/tr/");
            pictureBoxGenelAnket.Image = qrCodeImage;
        }

        private void FormGenelAnket_Load(object sender, EventArgs e)
        {
            genelAnketButton1.Click += ButtonClickHandler;
            genelAnketButton2.Click += ButtonClickHandler;
            genelAnketButton3.Click += ButtonClickHandler;
        }
    }
}
