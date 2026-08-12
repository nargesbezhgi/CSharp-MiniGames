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
    public partial class Form4 : Form
    {
        int min = 100;
        int emtiaz = 0;
        int a;
        Random rnd5 = new Random();
        public Form4()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true && a == 15)
            {
                emtiaz += 1;
                label10.Text = emtiaz.ToString();
                MessageBox.Show("پاسخ شما صحیح است", "آفرین", MessageBoxButtons.OKCancel);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            min -= 1; ;
            label11.Text = min.ToString();
            if (min <= 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("زمان شما به اتمام رسید", "خطا", MessageBoxButtons.OKCancel);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = rnd5.Next(15, 24);
            string b = a.ToString() + ".jpg";
            pictureBox1.ImageLocation = b;
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
            switch (a)
            {
                case 15:
                    MessageBox.Show("پاسخ صحیح:انیمیشن اژدها سواران", "پاسخ صحیح", MessageBoxButtons.OKCancel);
                    break;
                case 16:
                    MessageBox.Show("پاسخ صحیح:انیمیشن سیندرلا", "پاسخ صحیح", MessageBoxButtons.OKCancel);
                    break;
                case 17:
                    MessageBox.Show("پاسخ صحیح:انیمیشن فروزن", "پاسخ صحیح", MessageBoxButtons.OKCancel);
                    break;
                case 18:
                    MessageBox.Show("پاسخ صحیح:انیمیشن دلیر", "پاسخ صحیح", MessageBoxButtons.OKCancel);
                    break;
                case 19:
                    MessageBox.Show("پاسخ صحیح:انیمیشن مولان", "پاسخ صحیح", MessageBoxButtons.OKCancel);
                    break;
                case 20:
                    MessageBox.Show("پاسخ صحیح:انیمیشن اسباب بازیها", "پاسخ صحیح", MessageBoxButtons.OKCancel);
                    break;
                case 21:
                    MessageBox.Show("پاسخ صحیح:انیمیشن گیسو کمند", "پاسخ صحیح", MessageBoxButtons.OKCancel);
                    break;
                case 22:
                    MessageBox.Show("پاسخ صحیح:انیمیشن ریو", "پاسخ صحیح", MessageBoxButtons.OKCancel);
                    break;
                case 23:
                    MessageBox.Show("پاسخ صحیح:انیمیشن سفید برفی", "پاسخ صحیح", MessageBoxButtons.OKCancel);
                    break;

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            checkBox1.Checked = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            checkBox2.Checked = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            checkBox3.Checked = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            checkBox4.Checked = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            checkBox5.Checked = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            checkBox6.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            checkBox7.Checked = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            checkBox8.Checked = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            label9.Visible = false;
            checkBox9.Checked = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = !checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = !checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = !checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = !checkBox4.Checked;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = !checkBox5.Checked;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            label8.Visible = !checkBox6.Checked;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = !checkBox7.Checked;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            label7.Visible = !checkBox8.Checked;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            label9.Visible = !checkBox9.Checked;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true && a == 16)
            {
                emtiaz += 1;
                label10.Text = emtiaz.ToString();
                MessageBox.Show("پاسخ شما صحیح است", "آفرین", MessageBoxButtons.OKCancel);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true && a == 23)
            {
                emtiaz += 1;
                label10.Text = emtiaz.ToString();
                MessageBox.Show("پاسخ شما صحیح است", "آفرین", MessageBoxButtons.OKCancel);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true && a == 21)
            {
                emtiaz += 1;
                label10.Text = emtiaz.ToString();
                MessageBox.Show("پاسخ شما صحیح است", "آفرین", MessageBoxButtons.OKCancel);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true && a == 22)
            {
                emtiaz += 1;
                label10.Text = emtiaz.ToString();
                MessageBox.Show("پاسخ شما صحیح است", "آفرین", MessageBoxButtons.OKCancel);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true && a == 18)
            {
                emtiaz += 1;
                label10.Text = emtiaz.ToString();
                MessageBox.Show("پاسخ شما صحیح است", "آفرین", MessageBoxButtons.OKCancel);
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true && a == 20)
            {
                emtiaz += 1;
                label10.Text = emtiaz.ToString();
                MessageBox.Show("پاسخ شما صحیح است", "آفرین", MessageBoxButtons.OKCancel);
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true && a == 17)
            {
                emtiaz += 1;
                label10.Text = emtiaz.ToString();
                MessageBox.Show("پاسخ شما صحیح است", "آفرین", MessageBoxButtons.OKCancel);
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true && a == 19)
            {
                emtiaz += 1;
                label10.Text = emtiaz.ToString();
                MessageBox.Show("پاسخ شما صحیح است", "آفرین", MessageBoxButtons.OKCancel);
            }
        }
    }
}
