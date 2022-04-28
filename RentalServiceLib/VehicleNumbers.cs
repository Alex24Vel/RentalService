using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace RentalServiceLib
{
    public class VehicleNumbers
    {

        public string Number { get; set; }

        public List<VehicleNumbers> numbersList;
        readonly string carsPath = @"T:\Microsoft Visual Studio\Projects\Cars.txt";
        readonly string trucksPath = @"T:\Microsoft Visual Studio\Projects\Trucks.txt";
        readonly string motocyclesPath = @"T:\Microsoft Visual Studio\Projects\Motocycles.txt";
        readonly string bicyclesPath = @"T:\Microsoft Visual Studio\Projects\Bicycles.txt";

        public void ReadNumbers(List<VehicleNumbers> numbersList)
        {
            List<string> carlines, trucklines, motocyclelines, bicyclelines;
            using (FileStream carreader = new FileStream(carsPath, FileMode.Open, FileAccess.Read))
                carlines = File.ReadAllLines(carsPath).ToList();
            using (FileStream truckreader = new FileStream(trucksPath, FileMode.Open, FileAccess.Read))
                trucklines = File.ReadAllLines(trucksPath).ToList();
            using (FileStream motocyclereader = new FileStream(motocyclesPath, FileMode.Open, FileAccess.Read))
                motocyclelines = File.ReadAllLines(motocyclesPath).ToList();
            using (FileStream bicyclereader = new FileStream(bicyclesPath, FileMode.Open, FileAccess.Read))
                bicyclelines = File.ReadAllLines(bicyclesPath).ToList();

            foreach (var line in carlines)
            {
                string[] entries = line.Split(',');
                VehicleNumbers number = new VehicleNumbers();
                number.Number = entries[5];
                numbersList.Add(number);
            }
            foreach (var line in trucklines)
            {
                string[] entries = line.Split(',');
                VehicleNumbers number = new VehicleNumbers();
                number.Number = entries[5];
                numbersList.Add(number);
            }
            foreach (var line in motocyclelines)
            {
                string[] entries = line.Split(',');
                VehicleNumbers number = new VehicleNumbers();
                number.Number = entries[4];
                numbersList.Add(number);
            }
            foreach (var line in bicyclelines)
            {
                string[] entries = line.Split(',');
                VehicleNumbers number = new VehicleNumbers();
                number.Number = entries[4];
                numbersList.Add(number);
            }
        }
        
        public void ShowNumbers()
        {
            foreach (var number in numbersList)
                Console.WriteLine($"Number: {number.Number}");
        }
    }
}
