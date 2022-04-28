using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalServiceLib
{
    public class Orders
    {
        public string Renter { get; set; }
        public string Vehicle { get; set; }
        public string VehicleNumber { get; set; }
        public string RentDate { get; set; }
        public string DueDate { get; set; }

        public List<Orders> ordersList = new List<Orders>();
        public string ordersPath = @"T:\Microsoft Visual Studio\Projects\Orders.txt";

        public void getData(List<Orders> ordersList)
        {
            try
            {
                List<string> lines;
                using (FileStream reader = new FileStream(ordersPath, FileMode.Open, FileAccess.Read))
                    lines = File.ReadAllLines(ordersPath).ToList();
                foreach (var line in lines)
                {
                    string[] entries = line.Split(',');
                    Orders order = new Orders();
                    order.Renter = entries[0];
                    order.Vehicle = entries[1];
                    order.VehicleNumber = entries[2];
                    order.RentDate = entries[3];
                    order.DueDate = entries[4];
                    ordersList.Add(order);
                }
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine($"Couldn't find file file: {ordersPath} !");
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Invalid directory in the file path!");
            }
            catch (IOException)
            {
                Console.Error.WriteLine($"Couldn't open the file: {ordersPath} !");
            }
        }
        
        // for tester (console only)
        public void showData()
        {
            foreach (var order in ordersList)
            {
                Console.WriteLine($"Renter: {order.Renter} Vehicle: {order.Vehicle} " +
                    $"Vehicle Number: {order.VehicleNumber} Rent date: {order.RentDate} " +
                    $"Due date: {order.DueDate}");
            }
        }

    }
}
