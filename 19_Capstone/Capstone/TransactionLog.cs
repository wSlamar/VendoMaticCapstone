using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Capstone;

namespace Capstone
{
    public class TransactionLog
    {
        static string transactionLogPath = @"C:\Users\Student\git\c-module-1-capstone-team-3\19_Capstone\LOG.txt";
        //method for addfunds transaction
        static public string AddFundsTransaction(int moneyFed)
        {
            string forWriter = $"{DateTime.Now} FEED MONEY: {((MainMenu.test.Balance) - moneyFed):c} {MainMenu.test.Balance:c}";
            return forWriter;
        }
        //method for purchase transaction
        static public string PurchaseTransaction(string itemNumber)
        {
            string forWriter = $"{DateTime.Now} {MainMenu.test.Inventory[itemNumber].Name} {itemNumber} {((MainMenu.test.Balance) + MainMenu.test.Inventory[itemNumber].Price):c} {MainMenu.test.Balance:c}";
            return forWriter;
        }

        //method for change transaction
        static public string ChangeTransaction()
        {
            string forWriter = $"{DateTime.Now} GIVE CHANGE: {MainMenu.test.Balance:c} $0.00";
            return forWriter;
        }

        //streamwrite to new file for each transaction.  Append, do not overwrite
        static public void WriteLog(string toWrite)
        {
            using(StreamWriter logWrite = new StreamWriter(transactionLogPath, true))
            {
                logWrite.WriteLine(toWrite);
            }
        }
    }
}
