using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using RentalServiceLib;
using System.Diagnostics;

namespace Forms
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        internal List<Orders> ordersList = new List<Orders>();
        internal List<VehicleNumbers> numsList = new List<VehicleNumbers>();

        private void Add_button_Click(object sender, EventArgs e)
        {
            if (renter_textBox.TextLength <= 1 || rentDate_textBox.TextLength <= 1 || dueDate_textBox.TextLength <= 1)
                MessageBox.Show("Fill in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Orders order = new Orders();
                order.Renter = renter_textBox.Text;
                order.Vehicle = vehicles_comboBox.Text;
                order.VehicleNumber = vehicleNumbers_comboBox.Text;
                order.RentDate = rentDate_textBox.Text.ToString();
                order.DueDate = dueDate_textBox.Text.ToString();
                ordersList.Add(order);

                string fileStr = $"{order.Renter},{order.Vehicle},{order.VehicleNumber}," +
                    $"{order.RentDate},{order.DueDate}";
                using (StreamWriter writer = new StreamWriter(Orders.ordersPath, true))
                    writer.WriteLine(fileStr);
            }
        }
        private void Clear_button_Click(object sender, EventArgs e)
        {
            renter_textBox.Clear();
            vehicles_comboBox.ResetText();

            vehicleNumbers_comboBox.ResetText();
            numsList.Clear();
            vehicleNumbers_comboBox.DataSource = numsList.Distinct().ToList();

            rentDate_textBox.Clear();
            dueDate_textBox.Clear();
        }
        private void Vehicles_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            VehicleNumbers numbers = new VehicleNumbers();
            numbers.ReadNumbers(numsList);
            numsList = numsList.Where(x => x.Number.Contains(vehicles_comboBox.Text.Substring(0, 1))).ToList();

            List<Orders> tmp = new List<Orders>();
            Orders orders = new Orders();
            orders.GetData(tmp);
            try
            {
                for (int i = 0; i < numsList.Count; i++)
                    for (int j = 0; j < tmp.Count; j++)
                        if (numsList[i].Number.Equals(tmp[j].VehicleNumber))
                            numsList.Remove(numsList[i]);
            }
            catch (ArgumentOutOfRangeException) { vehicleNumbers_comboBox.Text = $"No {vehicles_comboBox.Text}s available"; }
            finally { vehicleNumbers_comboBox.DataSource = numsList; }
        }

        private void ShowBy_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Orders> tmpSource = new List<Orders>();
            Orders tmp = new Orders();
            tmp.GetData(tmpSource);
            tmpSource = tmpSource.Where(x => x.Vehicle == showBy_comboBox.Text).ToList();
            orders_dataGridView.DataSource = tmpSource;
        }

        private void Load_button_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.GetData(ordersList);
            orders_dataGridView.DataSource = ordersList;
        }
        private void ClearDataBase_button_Click(object sender, EventArgs e)
        {
            ordersList.Clear();
            showBy_comboBox.ResetText();
            orders_dataGridView.DataSource = ordersList.Distinct();
        }
        private void Update_button_Click(object sender, EventArgs e)
        {
            ClearDataBase_button_Click(sender, e);
            orders_dataGridView.Update();
            Load_button_Click(sender, e);
        }
        private void OrdersExplorer_button_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "explorer", Arguments = $"/n,/select,{Orders.ordersPath}" });
        }
        private void Delete_button_Click(object sender, EventArgs e)
        {
            List<string> tmp = File.ReadAllLines(Orders.ordersPath).ToList();
            tmp.RemoveAt(orders_dataGridView.CurrentCell.RowIndex);
            File.WriteAllLines(Orders.ordersPath, tmp.ToArray());
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
