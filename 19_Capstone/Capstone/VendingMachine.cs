using System;
using System.Collections.Generic;
using System.Text;
using Capstone;

namespace Capstone
{
    public class VendingMachine
    {
        public SortedDictionary<string, Snack> Inventory { get; private set; }
        public decimal Balance { get; private set; } = 0;

        public VendingMachine()
        {
            SortedDictionary<string, Snack> loadedInventory = Loader.SnackLoader();

            Inventory = loadedInventory;
        }

        public void AddFunds(int fundsToAdd)
        {
            Balance += fundsToAdd;
            string toLog = TransactionLog.AddFundsTransaction(fundsToAdd);
            TransactionLog.WriteLog(toLog);
        }

        public void ReturnChange()
        {
            string toLog = TransactionLog.ChangeTransaction();

            decimal quarter = .25M;
            decimal dime = .10M;
            decimal nickle = .05M;
            decimal penny = .01M;

            int quartersReturned = (int)(Balance / quarter);
            Balance = Balance % quarter;

            int dimesReturned = (int)(Balance / dime);
            Balance = Balance % dime;

            int nicklesReturned = (int)(Balance / nickle);
            Balance = Balance % nickle;

            int penniesReturned = (int)(Balance / penny);
            Balance = Balance % penny;
            TransactionLog.WriteLog(toLog);
            Console.WriteLine($"Your change is {quartersReturned} quarters, {dimesReturned} dimes, {nicklesReturned} nickles, and {penniesReturned} pennies.");
        }

        public void PurchaseSnack(string snackLocation)
        {
            Balance = (Balance - (Inventory[snackLocation].Price));
            Inventory[snackLocation].SoldItem();
            string toLog = TransactionLog.PurchaseTransaction(snackLocation);
            TransactionLog.WriteLog(toLog);
        }

    }
}

