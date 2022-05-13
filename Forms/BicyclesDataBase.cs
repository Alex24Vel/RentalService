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
    public partial class BicyclesDataBase : Form
    {
        public BicyclesDataBase()
        {
            InitializeComponent();
        }
        internal List<Bicycles> bicycleslist = new List<Bicycles>();
        private void BicyclesDataBase_Load(object sender, EventArgs e)
        {
            Bicycles bicycles = new Bicycles();
            bicycles.getData(bicycleslist);
            number_comboBox.DataSource = bicycleslist;
        }
        readonly public string bicyclesPath = @"T:\Microsoft Visual Studio\Projects\Bicycles.txt";


        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
            VehiclesDataBaseForm vehiclesDataBaseForm = new VehiclesDataBaseForm();
            vehiclesDataBaseForm.Show();
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            bicycles_dataGridView.DataSource = bicycleslist;
            bicycles_dataGridView.Update();

        }
        private void clearDataBase_button_Click(object sender, EventArgs e)
        {
            List<Bicycles> tmp = new List<Bicycles>();
            bicycles_dataGridView.DataSource = tmp;
            bicycles_dataGridView.Update();
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


        private void add_button_Click(object sender, EventArgs e)
        {
            Bicycles bicycle = new Bicycles();
            bicycle.Make = make_textBox.Text;
            bicycle.Model = model_textBox.Text;
            bicycle.Year = year_textBox.Text.ToString();
            bicycle.PricePerDay = pricePerDay_textBox.Text.ToString();
            bicycle.Number = number_comboBox.Text.ToString();
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
            number_comboBox.ResetText();
        }

    }
}
