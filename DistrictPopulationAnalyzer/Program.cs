using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DistrictPopulationAnalyzer
{
    class District
    {
        public string Name { get; set; }
        public int Population { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "..", "district_population.csv");
            Console.WriteLine("Looking for file at: " + Path.GetFullPath(filePath));


            if (!File.Exists(filePath))
            {
                Console.WriteLine("CSV file not found. Make sure district_population.csv is in the root of the repo.");
                return;
            }

            List<District> districts = new List<District>();

            var lines = File.ReadAllLines(filePath).Skip(1); // Skip header
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length == 2 && int.TryParse(parts[1], out int population))
                {
                    districts.Add(new District { Name = parts[0], Population = population });
                }
            }

            if (districts.Count == 0)
            {
                Console.WriteLine("No valid data found in CSV.");
                return;
            }

            var largest = districts.OrderByDescending(d => d.Population).First();
            var smallest = districts.OrderBy(d => d.Population).First();
            var average = districts.Average(d => d.Population);

            Console.WriteLine("District Population Analysis");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Largest Population District : {largest.Name} ({largest.Population})");
            Console.WriteLine($"Smallest Population District: {smallest.Name} ({smallest.Population})");
            Console.WriteLine($"Average Population          : {average:F2}");

            Console.WriteLine("\nAll Districts:");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("{0,-20} {1,10}", "District", "Population");
            Console.WriteLine("--------------------------------------");
            foreach (var d in districts)
            {
                Console.WriteLine("{0,-20} {1,10}", d.Name, d.Population);
            }
            Console.WriteLine("--------------------------------------");
        }
    }
}

