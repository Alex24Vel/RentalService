using System;
using System.Windows.Forms;

namespace Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitMain_button_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
        private void Orders_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrdersForm ordersForm = new OrdersForm();
            ordersForm.Show();
        }
        private void Database_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            VehiclesDataBaseForm dataBaseForm = new VehiclesDataBaseForm();
            dataBaseForm.Show();
        }

    }
}
