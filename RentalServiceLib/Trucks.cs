using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RentalServiceLib
{
    public class Trucks : IVehicle
    {
        public string trucksPath = @"T:\Microsoft Visual Studio\Projects\Trucks.txt";

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string PricePerDay { get; set; }
        public string Number { get; set; }
        public string TruckType { get; set; }


        public List<Trucks> truckslist = new List<Trucks>();
        public void getData(List<Trucks> truckslist)
        {
            try
            {
                FileStream reader = new FileStream(trucksPath, FileMode.Open, FileAccess.Read);
                List<string> lines = File.ReadAllLines(trucksPath).ToList();
                foreach (var line in lines)
                {
                    string[] entries = line.Split(',');
                    Trucks truck = new Trucks();
                    truck.Make = entries[0];
                    truck.Model = entries[1];
                    truck.Year = Convert.ToInt32(entries[2]);
                    truck.PricePerDay = entries[3];
                    truck.TruckType = entries[4];
                    truck.Number = entries[5];

                    truckslist.Add(truck);
                }
                
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine(
                "Can not find file {0}.", trucksPath);
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine(
                "Invalid directory in the file path.");
            }
            catch (IOException)
            {
                Console.Error.WriteLine(
                "Can not open the file {0}", trucksPath);
            }

        }
        public void showData()
        {
            foreach (var truck in truckslist)
            {
                Console.WriteLine($"Make: {truck.Make} Model: {truck.Model} Year: {truck.Year} " +
                    $"Price per day: {truck.PricePerDay} Truck type: {truck.TruckType} Number: {truck.Number}");
            }
        }
    }

}