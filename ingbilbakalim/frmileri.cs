using SpeechLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ingbilbakalim
{
    public partial class frmileri : Form
    {
        public frmileri()
        {
            InitializeComponent();
        }


        public void oku()
        {
            SpVoice ses = new SpVoice();
            ses.Speak(ingsonuc.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }

        public void uret()
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(30);
            /*int[] degerler = new int[10];
            for (int j = 0; j <= degerler.Length; j++)
            {
                degerler[j] = sayi;
                for (int i = 0; i <= degerler.Length; i++)
                {
                    if (degerler[j] != sayi)
                    {*/
            if (sayi == 0)
            {
                ingsonuc.Text = "Air Conditioner";//araba
                pictureBox1.ImageLocation = "img\\kelimeler\\ileri\\air_conditioner.png";
            }
            else if (sayi == 1)
            {
                ingsonuc.Text = "Archive Folder";//lamba
                pictureBox1.ImageLocation = "img\\kelimeler\\ileri\\archive_folder.png";
            }
            else if (sayi == 2)
            {
                ingsonuc.Text = "Badminton Racquet";//lamba
                pictureBox1.ImageLocation = "img\\kelimeler\\ileri\\badminton_racquet.png";
            }
            else if (sayi == 3)
            {
                ingsonuc.Text = "Binoculars";//lamba
                pictureBox1.ImageLocation = "img\\kelimeler\\ileri\\binoculars.png";
            }
            else if (sayi == 4)
            {
                ingsonuc.Text = "Biohazard";//lamba
                pictureBox1.ImageLocation = "img\\kelimeler\\ileri\\biohazard.png";
            }
            else if (sayi == 5)
            {
                ingsonuc.Text = "Blood Sample";//lamba
                pictureBox1.ImageLocation = "img\\kelimeler\\ileri\\archive_folder.png";
            }
            else if (sayi == 6)
            {
                ingsonuc.Text = "Brainstorm Skill";//lamba
                pictureBox1.ImageLocation = "img\\kelimeler\\ileri\\brainstorm_skill.png";
            }
            else if (sayi == 7)
            {
                ingsonuc.Text = "Customs Officer";//lamba
                pictureBox1.ImageLocation = "img\\kelimeler\\ileri\\customs_officer.png";
            }
            else if (sayi == 8)
            {
                ingsonuc.Text = "Dictionary";//lamba
                pictureBox1.ImageLocation = "img\\kelimeler\\ileri\\dictionary.png";
            }
            else if (sayi == 9)
            {
                ingsonuc.Text = "Fashion Trend";//lamba
                pictureBox1.ImageLocation = "img\\kelimeler\\ileri\\fashion_trend.png";
            }
            else if (sayi == 10)
            {
                ingsonuc.Text = "Filing Cabinet";//lamba
                pictureBox1.ImageLocation = "img\\kelimeler\\ileri\\filing_cabinet.png";
            }
            else if (sayi == 11)
            {
                ingsonuc.Text = "Flip Flops";//lamba
                pictureBox1.ImageLocation = "img\\kelimeler\\ileri\\flip_flops.png";
            }
            else if (sayi == 12)
            {
                ingsonuc.Text = "French Friesr";//lamba
                pictureBox1.ImageLocation = "img\\kelimeler\\ileri\\french_fries.png";
            }
            else if (sayi == 13)
            {
                ingsonuc.Text = "Frozen Window";//lamba
                pictureBox1.ImageLocation = "img\\kelimeler\\ileri\\frozen_window.png";
            }
            else if (sayi == 14)
            {
                ingsonuc.Text = "Garbage Truck";//lamba
                pictureBox1.ImageLocation = "img\\kelimeler\\ileri\\garbage_truck.png";
            }
            else if (sayi == 15)
            {
                ingsonuc.Text = "Healthy Food";//lamba
                pictureBox1.ImageLocation = "img\\kelimeler\\ileri\\healthy_food.png";
            }
            else if (sayi == 16)
            {
                ingsonuc.Text = "Horseback Riding";//lamba
                pictureBox1.ImageLocation = "img\\kelimeler\\ileri\\horseback_riding.png";
            }
            else if (sayi == 17)
            {
                ingsonuc.Text = "Key Exchange";//lamba
                pictureBox1.ImageLocation = "img\\kelimeler\\ileri\\key_exchange.png";
            }
            else if (sayi == 18)
            {
                ingsonuc.Text = "Product Documents";//lamba
                pictureBox1.ImageLocation = "img\\kelimeler\\ileri\\product_documents.png";
            }
            else if (sayi == 19)
            {
                ingsonuc.Text = "Scissors";//lamba
                pictureBox1.ImageLocation = "img\\kelimeler\\ileri\\scissors.png";
            }
            else if (sayi == 20)
            {
                ingsonuc.Text = "Search More";//lamba
                pictureBox1.ImageLocation = "img\\kelimeler\\ileri\\search_more.png";
            }
            else if (sayi == 21)
            {
                ingsonuc.Text = "Shopping Cart";//lamba
                pictureBox1.ImageLocation = "img\\kelimeler\\ileri\\shopping_cart.png";
            }
            else if (sayi == 22)
            {
                ingsonuc.Text = "South Direction";//lamba
                pictureBox1.ImageLocation = "img\\kelimeler\\ileri\\south_direction.png";
            }
            else if (sayi == 23)
            {
                ingsonuc.Text = "Spiral Bulb";//lamba
                pictureBox1.ImageLocation = "img\\kelimeler\\ileri\\spiral_bulb.png";
            }
            else if (sayi == 24)
            {
                ingsonuc.Text = "Sterilization";//lamba
                pictureBox1.ImageLocation = "img\\kelimeler\\ileri\\sterilization.png";
            }
            else if (sayi == 25)
            {
                ingsonuc.Text = "Toothpaste";//lamba
                pictureBox1.ImageLocation = "img\\kelimeler\\ileri\\toothpaste.png";
            }
            else if (sayi == 26)
            {
                ingsonuc.Text = "Vacuum Cleaner";//lamba
                pictureBox1.ImageLocation = "img\\kelimeler\\ileri\\vacuum_cleaner.png";
            }
            else if (sayi == 27)
            {
                ingsonuc.Text = "Video Projector";//lamba
                pictureBox1.ImageLocation = "img\\kelimeler\\ileri\\video_projector.png";
            }
            else if (sayi == 28)
            {
                ingsonuc.Text = "Washing Machine";//lamba
                pictureBox1.ImageLocation = "img\\kelimeler\\ileri\\washing_machine.png";
            }

        }



        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            cikis cikis = new cikis();
            cikis.Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.Show();
            this.Hide();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.Show();
            this.Hide();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            oku();
        }

        private void ingsonuc_Click(object sender, EventArgs e)
        {
            oku();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            uret();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            frmanamenu anamenu = new frmanamenu();
            anamenu.Show();
            this.Hide();
        }

        private void frmileri_Load(object sender, EventArgs e)
        {
            uret();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            oku();
        }
    }
}
