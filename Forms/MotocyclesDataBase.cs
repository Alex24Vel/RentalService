using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RentalServiceLib;
using System.Diagnostics;

namespace Forms
{
    public partial class MotocyclesDataBase : Form
    {
        public MotocyclesDataBase()
        {
            InitializeComponent();
        }
        internal List<Motocycles> Motocycleslist = new List<Motocycles>();

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
            VehiclesDataBaseForm vehiclesDataBaseForm = new VehiclesDataBaseForm();
            vehiclesDataBaseForm.Show();
        }
        private void Load_button_Click(object sender, EventArgs e)
        {
            Motocycles motocycles = new Motocycles();
            motocycles.GetData(Motocycleslist);
            motocycles_dataGridView.DataSource = Motocycleslist;
        }
        private void ClearDataBase_button_Click(object sender, EventArgs e)
        {
            Motocycleslist.Clear();
            motocycles_dataGridView.DataSource = Motocycleslist.Distinct();
        }
        private void Update_button_Click(object sender, EventArgs e)
        {
            ClearDataBase_button_Click(sender, e);
            motocycles_dataGridView.Update();
            Load_button_Click(sender, e);
        }
        private void MotocyclesExplorer_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "explorer", Arguments = $"/n,/select,{Motocycles.motocyclesPath}" });
        }
        private void Delete_button_Click(object sender, EventArgs e)
        {
            List<string> tmp = File.ReadAllLines(Motocycles.motocyclesPath).ToList();
            tmp.RemoveAt(motocycles_dataGridView.CurrentCell.RowIndex);
            File.WriteAllLines(Motocycles.motocyclesPath, tmp.ToArray());
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            Motocycles motocycle = new Motocycles
            {
                Make = make_textBox.Text,
                Model = model_textBox.Text,
                Year = year_textBox.Text,
                PricePerDay = pricePerDay_textBox.Text,
                Number = number_textBox.Text
            };
            Motocycleslist.Add(motocycle);

            string fileStr = $"{motocycle.Make},{motocycle.Model},{motocycle.Year}," +
                $"{motocycle.PricePerDay},{motocycle.Number}";
            using (StreamWriter writer = new StreamWriter(Motocycles.motocyclesPath, true))
                writer.WriteLine(fileStr);
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
