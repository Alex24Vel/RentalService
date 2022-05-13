using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalServiceLib
{
    public class Motocycles : IVehicle
    {
        public string motocyclesPath = @"T:\Microsoft Visual Studio\Projects\Motocycles.txt";

        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string PricePerDay { get; set; }
        public string Number { get; set; }

        public List<Motocycles> motocycleslist = new List<Motocycles>();

        public void getData(List<Motocycles> motocycleslist)
        {
            try
            {
                List<string> lines;
                using (FileStream reader = new FileStream(motocyclesPath, FileMode.Open, FileAccess.Read))
                    lines = File.ReadAllLines(motocyclesPath).ToList();
                foreach (var line in lines)
                {
                    string[] entries = line.Split(',');
                    Motocycles motocycle = new Motocycles();
                    motocycle.Make = entries[0];
                    motocycle.Model = entries[1];
                    motocycle.Year = entries[2];
                    motocycle.PricePerDay = entries[3];
                    motocycle.Number = entries[4];

                    motocycleslist.Add(motocycle);
                }
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine(
                "Can not find file {0}.", motocyclesPath);
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine(
                "Invalid directory in the file path.");
            }
            catch (IOException)
            {
                Console.Error.WriteLine(
                "Can not open the file {0}", motocyclesPath);
            }

        }
        public void showData()
        {
            foreach (var motocycle in motocycleslist)
            {
                Console.WriteLine($"Make: {motocycle.Make} Model: {motocycle.Model} Year: {motocycle.Year} " +
                    $"Price per day: {motocycle.PricePerDay} Number: {motocycle.Number}");
            }

        }
    }
}
