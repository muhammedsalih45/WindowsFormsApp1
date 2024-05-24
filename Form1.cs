using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int psSkor = 0;
        int oyuncuSkor = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int deger;

            deger = random.Next(1,4);

            if (deger == 1)
            {
                label2.Text = "Beraberlik";
                label1.Text = "";
                tas2.BackColor = Color.Cyan;

            }else if (deger == 2)
            {
                label1.Text = "Oyuncu Kazandı";
                makas2.BackColor = Color.Green;
                label2.Text = "";
                oyuncuSkor++;
                skor1.Text = "skor: " + oyuncuSkor;
            }else if (deger == 3)
            {
                label1.Text = "Bilgisayar Kazandı";
                label2.Text = "";
                kagıt2.BackColor = Color.Red;
                psSkor++;
                skor2.Text = "Skor: " + psSkor;
            }
        }

        private void kagıt1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int deger;

            deger = random.Next(1, 4);

            if (deger == 1)
            {
                label2.Text = "Beraberlik";
                label1.Text = "";
                kagıt2.BackColor = Color.Cyan;
            }
            else if (deger == 2)
            {
                label1.Text = "Oyuncu Kazandı";
                label2.Text = "";
                tas2.BackColor = Color.Green;
                oyuncuSkor++;
                skor1.Text = "Skor: " + oyuncuSkor;
            }
            else if (deger == 3)
            {
                label1.Text = "Bilgisayar Kazandı";
                makas2.BackColor = Color.Red;
                label2.Text = "";
                psSkor++;
                skor2.Text = "Skor: " + psSkor;
            }
        }
        
        private void makas1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int deger;

            deger = random.Next(1, 4);


            if (deger == 1)
            {
                label2.Text = "Beraberlik";
                label1.Text = "";
                makas2.BackColor = Color.Cyan;
            }
            else if (deger == 2)
            {
                label1.Text = "Oyuncu Kazandı";
                kagıt2.BackColor = Color.Green;
                label2.Text = "";
                oyuncuSkor++;
                skor1.Text = "Skor: " + oyuncuSkor;

            }
            else if (deger == 3)
            {
                label1.Text = "Bilgisayar Kazandı";
                label2.Text = "";
                tas2.BackColor = Color.Red;
                psSkor++;
                skor2.Text = "Skor: " + psSkor;
            }
        }

        private void skor_Click(object sender, EventArgs e)
        {
         
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
