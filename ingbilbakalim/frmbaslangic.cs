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
    public partial class frmbaslangic : Form
    {
        public frmbaslangic()
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
            int sayi = rastgele.Next(33);
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
                ingsonuc.Text = "Airport";//araba
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\airport.png";
            }
            else if (sayi == 1)
            {
                ingsonuc.Text = "Ant";//lamba
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\ant.png";
            }
            else if (sayi == 2)
            {
                ingsonuc.Text = "Bed";//uçak
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\bed.png";
            }
            else if (sayi == 3)
            {
                ingsonuc.Text = "Bomb";//kitaplar
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\bomb.png";
            }
            else if (sayi == 4)
            {
                ingsonuc.Text = "Chair";//kalem
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\chair.png";
            }
            else if (sayi == 5)
            {
                ingsonuc.Text = "Cheese";//mouse
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\cheese.png";
            }
            else if (sayi == 6)
            {
                ingsonuc.Text = "Children";//dizüstü bilgisayar
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\children.png";
            }
            else if (sayi == 7)
            {
                ingsonuc.Text = "Clock";//Ev
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\clock.png";
            }
            else if (sayi == 8)
            {
                ingsonuc.Text = "Door";//çanta
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\door.png";
            }
            else if (sayi == 9)
            {
                ingsonuc.Text = "Duck";//yatak
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\duck.png";
            }
            else if (sayi == 10)
            {
                ingsonuc.Text = "fan";//kulaklık
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\fan.png";
            }
            else if (sayi == 11)
            {
                ingsonuc.Text = "Fire Alarm";//çiçek
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\fire_alarm.png";
            }
            else if (sayi == 12)
            {
                ingsonuc.Text = "Firework";//Gözlük
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\firework.png";
            }
            else if (sayi == 13)
            {
                ingsonuc.Text = "Grater";//kapı
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\grater.png";
            }
            else if (sayi == 14)
            {
                ingsonuc.Text = "Home";//top
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\home.png";
            }
            else if (sayi == 15)
            {
                ingsonuc.Text = "Jam";//kablo
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\jam.png";
            }
            else if (sayi == 16)
            {
                ingsonuc.Text = "Key";//tren
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\key.png";
            }
            else if (sayi == 17)
            {
                ingsonuc.Text = "Lamp";//masa
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\lamp.png";
            }
            else if (sayi == 18)
            {
                ingsonuc.Text = "Laptop";//klima
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\laptop.png";
            }
            else if (sayi == 19)
            {
                ingsonuc.Text = "Magnet";//sandalye
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\magnet.png";
            }
            else if (sayi == 20)
            {
                ingsonuc.Text = "Mayonaise";//sandalye
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\mayonaise.png";
            }
            else if (sayi == 21)
            {
                ingsonuc.Text = "Mouse";//sandalye
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\mouse.png";
            }
            else if (sayi == 22)
            {
                ingsonuc.Text = "Pencil";//sandalye
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\pencil.png";
            }
            else if (sayi == 23)
            {
                ingsonuc.Text = "Picture";//sandalye
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\picture.png";
            }
            else if (sayi == 24)
            {
                ingsonuc.Text = "Pizza";//sandalye
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\pizza.png";
            }
            else if (sayi == 25)
            {
                ingsonuc.Text = "Police";//sandalye
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\police.png";
            }
            else if (sayi == 26)
            {
                ingsonuc.Text = "Popcorn";//sandalye
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\popcorn.png";
            }
            else if (sayi == 27)
            {
                ingsonuc.Text = "Purse";//sandalye
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\purse.png";
            }
            else if (sayi == 28)
            {
                ingsonuc.Text = "Radio";//sandalye
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\radio.png";
            }
            else if (sayi == 29)
            {
                ingsonuc.Text = "Sausage";//sandalye
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\sausage.png";
            }
            else if (sayi == 30)
            {
                ingsonuc.Text = "Sword";//sandalye
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\sword.png";
            }
            else if (sayi == 31)
            {
                ingsonuc.Text = "Table";//sandalye
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\table.png";
            }
            else if (sayi == 32)
            {
                ingsonuc.Text = "Train";//sandalye
                pictureBox1.ImageLocation = "img\\kelimeler\\baslangic\\train.png";
            }

        }




        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            cikis cikis = new cikis();
            cikis.Show();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            frmanamenu anamenu = new frmanamenu();
            anamenu.Show();
            this.Hide();
        }

        private void frmbaslangic_Load(object sender, EventArgs e)
        {
            uret();
        }
        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            oku();
        }
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            uret();
        }

        private void ingsonuc_Click(object sender, EventArgs e)
        {
            oku();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            oku();
        }
    }
}
