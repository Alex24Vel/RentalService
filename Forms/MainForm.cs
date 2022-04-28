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

        private void renter_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrdersForm ordersForm = new OrdersForm();
            ordersForm.Show();
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

        //private void MainForm_Load(object sender, EventArgs e) { }
    }
}
