using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
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


        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
            VehiclesDataBaseForm vehiclesDataBaseForm = new VehiclesDataBaseForm();
            vehiclesDataBaseForm.Show();
        }
        private void Load_button_Click(object sender, EventArgs e)
        {
            Trucks trucks = new Trucks();
            trucks.GetData(truckslist);
            trucks_dataGridView.DataSource = truckslist;
        }
        private void ClearDataBase_button_Click(object sender, EventArgs e)
        {
            truckslist.Clear();
            trucks_dataGridView.DataSource = truckslist.Distinct();
        }
        private void Update_button_Click(object sender, EventArgs e)
        {
            ClearDataBase_button_Click(sender, e);
            trucks_dataGridView.Update();
            Load_button_Click(sender, e);
        }
        private void TrucksExplorer_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "explorer", Arguments = $"/n,/select,{Trucks.trucksPath}" });
        }
        private void Delete_button_Click(object sender, EventArgs e)
        {
            List<string> tmp = File.ReadAllLines(Trucks.trucksPath).ToList();
            tmp.RemoveAt(trucks_dataGridView.CurrentCell.RowIndex);
            File.WriteAllLines(Trucks.trucksPath, tmp.ToArray());
        }


        private void Add_button_Click(object sender, EventArgs e)
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
            using (StreamWriter writer = new StreamWriter(Trucks.trucksPath, true))
                writer.WriteLine(fileStr);
        }
        private void Clear_button_Click(object sender, EventArgs e)
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
