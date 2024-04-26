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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var mavjudHisob = new Form1();
            mavjudHisob.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string firstName = textBox2.Text;
            string password = textBox4.Text;
            string confirmPassword =textBox3.Text;

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Iltimos, to'g'ri e-mail manzilini kiriting.", "Xatolik", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Iltimos, parolni kiriting.", "Xatolik", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Parollar mos kelmaydi. Iltimos, qayta kiriting.", "Xatolik", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Ro'yxatdan o'tish muvaffaqiyatli amalga oshirildi.", "Muvaffaqiyat", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var mavjudHisob = new Form1();
            mavjudHisob.Show();
            this.Hide();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var mavjudHisob = new Form1();
            mavjudHisob.Show();
            this.Hide();
        }
    }
}
