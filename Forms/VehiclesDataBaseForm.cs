using System;
using System.Windows.Forms;

namespace Forms
{
    public partial class VehiclesDataBaseForm : Form
    {
        public VehiclesDataBaseForm()
        {
            InitializeComponent();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
        private void cars_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarsDataBase carsDataBase = new CarsDataBase();
            carsDataBase.Show();
        }
        private void trucks_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrucksDataBase trucksDataBase = new TrucksDataBase();
            trucksDataBase.Show();
        }
        private void motocycles_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MotocyclesDataBase motocyclesDataBase = new MotocyclesDataBase();
            motocyclesDataBase.Show();
        }
        private void bicycles_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            BicyclesDataBase bicyclesDataBase = new BicyclesDataBase();
            bicyclesDataBase.Show();
        }
    }
}
