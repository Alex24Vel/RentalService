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

        private void exitMain_button_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
        private void orders_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrdersForm ordersForm = new OrdersForm();
            ordersForm.Show();
        }
        private void database_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            VehiclesDataBaseForm dataBaseForm = new VehiclesDataBaseForm();
            dataBaseForm.Show();
        }

    }
}
