using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RentalServiceLib;
using System.Diagnostics;

namespace Forms
{
    public partial class BicyclesDataBase : Form
    {
        public BicyclesDataBase()
        {
            InitializeComponent();
        }
        internal List<Bicycles> bicycleslist = new List<Bicycles>();
        readonly public string bicyclesPath = @"T:\Microsoft Visual Studio\Projects\Bicycles.txt";

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
            VehiclesDataBaseForm vehiclesDataBaseForm = new VehiclesDataBaseForm();
            vehiclesDataBaseForm.Show();
        }
        private void load_button_Click(object sender, EventArgs e)
        {
            Bicycles bicycles = new Bicycles();
            bicycles.getData(bicycleslist);
            bicycles_dataGridView.DataSource = bicycleslist;
        }
        private void clearDataBase_button_Click(object sender, EventArgs e)
        {
            bicycleslist.Clear();
            bicycles_dataGridView.DataSource = bicycleslist.Distinct();
        }
        private void update_button_Click(object sender, EventArgs e)
        {
            clearDataBase_button_Click(sender, e);
            bicycles_dataGridView.Update();
            load_button_Click(sender, e);
        }
        private void bicyclesExplorer_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "explorer", Arguments = $"/n,/select,{bicyclesPath}" });
        }
        private void delete_button_Click(object sender, EventArgs e)
        {
            List<string> tmp = File.ReadAllLines(bicyclesPath).ToList();
            tmp.RemoveAt(bicycles_dataGridView.CurrentCell.RowIndex);
            File.WriteAllLines(bicyclesPath, tmp.ToArray());
        }


        private void add_button_Click(object sender, EventArgs e)
        {
            Bicycles bicycle = new Bicycles
            {
                Make = make_textBox.Text,
                Model = model_textBox.Text,
                Year = year_textBox.Text,
                PricePerDay = pricePerDay_textBox.Text,
                Number = number_textBox.Text
            };
            bicycleslist.Add(bicycle);

            string fileStr = $"{bicycle.Make},{bicycle.Model},{bicycle.Year}," +
                $"{bicycle.PricePerDay},{bicycle.Number}";
            using (StreamWriter writer = new StreamWriter(bicyclesPath, true))
                writer.WriteLine(fileStr);
        }
        private void clear_button_Click(object sender, EventArgs e)
        {
            make_textBox.Clear();
            model_textBox.Clear();
            year_textBox.Clear();
            pricePerDay_textBox.Clear();
            number_textBox.Clear();
        }

    }
}
