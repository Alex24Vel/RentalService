using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if(password_textBox.Text == "admin")
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid password!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                password_textBox.Clear();
                password_textBox.Focus();
            }

        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            username_textBox.Clear();
            password_textBox.Clear();
        }

    }
}
