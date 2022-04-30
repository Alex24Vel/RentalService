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

// todo 1) Fix bug with vehicles_comboBox_SelectedIndexChanged (shows used numbers after a while (not critical, hard to notice)

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
        readonly string ordersPath = @"T:\Microsoft Visual Studio\Projects\Orders.txt";

        
        private void add_button_Click(object sender, EventArgs e)
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
                using (StreamWriter writer = new StreamWriter(ordersPath, true))
                    writer.WriteLine(fileStr);
            }
        }
        private void clear_button_Click(object sender, EventArgs e)
        {
            renter_textBox.Clear();
            vehicles_comboBox.ResetText();
            
            vehicleNumbers_comboBox.ResetText();
            numsList.Clear();
            vehicleNumbers_comboBox.DataSource = numsList.Distinct().ToList();
            
            rentDate_textBox.Clear();
            dueDate_textBox.Clear();
        }
        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }


        private void load_button_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.getData(ordersList);
            orders_dataGridView.DataSource = ordersList;
        }
        private void clearDataBase_button_Click(object sender, EventArgs e)
        {
            ordersList.Clear();
            showBy_comboBox.ResetText();
            orders_dataGridView.DataSource = ordersList.Distinct();
        }
        private void update_button_Click(object sender, EventArgs e)
        {
            clearDataBase_button_Click(sender, e);
            orders_dataGridView.Update();
            load_button_Click(sender, e);
        }
        private void ordersExplorer_button_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "explorer", Arguments = $"/n,/select,{ordersPath}" });
        }


        private void showBy_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Orders> tmpSource = new List<Orders>();
            Orders tmp = new Orders();
            tmp.getData(tmpSource);
            tmpSource = tmpSource.Where(x => x.Vehicle == showBy_comboBox.Text).ToList();
            orders_dataGridView.DataSource = tmpSource;
        }
        private void vehicles_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            VehicleNumbers numbers = new VehicleNumbers();
            numbers.ReadNumbers(numsList);
            
            List<Orders> tmp = new List<Orders>(); 
            Orders orders = new Orders();          
            orders.getData(tmp);
            
            for(int i = 0; i < numsList.Count; i++)
                for(int j = 0; j < tmp.Count; j++)
                    if (numsList[i].Number.Equals(tmp[j].VehicleNumber))
                        numsList.Remove(numsList[i]);

            numsList = numsList.Where(x => x.Number.Contains(vehicles_comboBox.Text.Substring(0, 1))).ToList();
            vehicleNumbers_comboBox.DataSource = numsList;
        }
    }
}
