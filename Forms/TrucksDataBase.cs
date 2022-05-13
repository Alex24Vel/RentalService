using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentalServiceLib;
using System.Diagnostics;

namespace Forms
{
    public partial class TrucksDataBase : Form
    {
        public TrucksDataBase()
        {
            InitializeComponent();
        }
        internal List<Trucks> truckslist = new List<Trucks>();
        private void TrucksDataBase_Load(object sender, EventArgs e)
        {
            Trucks trucks = new Trucks();
            trucks.getData(truckslist);
            number_comboBox.DataSource = truckslist;
        }
        readonly string TrucksPath = @"T:\Microsoft Visual Studio\Projects\Trucks.txt";

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
            VehiclesDataBaseForm vehiclesDataBaseForm = new VehiclesDataBaseForm();
            vehiclesDataBaseForm.Show();
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            trucks_dataGridView.DataSource = truckslist;
            trucks_dataGridView.Update();
        }

        private void clearDataBase_button_Click(object sender, EventArgs e)
        {
            List<Trucks> tmp = new List<Trucks>();
            trucks_dataGridView.DataSource = tmp;
            trucks_dataGridView.Update();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            clearDataBase_button_Click(sender, e);
            trucks_dataGridView.Update();
            load_button_Click(sender, e);
        }

        private void trucksExplorer_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "explorer", Arguments = $"/n,/select,{TrucksPath}" });
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Trucks truck = new Trucks();
            truck.Make = make_textBox.Text;
            truck.Model = model_textBox.Text;
            truck.Year = year_textBox.Text.ToString();
            truck.PricePerDay = pricePerDay_textBox.Text.ToString();
            truck.TruckType = truckType_textBox.Text;
            truck.Number = number_comboBox.Text.ToString();
            truckslist.Add(truck);

            string fileStr = $"{truck.Make},{truck.Model},{truck.Year}," +
                $"{truck.PricePerDay},{truck.TruckType},{truck.Number}";
            using (StreamWriter writer = new StreamWriter(TrucksPath, true))
                writer.WriteLine(fileStr);
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            make_textBox.Clear();
            model_textBox.Clear();
            year_textBox.Clear();
            pricePerDay_textBox.Clear();
            truckType_textBox.Clear();
            number_comboBox.ResetText();
        }
    }
}
