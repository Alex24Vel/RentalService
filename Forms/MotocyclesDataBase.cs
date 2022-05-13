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
    public partial class MotocyclesDataBase : Form
    {
        public MotocyclesDataBase()
        {
            InitializeComponent();
        }
        internal List<Motocycles> Motocycleslist = new List<Motocycles>();
        readonly string MotocyclesPath = @"T:\Microsoft Visual Studio\Projects\Motocycles.txt";

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
            VehiclesDataBaseForm vehiclesDataBaseForm = new VehiclesDataBaseForm();
            vehiclesDataBaseForm.Show();
        }
        private void load_button_Click(object sender, EventArgs e)
        {
            Motocycles motocycles = new Motocycles();
            motocycles.getData(Motocycleslist);
            motocycles_dataGridView.DataSource = Motocycleslist;
        }
        private void clearDataBase_button_Click(object sender, EventArgs e)
        {
            Motocycleslist.Clear();
            motocycles_dataGridView.DataSource = Motocycleslist.Distinct();
        }
        private void update_button_Click(object sender, EventArgs e)
        {
            clearDataBase_button_Click(sender, e);
            motocycles_dataGridView.Update();
            load_button_Click(sender, e);
        }
        private void motocyclesExplorer_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "explorer", Arguments = $"/n,/select,{MotocyclesPath}" });
        }
        private void delete_button_Click(object sender, EventArgs e)
        {
            List<string> tmp = File.ReadAllLines(MotocyclesPath).ToList();
            tmp.RemoveAt(motocycles_dataGridView.CurrentCell.RowIndex);
            File.WriteAllLines(MotocyclesPath, tmp.ToArray());
        }


        private void add_button_Click(object sender, EventArgs e)
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
            using (StreamWriter writer = new StreamWriter(MotocyclesPath, true))
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
