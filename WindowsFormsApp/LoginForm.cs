using System;
using System.IO;
using System.Windows.Forms;
using ClassLibrary;

namespace WindowsFormsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (CheckCredentials(username, password))
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Geçersiz kullanıcı adı veya şifre.");
            }
        }

        private bool CheckCredentials(string username, string password)
        {
            foreach (var line in File.ReadAllLines("users.txt"))
            {
                var parts = line.Split(',');
                if (parts[0] == username && parts[1] == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
