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

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
        private void Cars_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarsDataBase carsDataBase = new CarsDataBase();
            carsDataBase.Show();
        }
        private void Trucks_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrucksDataBase trucksDataBase = new TrucksDataBase();
            trucksDataBase.Show();
        }
        private void Motocycles_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MotocyclesDataBase motocyclesDataBase = new MotocyclesDataBase();
            motocyclesDataBase.Show();
        }
        private void Bicycles_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            BicyclesDataBase bicyclesDataBase = new BicyclesDataBase();
            bicyclesDataBase.Show();
        }
    }
}
