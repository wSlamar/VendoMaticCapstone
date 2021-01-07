using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vending_2._0.Classes
{
    class ButtonSelection : Form1
    {
        //public static Form1 xxx = new Form1();

        //public static Label ccc = xxx.balanceCurrent;

        public void ButtonClick()
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

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // a1inv
            // 
            this.a1inv.Location = new System.Drawing.Point(642, 212);
            this.a1inv.Click += new System.EventHandler(this.a1inv_Click);
            // 
            // ButtonSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1206, 804);
            this.Name = "ButtonSelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void a1inv_Click(object sender, EventArgs e)
        {

        }
    }
}
