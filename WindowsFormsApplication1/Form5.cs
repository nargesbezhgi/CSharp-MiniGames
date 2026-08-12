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
    public partial class Form5 : Form
    {
        int emtiyaz = 0;
        int min = 0;
        public Form5()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            textBox7.Text = comboBox1.SelectedItem.ToString();
            if (textBox7.Text == "معمای حدس کلمه آسان")
            {
                pictureBox2.Visible = true;
                textBox1.Visible = true;
            }
            if (textBox7.Text == "معمای حدس کلمه متوسط")
            {
                pictureBox3.Visible = true;
                textBox3.Visible = true;
            }
            if (textBox7.Text == "معمای حدس کلمه دشوار")
            {
                pictureBox1.Visible = true;
                textBox5.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "معمای حدس کلمه آسان")
            {
                pictureBox2.Visible = false;
                textBox1.Visible = false;
                pictureBox6.Visible = true;
                textBox2.Visible = true;
            }
            if (textBox7.Text == "معمای حدس کلمه متوسط")
            {
                pictureBox3.Visible = false;
                textBox3.Visible = false;
                pictureBox5.Visible = true;
                textBox4.Visible = true;
            }
            if (textBox7.Text == "معمای حدس کلمه دشوار")
            {
                pictureBox1.Visible = false;
                textBox5.Visible = false;
                pictureBox4.Visible = true;
                textBox6.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // i++;
            min += 1;
            //label11.Text = min.ToString();
            if (min % 20 == 0)
            {
                if (pictureBox2.Visible == true && textBox1.Text == "پلاستیک")
                {
                    MessageBox.Show("درست حدس زدید", "آفرین", MessageBoxButtons.OKCancel);
                    emtiyaz += 1;
                    label4.Text = emtiyaz.ToString();
                }

                if (pictureBox2.Visible == true && textBox1.Text != "پلاستیک")
                    MessageBox.Show("اشتباه حدس زدید", "متاسفم", MessageBoxButtons.OKCancel);

                if (pictureBox3.Visible == true && textBox3.Text == "ایران")
                {
                    MessageBox.Show("درست حدس زدید", "آفرین", MessageBoxButtons.OKCancel);
                    emtiyaz += 1;
                    label4.Text = emtiyaz.ToString();
                }

                if (pictureBox3.Visible == true && textBox3.Text != "ایران")
                    MessageBox.Show("اشتباه حدس زدید", "متاسفم", MessageBoxButtons.OKCancel);

                if (pictureBox1.Visible == true && textBox5.Text == "بلدرچین")
                {
                    MessageBox.Show("درست حدس زدید", "آفرین", MessageBoxButtons.OKCancel);
                    emtiyaz += 1;
                    label4.Text = emtiyaz.ToString();
                }

                if (pictureBox1.Visible == true && textBox5.Text != "بلدرچین")
                    MessageBox.Show("اشتباه حدس زدید", "متاسفم", MessageBoxButtons.OKCancel);
                if (pictureBox6.Visible == true && textBox2.Text == "پادری")
                {
                    MessageBox.Show("درست حدس زدید", "آفرین", MessageBoxButtons.OKCancel);
                    emtiyaz += 1;
                    label4.Text = emtiyaz.ToString();
                }

                if (pictureBox6.Visible == true && textBox2.Text != "پادری")
                    MessageBox.Show("اشتباه حدس زدید", "متاسفم", MessageBoxButtons.OKCancel);

                if (pictureBox5.Visible == true && textBox4.Text == "نیشخند")
                {
                    MessageBox.Show("درست حدس زدید", "آفرین", MessageBoxButtons.OKCancel);
                    emtiyaz += 1;
                    label4.Text = emtiyaz.ToString();
                }

                if (pictureBox5.Visible == true && textBox4.Text != "نیشخند")
                    MessageBox.Show("اشتباه حدس زدید", "متاسفم", MessageBoxButtons.OKCancel);

                if (pictureBox4.Visible == true && textBox6.Text == "هایپرمارکت")
                {
                    MessageBox.Show("درست حدس زدید", "آفرین", MessageBoxButtons.OKCancel);
                    emtiyaz += 1;
                    label4.Text = emtiyaz.ToString();
                }

                if (pictureBox4.Visible == true && textBox6.Text != "هایپرمارکت")

                    MessageBox.Show("اشتباه حدس زدید", "متاسفم", MessageBoxButtons.OKCancel);
            }

            if (min % 41 == 0)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                //timer1.Enabled = false;
                //MessageBox.Show("زمان شما به اتمام رسید", "متاسفم", MessageBoxButtons.OKCancel);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("کاربر گرامی ابتدا باید از لیست تعریف شده سطح معما را انتخاب کنید سپس بر روی دکمه ی شروع کلیک کنید. هر سطح دارای دو معما میباشد و بعد از حدس معمای اول سریعا بر روی دکمه ی تغییر تصویر کلیک کنید. زمان شما برای حدس هر معما 20 ثانیه است که بعد از این 20 ثانیه به شما پیام درست یا غلط بودن حدستان نمایش داده می شود. لطفا حدس خود را بودن هیچ فاصله ای وارد کنید تا غلط تشخیص داده نشود", "قوانین بازی معمای حدس کلمه", MessageBoxButtons.OKCancel);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
