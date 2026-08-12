using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        Random rnd2 = new Random();
        int a;
        int emtiyazkarbar = 0;
        int emtiyazai = 0;
        Form2 frm2 = new Form2();
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            a = rnd2.Next(6, 9);
            string b = a.ToString() + ".jpg";
            pictureBox3.ImageLocation = b;
            if (sang.Visible == true && a == 6)
            {
                MessageBox.Show("شما برنده شدید!", "آفرین", MessageBoxButtons.OKCancel);
                emtiyazkarbar += 1;
                label5.Text = emtiyazai.ToString();
                sang.Visible = false;
                pictureBox3.Visible = false;
            }
            if (sang.Visible == true && a == 7)
            {
                MessageBox.Show("ربات برد!", "متاسفم", MessageBoxButtons.OKCancel);
                emtiyazai += 1;
                label4.Text = emtiyazai.ToString();
                sang.Visible = false;
                pictureBox3.Visible = false;
            }
            if (sang.Visible == true && a == 8)
            {
                MessageBox.Show("مساوی شدید!", "پیام", MessageBoxButtons.OKCancel);
                sang.Visible = false;
                pictureBox3.Visible = false;
            }
            if (kaghaz.Visible == true && a == 6)
            {
                MessageBox.Show("ربات برد!", "متاسفم", MessageBoxButtons.OKCancel);
                emtiyazai += 1;
                label4.Text = emtiyazai.ToString();
                kaghaz.Visible = false;
                pictureBox3.Visible = false;
            }
            if (kaghaz.Visible == true && a == 7)
            {
                MessageBox.Show("مساوی شدید!", "پیام", MessageBoxButtons.OKCancel);
                kaghaz.Visible = false;
                pictureBox3.Visible = false;
            }
            if (kaghaz.Visible == true && a == 8)
            {
                MessageBox.Show("شما برنده شدید!", "آفرین", MessageBoxButtons.OKCancel);
                emtiyazkarbar += 1;
                label5.Text = emtiyazkarbar.ToString();
                kaghaz.Visible = false;
                pictureBox3.Visible = false;
            }
            if (ghachi.Visible == true && a == 6)
            {
                MessageBox.Show("مساوی شدید!", "پیام", MessageBoxButtons.OKCancel);
                ghachi.Visible = false;
                pictureBox3.Visible = false;
            }
            if (ghachi.Visible == true && a == 7)
            {
                MessageBox.Show("شما برنده شدید!", "آفرین", MessageBoxButtons.OKCancel);
                emtiyazkarbar += 1;
                label5.Text = emtiyazkarbar.ToString();
                ghachi.Visible = false;
                pictureBox3.Visible = false;
            }
            if (ghachi.Visible == true && a == 8)
            {
                MessageBox.Show("ربات برد!", "متاسفم", MessageBoxButtons.OKCancel);
                emtiyazai += 1;
                label4.Text = emtiyazai.ToString();
                ghachi.Visible = false;
                pictureBox3.Visible = false;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sang.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kaghaz.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ghachi.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("کاربر گرامی بعد از انتخاب کردن گزینه های سنگ,کاغذ و یا قیچی برای شروع بازی با ربات دکمه شروع را انتخاب کرده و برای خروج از بازی دکمه خروج را انتخاب کرده", "قوانین بازی سنگ,کاغذ,قیچی", MessageBoxButtons.OKCancel);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (emtiyazkarbar > emtiyazai)
            {
                MessageBox.Show("شما برنده شدید", "آفرین", MessageBoxButtons.OKCancel);
                this.Hide();
                frm2.ShowDialog();
                this.Close();
            }
            else if (emtiyazai > emtiyazkarbar)
            {
                MessageBox.Show("شما باختید", "متاسفم", MessageBoxButtons.OKCancel);
                this.Hide();
                frm2.ShowDialog();
                this.Close();
            }
            else if (emtiyazkarbar == emtiyazai)
            {
                MessageBox.Show("مساوی شدید", "پیام", MessageBoxButtons.OKCancel);
                this.Hide();
                frm2.ShowDialog();
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
