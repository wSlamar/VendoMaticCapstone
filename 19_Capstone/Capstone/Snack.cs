using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Capstone;

namespace Capstone
{
    public class Snack
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public string SnackClass { get; private set; }
        public int QuantityInStock { get; private set; }
        public int QuantitySold { get; private set; }
        public string SlotLocation { get; private set; }
        public string[] SplitString { get; private set; }
        public string Phrase
        {
            get
            {
                if (SnackClass == "Chip")
                {
                    return "Crunch Crunch, Yum!";
                }
                else if (SnackClass == "Candy")
                {
                    return "Munch Munch, Yum!";
                }
                else if (SnackClass == "Drink")
                {
                    return "Glug Glug, Yum!";
                }
                else
                {
                    return "Chew Chew, Yum!";
                }
            }
        }
        public Snack(string[] splitString)
        {
            SplitString = splitString;
            SlotLocation = SplitString[0];
            Name = SplitString[1];
            Price = decimal.Parse(SplitString[2]);
            SnackClass = SplitString[3];
            QuantityInStock = 5;
        }

        public void SoldItem()
        {
            QuantityInStock--;
            QuantitySold++;
        }
        public static SortedDictionary<string, Snack> UpdateSoldQuantity(SortedDictionary<string, Snack> updateSnack)
        {
            try
            {
                SortedDictionary<string, int> toUpdate = PreviousSales.LoadCurrentSales();

                foreach (KeyValuePair<string, int> toApply in toUpdate)
                {
                    updateSnack[toApply.Key].QuantitySold = toApply.Value;
                }
        }
            catch (FileNotFoundException)
            {

            }

            return updateSnack;
        }
    }
}
