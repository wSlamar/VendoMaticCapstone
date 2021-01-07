using Capstone;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Net.Http.Headers;
using System.Diagnostics.Tracing;
using System.Configuration;
using Vending_2._0.Classes;

namespace Vending_2._0
{
    public partial class Form1 : Form
    {
        public string NotEnough
        {
            get
            {
                return $"Not enough money! Your current balance is ${newMachine.Balance}.";
            }
        }

        public object TooMuch
        {
            get
            {
                return MessageBox.Show("Wow! Thats a lot of money you entered. How about trying to buy something instead?", "Balance");
            }
        }

        public static VendingMachine newMachine = new VendingMachine();

        Sounds click = new Sounds();

        public string Selection { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        // Button Click
        public void ButtonClicker()
        {
            if (newMachine.Balance >= newMachine.Inventory[Selection].Price && newMachine.Inventory[Selection].QuantityInStock > 0)
            {
                MessageBox.Show($"{newMachine.Inventory[Selection].Phrase}", $"{newMachine.Inventory[Selection].Name}");
                newMachine.PurchaseSnack(Selection);
                balanceCurrent.Text = newMachine.Balance.ToString();

                if (Selection == "A1")
                {
                    a1inv.Text = newMachine.Inventory[Selection].QuantityInStock.ToString();
                }
                if (Selection == "A2")
                {
                    a2inv.Text = newMachine.Inventory[Selection].QuantityInStock.ToString();
                }
                if (Selection == "A3")
                {
                    a3inv.Text = newMachine.Inventory[Selection].QuantityInStock.ToString();
                }
                if (Selection == "A4")
                {
                    a4inv.Text = newMachine.Inventory[Selection].QuantityInStock.ToString();
                }
                if (Selection == "B1")
                {
                    b1inv.Text = newMachine.Inventory[Selection].QuantityInStock.ToString();
                }
                if (Selection == "B2")
                {
                    b2inv.Text = newMachine.Inventory[Selection].QuantityInStock.ToString();
                }
                if (Selection == "B3")
                {
                    b3inv.Text = newMachine.Inventory[Selection].QuantityInStock.ToString();
                }
                if (Selection == "B4")
                {
                    b4inv.Text = newMachine.Inventory[Selection].QuantityInStock.ToString();
                }
                if (Selection == "C1")
                {
                    c1inv.Text = newMachine.Inventory[Selection].QuantityInStock.ToString();
                }
                if (Selection == "C2")
                {
                    c2inv.Text = newMachine.Inventory[Selection].QuantityInStock.ToString();
                }
                if (Selection == "C3")
                {
                    c3inv.Text = newMachine.Inventory[Selection].QuantityInStock.ToString();
                }
                if (Selection == "C4")
                {
                    c4inv.Text = newMachine.Inventory[Selection].QuantityInStock.ToString();
                }
                if (Selection == "D1")
                {
                    d1inv.Text = newMachine.Inventory[Selection].QuantityInStock.ToString();
                }
                if (Selection == "D2")
                {
                    d2inv.Text = newMachine.Inventory[Selection].QuantityInStock.ToString();
                }
                if (Selection == "D3")
                {
                    d3inv.Text = newMachine.Inventory[Selection].QuantityInStock.ToString();
                }
                if (Selection == "D4")
                {
                    d4inv.Text = newMachine.Inventory[Selection].QuantityInStock.ToString();
                }


            }
            else if (newMachine.Balance < newMachine.Inventory[Selection].Price)
            {
                MessageBox.Show($"{NotEnough}", $"{newMachine.Inventory[Selection].Name}");
            }

            if (newMachine.Inventory[Selection].QuantityInStock <= 0)
            {
                if (Selection == "A1")
                {
                    a1inv.ForeColor = System.Drawing.Color.Red;
                }
                if (Selection == "A2")
                {
                    a2inv.ForeColor = System.Drawing.Color.Red;
                }
                if (Selection == "A3")
                {
                    a3inv.ForeColor = System.Drawing.Color.Red;
                }
                if (Selection == "A4")
                {
                    a4inv.ForeColor = System.Drawing.Color.Red;
                }
                if (Selection == "B1")
                {
                    b1inv.ForeColor = System.Drawing.Color.Red;
                }
                if (Selection == "B2")
                {
                    b2inv.ForeColor = System.Drawing.Color.Red;
                }
                if (Selection == "B3")
                {
                    b3inv.ForeColor = System.Drawing.Color.Red;
                }
                if (Selection == "B4")
                {
                    b4inv.ForeColor = System.Drawing.Color.Red;
                }
                if (Selection == "C1")
                {
                    c1inv.ForeColor = System.Drawing.Color.Red;
                }
                if (Selection == "C2")
                {
                    c2inv.ForeColor = System.Drawing.Color.Red;
                }
                if (Selection == "C3")
                {
                    c3inv.ForeColor = System.Drawing.Color.Red;
                }
                if (Selection == "C4")
                {
                    c4inv.ForeColor = System.Drawing.Color.Red;
                }
                if (Selection == "D1")
                {
                    d1inv.ForeColor = System.Drawing.Color.Red;
                }
                if (Selection == "D2")
                {
                    d2inv.ForeColor = System.Drawing.Color.Red;
                }
                if (Selection == "D3")
                {
                    d3inv.ForeColor = System.Drawing.Color.Red;
                }
                if (Selection == "D4")
                {
                    d4inv.ForeColor = System.Drawing.Color.Red;
                }
                MessageBox.Show($"{newMachine.Inventory[Selection].Name} are out of stock!", $"{newMachine.Inventory[Selection].Name}");
            }
        }

        // File
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Help - About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by William and Keith.", "Vendo Matic 800 v2.0");
        }

        // File - Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreviousSales.SaveCurrentSales();
            Application.Exit();
        }

        // Restock
        private void restockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show("Restocking will remove your current balance, are you sure?", "Restock", buttons);

            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
            else
            {
                
            }
        }

        // Balance
        public void balanceCurrent_Click(object sender, EventArgs e)
        {
            balanceCurrent.Text = newMachine.Balance.ToString();
        }

        // $1
        private void oneDollar_Click(object sender, EventArgs e)
        {
            click.Player();

            if (newMachine.Balance >= 200)
            {
                _ = TooMuch;
            } 
            else
            {
                newMachine.AddFunds(1);
                balanceCurrent.Text = newMachine.Balance.ToString();
            }

        }

        // $2
        private void twoDollar_Click(object sender, EventArgs e)
        {
            click.Player();

            if (newMachine.Balance >= 200)
            {
                _ = TooMuch;
            }
            else
            {
                newMachine.AddFunds(2);
                balanceCurrent.Text = newMachine.Balance.ToString();
            }
        }

        // $5
        private void fiveDollar_Click(object sender, EventArgs e)
        {
            click.Player();

            if (newMachine.Balance >= 200)
            {
                _ = TooMuch;
            }
            else
            {
                newMachine.AddFunds(5);
                balanceCurrent.Text = newMachine.Balance.ToString();
            }
        }

        // $10
        private void tenDollar_Click(object sender, EventArgs e)
        {
            click.Player();

            if (newMachine.Balance >= 200)
            {
                _ = TooMuch;
            }
            else
            {
                newMachine.AddFunds(10);
                balanceCurrent.Text = newMachine.Balance.ToString();
            }
        }

        // Change
        private void change_Click(object sender, EventArgs e)
        {
            click.Player();

            MessageBox.Show(newMachine.ReturnChangeForMenu(), "Change");
            balanceCurrent.Text = newMachine.Balance.ToString();
        }

        // A1
        private void a1_Click(object sender, EventArgs e)
        {
            click.Player();
            ButtonSelection bs = new ButtonSelection();
            bs.Selection = "A1";
            bs.ButtonClick();

            //click.Player();
            //this.Selection = "A1";
            //ButtonClicker();
        }

        // A2
        private void a2_Click(object sender, EventArgs e)
        {
            click.Player();
            this.Selection = "A2";
            ButtonClicker();
        }

        // A3
        private void a3_Click(object sender, EventArgs e)
        {
            click.Player();
            this.Selection = "A3";
            ButtonClicker();
        }

        // A4
        private void a4_Click(object sender, EventArgs e)
        {
            click.Player();
            this.Selection = "A4";
            ButtonClicker();
        }

        // B1
        private void b1_Click(object sender, EventArgs e)
        {
            click.Player();
            this.Selection = "B1";
            ButtonClicker();
        }

        // B2
        private void b2_Click(object sender, EventArgs e)
        {
            click.Player();
            this.Selection = "B2";
            ButtonClicker();
        }

        // B3
        private void b3_Click(object sender, EventArgs e)
        {
            click.Player();
            this.Selection = "B3";
            ButtonClicker();
        }

        // B4
        private void b4_Click(object sender, EventArgs e)
        {
            click.Player();
            this.Selection = "B4";
            ButtonClicker();
        }

        // C1
        private void c1_Click(object sender, EventArgs e)
        {
            click.Player();
            this.Selection = "C1";
            ButtonClicker();
        }

        // C2
        private void c2_Click(object sender, EventArgs e)
        {
            click.Player();
            this.Selection = "C2";
            ButtonClicker();
        }

        // C3
        private void c3_Click(object sender, EventArgs e)
        {
            click.Player();
            this.Selection = "C3";
            ButtonClicker();
        }

        // C4
        private void c4_Click(object sender, EventArgs e)
        {
            click.Player();
            this.Selection = "C4";
            ButtonClicker();
        }

        // D1
        private void d1_Click(object sender, EventArgs e)
        {
            click.Player();
            this.Selection = "D1";
            ButtonClicker();
        }

        // D2
        private void d2_Click(object sender, EventArgs e)
        {
            click.Player();
            this.Selection = "D2";
            ButtonClicker();
        }

        // D3
        private void d3_Click(object sender, EventArgs e)
        {
            click.Player();
            this.Selection = "D3";
            ButtonClicker();
        }

        // D4
        private void d4_Click(object sender, EventArgs e)
        {
            click.Player();
            this.Selection = "D4";
            ButtonClicker();
        }
      
        // Transaction Log
        private void transactionLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\Student\git\c-module-1-capstone-team-3\19_Capstone\Vending 2.0\Sales Reports\LOG.txt";
            Process.Start(filePath);
        }

        // Sales Report
        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string salesFileName = DateTime.Now.ToString().Replace("/", "-").Replace(":", ";");

            string salesPath = Path.Combine(@"C:\Users\Student\git\c-module-1-capstone-team-3\19_Capstone\Vending 2.0\Sales Reports", $"{salesFileName}.txt");

            using (StreamWriter sales = new StreamWriter(salesPath))
            {
                foreach (KeyValuePair<string, Snack> sold in newMachine.Inventory)
                {
                    sales.WriteLine($"{sold.Value.Name} | {sold.Value.QuantitySold}");
                }

            }   
            
            Process.Start(salesPath);
        }

        // Guide
        private void guideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string picture = @"C:\Users\Student\Git\c-module-1-capstone-team-3\19_Capstone\Vending 2.0\img\guide.png";

            Process.Start(picture);
        }
        private void a2inv_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
