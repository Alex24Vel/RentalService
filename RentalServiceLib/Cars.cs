using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalServiceLib
{
    public class Cars : IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string PricePerDay { get; set; }
        public string Number { get; set; }

        public string CarType { get; set; }

        public List<Cars> Carslist = new List<Cars>();
        public string carsPath = @"T:\Microsoft Visual Studio\Projects\Cars.txt";

        public void getData(List<Cars> Carslist) 
        {
            try
            {
                List<string> lines;
                using (FileStream reader = new FileStream(carsPath, FileMode.Open, FileAccess.Read))
                    lines = File.ReadAllLines(carsPath).ToList();
                foreach (var line in lines)
                {
                    string[] entries = line.Split(',');
                    Cars car = new Cars();
                    car.Make = entries[0];
                    car.Model = entries[1];
                    car.Year = entries[2];
                    car.PricePerDay = entries[3];
                    car.CarType = entries[4];
                    car.Number = entries[5];
                    Carslist.Add(car);
                }
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine($"Couldn't find the file: {carsPath} !");
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Invalid directory in the file path!");
            }
            catch (IOException)
            {
                Console.Error.WriteLine($"Couldn't open the file: {carsPath} !");
            }
        }

        // for tester (console only)
        public void showData()
        {
            foreach (var car in Carslist)
                Console.WriteLine($"Make: {car.Make} Model: {car.Model} Year: {car.Year} " +
                    $"Price per day: {car.PricePerDay} Number: {car.Number}");
        }
    }
}
