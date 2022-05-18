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

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
            VehiclesDataBaseForm vehiclesDataBaseForm = new VehiclesDataBaseForm();
            vehiclesDataBaseForm.Show();
        }
        private void Load_button_Click(object sender, EventArgs e)
        {
            Bicycles bicycles = new Bicycles();
            bicycles.GetData(bicycleslist);
            bicycles_dataGridView.DataSource = bicycleslist;
        }
        private void ClearDataBase_button_Click(object sender, EventArgs e)
        {
            bicycleslist.Clear();
            bicycles_dataGridView.DataSource = bicycleslist.Distinct();
        }
        private void Update_button_Click(object sender, EventArgs e)
        {
            ClearDataBase_button_Click(sender, e);
            bicycles_dataGridView.Update();
            Load_button_Click(sender, e);
        }
        private void BicyclesExplorer_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "explorer", Arguments = $"/n,/select,{Bicycles.bicyclesPath}" });
        }
        private void Delete_button_Click(object sender, EventArgs e)
        {
            List<string> tmp = File.ReadAllLines(Bicycles.bicyclesPath).ToList();
            tmp.RemoveAt(bicycles_dataGridView.CurrentCell.RowIndex);
            File.WriteAllLines(Bicycles.bicyclesPath, tmp.ToArray());
        }


        private void Add_button_Click(object sender, EventArgs e)
        {
            if (make_textBox.TextLength <= 1 || model_textBox.TextLength <= 1 || year_textBox.TextLength <= 1 ||
                pricePerDay_textBox.TextLength <= 1 || year_textBox.TextLength <= 1 || number_textBox.TextLength <= 1)
                MessageBox.Show("Fill in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
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
                using (StreamWriter writer = new StreamWriter(Bicycles.bicyclesPath, true))
                    writer.WriteLine(fileStr);
            }
        }
        private void Clear_button_Click(object sender, EventArgs e)
        {
            make_textBox.Clear();
            model_textBox.Clear();
            year_textBox.Clear();
            pricePerDay_textBox.Clear();
            number_textBox.Clear();
        }

    }
}
