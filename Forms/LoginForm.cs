using System;
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

        private void password_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                login_button_Click(sender, e);
            if (e.KeyCode == Keys.Up)
                username_textBox.Focus();
        }
        private void username_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                password_textBox.Focus();
        }
    }
}
