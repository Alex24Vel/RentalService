using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalServiceLib
{
    public class Bicycles : IVehicle
    {
        public string bicyclesPath = @"T:\Microsoft Visual Studio\Projects\Bicycles.txt";

        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string PricePerDay { get; set; }
        public string Number { get; set; }

        public List<Bicycles> bicycleslist = new List<Bicycles>();

        public void getData(List<Bicycles> bicycleslist)
        {
            try
            {
                FileStream reader = new FileStream(bicyclesPath, FileMode.Open, FileAccess.Read);
                List<string> lines = File.ReadAllLines(bicyclesPath).ToList();
                foreach (var line in lines)
                {
                    string[] entries = line.Split(',');
                    Bicycles bicycle = new Bicycles();
                    bicycle.Make = entries[0];
                    bicycle.Model = entries[1];
                    bicycle.Year = entries[2];
                    bicycle.PricePerDay = entries[3];
                    bicycle.Number = entries[4];

                    bicycleslist.Add(bicycle);
                }
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine(
                "Can not find file {0}.", bicyclesPath);
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine(
                "Invalid directory in the file path.");
            }
            catch (IOException)
            {
                Console.Error.WriteLine(
                "Can not open the file {0}", bicyclesPath);
            }

        }
        public void showData()
        {
            foreach (var bicycle in bicycleslist)
            {
                Console.WriteLine($"Make: {bicycle.Make} Model: {bicycle.Model} Year: {bicycle.Year} " +
                    $"Price per day: {bicycle.PricePerDay} Number: {bicycle.Number}");
            }

        }
    }
}
