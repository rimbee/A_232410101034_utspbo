using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS_PBO
{
    public partial class Form3 : Form
    {
        private string username;
        private string password;
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Masukkan username dan password");
            }
            else
            {
                var loginSuccess = C_Login.login(username, password);

                if (loginSuccess == 1)
                {
                    MessageBox.Show("Login berhasil!");
                    // Tambahkan logika setelah login berhasil, seperti membuka form baru
                }
                else if (loginSuccess == 0)
                {
                    MessageBox.Show("Username atau password salah!");
                }
            }
        }
    }
}
