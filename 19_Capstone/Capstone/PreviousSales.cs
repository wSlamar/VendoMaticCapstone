using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Capstone;

namespace Capstone
{
    public class PreviousSales
    {
        static string previousSalesPath = @"C:\Users\Student\git\c-module-1-capstone-team-3\19_Capstone\previousSales.txt";

        public static void SaveCurrentSales()
        {
            if (File.Exists(previousSalesPath))
            {
            File.Delete(previousSalesPath);

            }
            foreach (KeyValuePair<string, Snack> toLog in MainMenu.test.Inventory)
            {
                using (StreamWriter toWrite = new StreamWriter(previousSalesPath, true))
                {
                    toWrite.WriteLine($"{toLog.Key}|{toLog.Value.QuantitySold}");
                }
            }
        }

        public static SortedDictionary<string, int> LoadCurrentSales()
        {
            SortedDictionary<string, int> loadSales = new SortedDictionary<string, int>();

            using (StreamReader toLoad = new StreamReader(previousSalesPath))
            {
                while (!toLoad.EndOfStream)
                {
                    string[] loadArray = toLoad.ReadLine().Split("|");

                    loadSales.Add(loadArray[0], int.Parse(loadArray[1]));
                }
            }
            return loadSales;
        }
    }
}
