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

        public void ReadNumbers(List<VehicleNumbers> numbersList)
        {
            List<string> carlines, trucklines, motocyclelines, bicyclelines;
            using (FileStream carreader = new FileStream(Cars.carsPath, FileMode.Open, FileAccess.Read))
                carlines = File.ReadAllLines(Cars.carsPath).ToList();
            using (FileStream truckreader = new FileStream(Trucks.trucksPath, FileMode.Open, FileAccess.Read))
                trucklines = File.ReadAllLines(Trucks.trucksPath).ToList();
            using (FileStream motocyclereader = new FileStream(Motocycles.motocyclesPath, FileMode.Open, FileAccess.Read))
                motocyclelines = File.ReadAllLines(Motocycles.motocyclesPath).ToList();
            using (FileStream bicyclereader = new FileStream(Bicycles.bicyclesPath, FileMode.Open, FileAccess.Read))
                bicyclelines = File.ReadAllLines(Bicycles.bicyclesPath).ToList();

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
        

        /*public void ShowNumbers()
        {
            foreach (var number in numbersList)
                Console.WriteLine($"Number: {number.Number}");
        }*/
    }
}
