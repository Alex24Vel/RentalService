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
using System.Diagnostics;
using RentalServiceLib;

namespace Forms
{
    public partial class TrucksDataBase : Form
    {
        public TrucksDataBase()
        {
            InitializeComponent();
        }
        internal List<Trucks> truckslist = new List<Trucks>();
        readonly string TrucksPath = @"T:\Microsoft Visual Studio\Projects\Trucks.txt";


        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
            VehiclesDataBaseForm vehiclesDataBaseForm = new VehiclesDataBaseForm();
            vehiclesDataBaseForm.Show();
        }
        private void load_button_Click(object sender, EventArgs e)
        {
            Trucks trucks = new Trucks();
            trucks.getData(truckslist);
            trucks_dataGridView.DataSource = truckslist;
        }
        private void clearDataBase_button_Click(object sender, EventArgs e)
        {
            truckslist.Clear();
            trucks_dataGridView.DataSource = truckslist.Distinct();
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
        private void delete_button_Click(object sender, EventArgs e)
        {
            List<string> tmp = File.ReadAllLines(TrucksPath).ToList();
            tmp.RemoveAt(trucks_dataGridView.CurrentCell.RowIndex);
            File.WriteAllLines(TrucksPath, tmp.ToArray());
        }


        private void add_button_Click(object sender, EventArgs e)
        {
            Trucks truck = new Trucks
            {
                Make = make_textBox.Text,
                Model = model_textBox.Text,
                Year = year_textBox.Text,
                PricePerDay = pricePerDay_textBox.Text,
                TruckType = truckType_textBox.Text,
                Number = number_textBox.Text
            };
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
            number_textBox.Clear();
        }
    }
}
