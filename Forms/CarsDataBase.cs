using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
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
        

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
            VehiclesDataBaseForm vehiclesDataBaseForm = new VehiclesDataBaseForm();
            vehiclesDataBaseForm.Show();
        }
        private void Load_button_Click(object sender, EventArgs e)
        {
            Cars cars = new Cars();
            cars.GetData(Carslist);
            cars_dataGridView.DataSource = Carslist;
        }
        private void ClearDataBase_button_Click(object sender, EventArgs e)
        {
            Carslist.Clear();
            cars_dataGridView.DataSource = Carslist.Distinct();
        }
        private void Update_button_Click(object sender, EventArgs e)
        {
            ClearDataBase_button_Click(sender, e);
            cars_dataGridView.Update();
            Load_button_Click(sender, e);
        }
        private void CarsExplorer_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "explorer", Arguments = $"/n,/select,{Cars.carsPath}" });
        }
        private void Delete_button_Click(object sender, EventArgs e)
        {
            List<string> tmp = File.ReadAllLines(Cars.carsPath).ToList();
            tmp.RemoveAt(cars_dataGridView.CurrentCell.RowIndex);
            File.WriteAllLines(Cars.carsPath, tmp.ToArray());
        }


        private void Add_button_Click(object sender, EventArgs e)
        {
            if (make_textBox.TextLength <= 1 || model_textBox.TextLength <= 1 || year_textBox.TextLength <= 1 ||
                pricePerDay_textBox.TextLength <= 1 || year_textBox.TextLength <= 1 || number_textBox.TextLength <= 1
                || carType_textBox.TextLength <=1)
                MessageBox.Show("Fill in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Cars car = new Cars
                {
                    Make = make_textBox.Text,
                    Model = model_textBox.Text,
                    Year = year_textBox.Text.ToString(),
                    PricePerDay = pricePerDay_textBox.Text.ToString(),
                    CarType = carType_textBox.Text,
                    Number = number_textBox.Text
                };
                Carslist.Add(car);

                string fileStr = $"{car.Make},{car.Model},{car.Year}," +
                    $"{car.PricePerDay},{car.CarType},{car.Number}";
                using (StreamWriter writer = new StreamWriter(Cars.carsPath, true))
                    writer.WriteLine(fileStr);
            }
        }
        private void Clear_button_Click(object sender, EventArgs e)
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
