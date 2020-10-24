using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÜlkelerveBaşkentleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        int puan = 0;
        int sure = 60;

        private void ButonSıfırla()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Start();
            sure--;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = false;
            button1.BackColor = DefaultBackColor;
            button2.BackColor = DefaultBackColor;
            button3.BackColor = DefaultBackColor;
            button4.BackColor = DefaultBackColor;
            button5.BackColor = DefaultBackColor;
            button6.Text = "Sonraki Soru";
            sayac++;
            label1.Text = sayac.ToString();

            if(sayac==1)
            {
                label2.Text = "Fransa";
                pictureBox1.ImageLocation = @"C:\Users\Eren\source\repos\ÜlkelerveBaşkentleri\Yeni klasör\paris.jpg";
                button1.Text = "Lille";
                button2.Text = "Paris";
                button3.Text = "Marsilya";
                button4.Text = "Lyon";
                button5.Text = "Bordeaux";
                label3.Text = "Paris";
            }

            if(sayac==2)
            {
                label2.Text = "Almanya";
                pictureBox1.ImageLocation = @"C:\Users\Eren\source\repos\ÜlkelerveBaşkentleri\Yeni klasör\berlin.jpg";
                button1.Text = "Hamburg";
                button2.Text = "Hannover";
                button3.Text = "Berlin";
                button4.Text = "Frankfurt";
                button5.Text = "Kiel";
                label3.Text = "Berlin";
            }

            if(sayac==3)
            {
                label2.Text = "İngiltere";
                pictureBox1.ImageLocation= @"C:\Users\Eren\source\repos\ÜlkelerveBaşkentleri\Yeni klasör\londra.jpg";
                button1.Text = "Londra";
                button2.Text = "Manchester";
                button3.Text = "Cambridge";
                button4.Text = "Oxford";
                button5.Text = "Bristol";
                label3.Text = "Londra";
            }

            if(sayac==4)
            {
                label2.Text = "İtalya";
                pictureBox1.ImageLocation= @"C:\Users\Eren\source\repos\ÜlkelerveBaşkentleri\Yeni klasör\roma.jpg";
                button1.Text = "Venedik";
                button2.Text = "Milano";
                button3.Text = "Floransa";
                button4.Text = "Roma";
                button5.Text = "Napoli";
                label3.Text = "Roma";
            }

            if(sayac==5)
            {
                label2.Text = "Türkiye";
                pictureBox1.ImageLocation = @"C:\Users\Eren\source\repos\ÜlkelerveBaşkentleri\Yeni klasör\ankara.jpg";
                button1.Text = "İstanbul";
                button2.Text = "Ankara";
                button3.Text = "İzmir";
                button4.Text = "Bursa";
                button5.Text = "Adana";
                label3.Text = "Ankara";
            }

            if(sayac==6)
            {
                label2.Text = "Hollanda";
                pictureBox1.ImageLocation = @"C:\Users\Eren\source\repos\ÜlkelerveBaşkentleri\Yeni klasör\amsterdam.jpg";
                button1.Text = "Amsterdam";
                button2.Text = "Rotterdam";
                button3.Text = "Lahey";
                button4.Text = "Eindhoven";
                button5.Text = "Delft";
                label3.Text = "Amsterdam";
            }

            if(sayac == 7)
            {
                label2.Text = "İsveç";
                pictureBox1.ImageLocation = @"C:\Users\Eren\source\repos\ÜlkelerveBaşkentleri\Yeni klasör\stockholm.jpg";
                button1.Text = "Göteborg";
                button2.Text = "Helsinborg";
                button3.Text = "Stockholm";
                button4.Text = "Boras";
                button5.Text = "Malmö";
                label3.Text = "Stockholm";
            }

            if(sayac == 8)
            {
                label2.Text = "Kanada";
                pictureBox1.ImageLocation = @"C:\Users\Eren\source\repos\ÜlkelerveBaşkentleri\Yeni klasör\ottawa.jpg";
                button1.Text = "Toronto";
                button2.Text = "Vancouver";
                button3.Text = "Montreal";
                button4.Text = "Edmonton";
                button5.Text = "Ottawa";
                label3.Text = "Ottawa";
            }

            if(sayac == 9)
            {
                label2.Text = "İsviçre";
                pictureBox1.ImageLocation = @"C:\Users\Eren\source\repos\ÜlkelerveBaşkentleri\Yeni klasör\bern.jpg";
                button1.Text = "Cenevre";
                button2.Text = "Bern";
                button3.Text = "Zürih";
                button4.Text = "Lozan";
                button5.Text = "Montrö";
                label3.Text = "Bern";
            }

            if(sayac == 10)
            {
                label2.Text = "Bosna Hersek";
                pictureBox1.ImageLocation = @"C:\Users\Eren\source\repos\ÜlkelerveBaşkentleri\Yeni klasör\saraybosna.jpg";
                button1.Text = "Saraybosna";
                button2.Text = "Mostar";
                button3.Text = "Travnik";
                button4.Text = "Tuzla";
                button5.Text = "Banja Luka";
                label3.Text = "Saraybosna";
            }

            if(sayac==11)
            {
                timer1.Stop();
                label1.Text = "0";
                pictureBox1.ImageLocation = " ";
                button1.Text = " ";
                button2.Text = " ";
                button3.Text = " ";
                button4.Text = " ";
                button5.Text = " ";
                label2.Text = " ";
                puan = puan + Convert.ToInt32(label7.Text);
                label6.Text = puan.ToString();
                MessageBox.Show("Tebrikler,oyun bitti. Puanınız:" + label6.Text);
                Application.Exit();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = button1.Text;
            ButonSıfırla();
           
           
            if(label3.Text==label4.Text)
            {
                puan = puan + 10;
                label6.Text = puan.ToString();
                button1.BackColor = Color.Green;
            }

            else
            {
                puan = puan - 5;
                label6.Text = puan.ToString();
                button1.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = button2.Text;
            ButonSıfırla();
            if(label3.Text==label4.Text)
            {
                puan = puan + 10;
                label6.Text = puan.ToString();
                button2.BackColor = Color.Green;
            }

            else
            {
                puan = puan - 5;
                label6.Text = puan.ToString();
                button2.BackColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = button3.Text;
            ButonSıfırla();
            if(label3.Text==label4.Text)
            {
                puan = puan + 10;
                label6.Text = puan.ToString();
                button3.BackColor = Color.Green;
            }

            else
            {
                puan = puan - 5;
                label6.Text = puan.ToString();
                button3.BackColor = Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = button4.Text;
            ButonSıfırla();
            if (label3.Text == label4.Text)
            {
                puan = puan + 10;
                label6.Text = puan.ToString();
                button4.BackColor = Color.Green;
            }

            else
            {
                puan = puan - 5;
                label6.Text = puan.ToString();
                button4.BackColor = Color.Red;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label4.Text = button5.Text;
            ButonSıfırla();
            if (label3.Text == label4.Text)
            {
                puan = puan + 10;
                label6.Text = puan.ToString();
                button5.BackColor = Color.Green;
            }

            else
            {
                puan = puan - 5;
                label6.Text = puan.ToString();
                button5.BackColor = Color.Red; 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            label7.Text = sure.ToString();

            if(sure==0)
            {
                timer1.Stop();
                MessageBox.Show("Süreniz doldu! Puanınız:" + label6.Text);
                Application.Exit();
            }
        }
    }
}
