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
    public partial class frmorta : Form
    {
        public frmorta()
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
            int sayi = rastgele.Next(37);
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
                ingsonuc.Text = "Audio Cable";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\audio_cable.png";
            }
            else if (sayi == 1)
            {
                ingsonuc.Text = "Ball";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\ball.png";
            }
            else if (sayi == 2)
            {
                ingsonuc.Text = "Bicycle";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\bicycle.png";
            }
            else if (sayi == 3)
            {
                ingsonuc.Text = "Blossom";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\Blossom.png";
            }
            else if (sayi == 4)
            {
                ingsonuc.Text = "Books";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\books.png";
            }
            else if (sayi == 5)
            {
                ingsonuc.Text = "Bowling Ball";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\bowling_ball.png";
            }
            else if (sayi == 6)
            {
                ingsonuc.Text = "Car";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\car.png";
            }
            else if (sayi == 7)
            {
                ingsonuc.Text = "Cherry";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\cherry.png";
            }
            else if (sayi == 8)
            {
                ingsonuc.Text = "Chess";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\chess.png";
            }
            else if (sayi == 9)
            {
                ingsonuc.Text = "Coat";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\coat.png";
            }
            else if (sayi == 10)
            {
                ingsonuc.Text = "Cucumber";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\cucumber.png";
            }
            else if (sayi == 11)
            {
                ingsonuc.Text = "Dumbbell";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\dumbbell.png";
            }
            else if (sayi == 12)
            {
                ingsonuc.Text = "Export";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\export.png";
            }
            else if (sayi == 13)
            {
                ingsonuc.Text = "Eyeglasses";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\Eyeglasses.png";
            }
            else if (sayi == 14)
            {
                ingsonuc.Text = "Gift";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\gift.png";
            }
            else if (sayi == 15)
            {
                ingsonuc.Text = "Guitar";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\guitar.png";
            }
            else if (sayi == 16)
            {
                ingsonuc.Text = "Handshake";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\handshake.png";
            }
            else if (sayi == 17)
            {
                ingsonuc.Text = "Headphones";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\headphones.png";
            }
            else if (sayi == 18)
            {
                ingsonuc.Text = "Hearts";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\hearts.png";
            }
            else if (sayi == 19)
            {
                ingsonuc.Text = "Helmet";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\helmet.png";
            }
            else if (sayi == 20)
            {
                ingsonuc.Text = "Arrows";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\arrows.png";
            }
            else if (sayi == 21)
            {
                ingsonuc.Text = "Gun";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\gun.png";
            }
            else if (sayi == 22)
            {
                ingsonuc.Text = "Headphones";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\headphones.png";
            }
            else if (sayi == 23)
            {
                ingsonuc.Text = "Mirror";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\mirror.png";
            }
            else if (sayi == 24)
            {
                ingsonuc.Text = "Ketchup";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\ketchup.png";
            }
            else if (sayi == 25)
            {
                ingsonuc.Text = "Knife";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\knife.png";
            }
            else if (sayi == 26)
            {
                ingsonuc.Text = "Marker Pen";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\marker_pen.png";
            }
            else if (sayi == 27)
            {
                ingsonuc.Text = "Paper Plane";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\paper_plane.png";
            }
            else if (sayi == 28)
            {
                ingsonuc.Text = "Phone";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\phone.png";
            }
            else if (sayi == 29)
            {
                ingsonuc.Text = "Pregnant";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\pregnant.png";
            }
            else if (sayi == 30)
            {
                ingsonuc.Text = "Scream";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\scream.png";
            }
            else if (sayi == 31)
            {
                ingsonuc.Text = "Shield";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\shield.png";
            }
            else if (sayi == 32)
            {
                ingsonuc.Text = "Ahrooms";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\shrooms.png";
            }
            else if (sayi == 33)
            {
                ingsonuc.Text = "Skirt";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\skirt.png";
            }
            else if (sayi == 34)
            {
                ingsonuc.Text = "Small Axe";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\small_axe.png";
            }
            else if (sayi == 35)
            {
                ingsonuc.Text = "Spade";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\spade.png";
            }
            else if (sayi == 35)
            {
                ingsonuc.Text = "Wolf";
                pictureBox1.ImageLocation = "img\\kelimeler\\orta\\wolf.png";
            }

        }


        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.Show();
            this.Hide();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            frmanamenu anamenu = new frmanamenu();
            anamenu.Show();
            this.Hide();
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

        private void frmorta_Load(object sender, EventArgs e)
        {
            uret();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            oku();
        }
    }
}
