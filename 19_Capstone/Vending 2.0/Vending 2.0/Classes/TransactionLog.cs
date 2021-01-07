using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Capstone;
using Vending_2._0;

namespace Capstone
{
    public class TransactionLog
    {
        static string transactionLogPath = @"C:\Users\Student\git\c-module-1-capstone-team-3\19_Capstone\Vending 2.0\Sales Reports\LOG.txt";
        //method for addfunds transaction
        static public string AddFundsTransaction(int moneyFed)
        {
            string forWriter = $"{DateTime.Now} FEED MONEY: {((Form1.newMachine.Balance) - moneyFed):c} {Form1.newMachine.Balance:c}";
            return forWriter;
        }
        //method for purchase transaction
        static public string PurchaseTransaction(string itemNumber)
        {
            string forWriter = $"{DateTime.Now} {Form1.newMachine.Inventory[itemNumber].Name} {itemNumber} {((Form1.newMachine.Balance) + Form1.newMachine.Inventory[itemNumber].Price):c} {Form1.newMachine.Balance:c}";
            return forWriter;
        }

        //method for change transaction
        static public string ChangeTransaction()
        {
            string forWriter = $"{DateTime.Now} GIVE CHANGE: {Form1.newMachine.Balance:c} $0.00";
            return forWriter;
        }

        //streamwrite to new file for each transaction.  Append, do not overwrite
        static public void WriteLog(string toWrite)
        {
            using (StreamWriter logWrite = new StreamWriter(transactionLogPath, true))
            {
                logWrite.WriteLine(toWrite);
            }
        }
    }
}
