using anketlerProjesi.Properties;
using anketSon;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;

namespace anketlerProjesi
{
    public partial class FormAnaMenu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activateForm;

        public FormAnaMenu()
        {
            InitializeComponent();
            random = new Random();
            buttonCloseChildForm.Visible = false;
        }

        public static Bitmap GenerateQRCode(string url)
        {
            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            return qrCodeImage;
        }


        


        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelIsim.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    buttonCloseChildForm.Visible = true;

                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activateForm != null)
            activateForm.Close();
            ActivateButton(btnSender);
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }

       
        private void buttonCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activateForm != null)
            activateForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            labelTitle.Text = "ANKETLER";
            panelTitleBar.BackColor = Color.Lavender;
            panelIsim.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            buttonCloseChildForm.Visible = false;
        }

        private void genelAnketButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormGenelAnket(), sender);

        }

        private void cscButon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCscAnket(), sender);

        }

        private void biyoButon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormBiyolojiAnket(), sender);

        }

        private void fizikButon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFizikAnket(), sender);

        }

        private void istatistikButon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormIstatistikAnket(), sender);

        }

        private void kimyaButon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormKimyaAnket(), sender);

        }

        private void matButon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMatematikAnket(), sender);

        }

        private void buttonCloseChildForm_Click_1(object sender, EventArgs e)
        {
            if (activateForm != null)
                activateForm.Close();
            Reset();
        }

        private void buttonAnaSayfa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
