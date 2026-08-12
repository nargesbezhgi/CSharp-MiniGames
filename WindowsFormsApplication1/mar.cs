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
    public partial class mar : Form
    {
        int c;
        Random rnd3 = new Random();
        Form2 frm2 = new Form2();
        public mar()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c = rnd3.Next(9, 15);
            string d = c.ToString() + ".jpg";
            pictureBox1.ImageLocation = d;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void mar_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictore.Left += 57;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictore.Left -= 57;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictore.Top -= 55;
        }

        private void pictore_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictore.Top += 55;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("کاربر گرامی در ابتدا دکمه ی پرتاب تاس را انتخاب کرده و با توجه به ان دکمه های جهتی را فشار دهید اگر در خانه ای بودید نردبان وجود داشت به شما تبریک میگم!باید تا سر نردبان صعود کنید اما اگر سر مار بود خبر بدی دارم!باید تا انتهای دم مار به پایین برگردید و برای خروج از بازی دکمه خروج را انتخاب کنید", "قوانین بازی مار پله", MessageBoxButtons.OKCancel);
        }
    }
}
