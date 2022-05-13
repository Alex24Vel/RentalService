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
    public partial class CarsDataBase : Form
    {
        public CarsDataBase()
        {
            InitializeComponent();
        }
        internal List<Cars> Carslist = new List<Cars>();
        readonly string carsPath = @"T:\Microsoft Visual Studio\Projects\Cars.txt";


        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
            VehiclesDataBaseForm vehiclesDataBaseForm = new VehiclesDataBaseForm();
            vehiclesDataBaseForm.Show();
        }
        private void load_button_Click(object sender, EventArgs e)
        {
            Cars cars = new Cars();
            cars.getData(Carslist);
            cars_dataGridView.DataSource = Carslist;
        }
        private void clearDataBase_button_Click(object sender, EventArgs e)
        {
            Carslist.Clear();
            cars_dataGridView.DataSource = Carslist.Distinct();
        }
        private void update_button_Click(object sender, EventArgs e)
        {
            clearDataBase_button_Click(sender, e);
            cars_dataGridView.Update();
            load_button_Click(sender, e);
        }
        private void carsExplorer_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "explorer", Arguments = $"/n,/select,{carsPath}" });
        }
        private void delete_button_Click(object sender, EventArgs e)
        {
            List<string> tmp = File.ReadAllLines(carsPath).ToList();
            tmp.RemoveAt(cars_dataGridView.CurrentCell.RowIndex);
            File.WriteAllLines(carsPath, tmp.ToArray());
        }


        private void add_button_Click(object sender, EventArgs e)
        {
            Cars car = new Cars();
            car.Make = make_textBox.Text;
            car.Model = model_textBox.Text;
            car.Year = year_textBox.Text.ToString();
            car.PricePerDay = pricePerDay_textBox.Text.ToString();
            car.CarType = carType_textBox.Text;
            car.Number = number_textBox.Text;
            Carslist.Add(car);

            string fileStr = $"{car.Make},{car.Model},{car.Year}," +
                $"{car.PricePerDay},{car.CarType},{car.Number}";
            using (StreamWriter writer = new StreamWriter(carsPath, true))
                writer.WriteLine(fileStr);
        }
        private void clear_button_Click(object sender, EventArgs e)
        {
            make_textBox.Clear();
            model_textBox.Clear();
            year_textBox.Clear();
            pricePerDay_textBox.Clear();
            carType_textBox.Clear();
            number_textBox.Clear();
        }

    }
}
