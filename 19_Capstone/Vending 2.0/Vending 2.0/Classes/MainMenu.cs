//using System;
//using System.Collections.Generic;
//using System.Text;
//using MenuFramework;
//using Capstone;
//using Figgle;
//using System.IO;

//namespace Capstone
//{
//    public class MainMenu : ConsoleMenu
//    {
//        static public VendingMachine test = new VendingMachine();

//        public MainMenu()
//        {
//            AddOption("Display Vending Machine Items", DisplayItems);
//            AddOption("Purchase", PurchaseSubClass);
//            AddOption("Exit", GetOutOfHere);
//            AddOption("Generate Sales Report", ReportSales);

//            Configure(cfg =>
//            {
//                cfg.ItemForegroundColor = ConsoleColor.Cyan;
//                cfg.SelectedItemForegroundColor = ConsoleColor.White;
//            });
//        }
//        private MenuOptionResult DisplayItems()
//        {
//            foreach (KeyValuePair<string, Snack> kvp in test.Inventory)
//            {

//                Console.ForegroundColor = ConsoleColor.Cyan;
//                Console.Write(kvp.Value.Name);
//                Console.ForegroundColor = ConsoleColor.White;
//                Console.Write(" | ");
//                Console.ForegroundColor = ConsoleColor.Cyan;
//                Console.WriteLine($"{kvp.Value.QuantityInStock} remaining");
//            }
//            return MenuOptionResult.WaitAfterMenuSelection;
//        }

//        private MenuOptionResult PurchaseSubClass()
//        {
//            PurchaseMenu purchMen = new PurchaseMenu();
//            purchMen.Show();
//            return MenuOptionResult.DoNotWaitAfterMenuSelection;
//        }

//        protected override void OnBeforeShow()
//        {
//            Console.ForegroundColor = ConsoleColor.Cyan;
//            Console.WriteLine(FiggleFonts.Ogre.Render("Vendo Matic 800"));
//        }

//        private MenuOptionResult ReportSales()
//        {
//            string salesFileName = DateTime.Now.ToString().Replace("/", "-").Replace(":", ";");

//            string salesPath = Path.Combine(@"C:\Users\Student\git\c-module-1-capstone-team-3\19_Capstone\", $"{salesFileName}.txt");

//            using (StreamWriter sales = new StreamWriter(salesPath))
//            {
//                foreach (KeyValuePair<string, Snack> sold in test.Inventory)
//                {
//                    sales.WriteLine($"{sold.Value.Name} | {sold.Value.QuantitySold}");
//                }
//            }
//            Console.WriteLine("Sales Report Generated");
//            return MenuOptionResult.WaitAfterMenuSelection;
//        }

//        private MenuOptionResult GetOutOfHere()
//        {
//            PreviousSales.SaveCurrentSales();
//            return MenuOptionResult.ExitAfterSelection;
//        }
//    }
//}
