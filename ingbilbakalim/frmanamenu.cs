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
    public partial class frmanamenu : Form
    {
        public frmanamenu()
        {
            InitializeComponent();
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

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            frmbaslangic baslangic = new frmbaslangic();
            baslangic.Show();
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            frmorta orta = new frmorta();
            orta.Show();
            this.Hide();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            frmileri ileri = new frmileri();
            ileri.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.Show();
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.Show();
            this.Hide();
        }
    }
}
