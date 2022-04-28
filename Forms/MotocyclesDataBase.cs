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
        private void MotocyclesDataBase_Load(object sender, EventArgs e)
        {
            Motocycles motocycles = new Motocycles();
            motocycles.getData(Motocycleslist);
            number_comboBox.DataSource = Motocycleslist;
        }
        readonly string MotocyclesPath = @"T:\Microsoft Visual Studio\Projects\Motocycles.txt";

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
            VehiclesDataBaseForm vehiclesDataBaseForm = new VehiclesDataBaseForm();
            vehiclesDataBaseForm.Show();
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            motocycles_dataGridView.DataSource = Motocycleslist;
            motocycles_dataGridView.Update();
        }

        private void clearDataBase_button_Click(object sender, EventArgs e)
        {
            List<Motocycles> tmp = new List<Motocycles>();
            motocycles_dataGridView.DataSource = tmp;
            motocycles_dataGridView.Update();
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


        private void add_button_Click(object sender, EventArgs e)
        {
            Motocycles motocycle = new Motocycles();
            motocycle.Make = make_textBox.Text;
            motocycle.Model = model_textBox.Text;
            motocycle.Year = Convert.ToInt32(year_textBox.Text.ToString());
            motocycle.PricePerDay = pricePerDay_textBox.Text.ToString();
            motocycle.Number = number_comboBox.Text.ToString();
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
            number_comboBox.ResetText();
        }

    }
}
