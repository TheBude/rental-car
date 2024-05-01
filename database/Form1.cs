using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string login = textBox2.Text;
            string password = textBox1.Text;

            if(login == "thebude" && password == "12345")
            {
                MessageBox.Show("Muvfoqiyatli Kirildi!");
                var newForm = new Form2();
                newForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login yoki Parol Xato\nIltimos qaytadan o'rinib ko'ring", "Xatolik", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var newWindow = new Form3();
            newWindow.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
