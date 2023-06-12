using anketSon;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace anketlerProjesi.Forms
{
    public partial class FormBiyolojiAnket : Form
    {

        public FormBiyolojiAnket()
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




        private void biyolojiButton1_Click(object sender, EventArgs e)
         {
            FormAnaMenu anaForm = (FormAnaMenu)this.Owner;
            Bitmap qrCodeImage = FormAnaMenu.GenerateQRCode("https://debis.deu.edu.tr/debis.php");
            pictureBoxBiyoloji.Image = qrCodeImage;
         }

        private void biyolojiButton2_Click(object sender, EventArgs e)
        {
            FormAnaMenu anaForm = (FormAnaMenu)this.Owner;
            Bitmap qrCodeImage = FormAnaMenu.GenerateQRCode("https://fen.deu.edu.tr/tr/");
            pictureBoxBiyoloji.Image = qrCodeImage;
        }

        private void biyolojiButton3_Click(object sender, EventArgs e)
        {
            FormAnaMenu anaForm = (FormAnaMenu)this.Owner;
            Bitmap qrCodeImage = FormAnaMenu.GenerateQRCode("https://csc.deu.edu.tr/tr/");
            pictureBoxBiyoloji.Image = qrCodeImage;
        }

        private void FormBiyolojiAnket_Load(object sender, EventArgs e)
        {

            biyolojiButton1.Click += ButtonClickHandler;
            biyolojiButton2.Click += ButtonClickHandler;
            biyolojiButton3.Click += ButtonClickHandler;
        }
    }
    
}
