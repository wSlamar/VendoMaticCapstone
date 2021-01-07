using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using MenuFramework;
using Capstone;
using System.ComponentModel.Design;
using System.Reflection.Emit;
using System.Drawing;

namespace Capstone
{
    public class PurchaseMenu : ConsoleMenu
    {
        public PurchaseMenu()
        {
            AddOption("Feed Money", MenuFundsCheck);
            AddOption("Select Product", ProductSelection);
            AddOption("Finish Transaction", EndTransaction);

            Configure(cfg =>
            {
                cfg.ItemForegroundColor = ConsoleColor.Cyan;
                cfg.SelectedItemForegroundColor = ConsoleColor.White;
            });
        }

        public MenuOptionResult MenuFundsCheck()
        {
            string readString = "";
            Console.WriteLine("ENTER A VALID MONEY AMOUNT ($1, $2, $5, $10)");
            Console.WriteLine();
            Console.Write("$");
            
            while (readString!="1"&& readString !="2"&& readString !="5"&& readString != "10")
            {
                readString = Console.ReadLine();
                if(readString != "1" && readString != "2" && readString != "5" && readString != "10")
                {
                    Console.WriteLine("Not valid money!");
                }
            }
            int readInt = int.Parse(readString);
            MainMenu.test.AddFunds(readInt);
            Console.WriteLine();
            Console.WriteLine($"${readInt} was added");
            return MenuOptionResult.WaitAfterMenuSelection;
        }

        public MenuOptionResult ProductSelection()
        {

            foreach (KeyValuePair<string, Snack> kvp in MainMenu.test.Inventory)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"({kvp.Key}) | ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(kvp.Value.Name);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" | ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(kvp.Value.Price);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" | ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(kvp.Value.QuantityInStock);
            }

            
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("ENTER AN ITEM NUMBER:");
            Console.WriteLine();
            string entry = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;

            if (!MainMenu.test.Inventory.ContainsKey(entry))
            {
                Console.WriteLine();
                Console.WriteLine("Product code does not exist!");
            }
            else if (MainMenu.test.Inventory[entry].QuantityInStock == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Sorry this item is out of stock!");
            }
            else if (MainMenu.test.Balance < MainMenu.test.Inventory[entry].Price)
            {
                Console.WriteLine();
                Console.WriteLine("Sorry not enough money!");
            }
            else
            {
                Console.WriteLine();
                MainMenu.test.PurchaseSnack(entry);
                Console.WriteLine($"{MainMenu.test.Inventory[entry].Name} purchased for ${MainMenu.test.Inventory[entry].Price} remaining balance is ${MainMenu.test.Balance}.");
                Console.WriteLine();
                Console.WriteLine(MainMenu.test.Inventory[entry].Phrase);
            }
            return MenuOptionResult.WaitAfterMenuSelection;
        }

        protected override void OnBeforeShow()
        {
            Console.WriteLine($"Current Money Provided: ${MainMenu.test.Balance}");
            Console.WriteLine();
        }

        public MenuOptionResult EndTransaction()
        {
            MainMenu.test.ReturnChange();
            return MenuOptionResult.WaitThenCloseAfterSelection;
        }
    }
} 
