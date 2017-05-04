// File Prologue
// Name: Jonathan Franklin
// Project: Project #5
// Date: October 24, 2016


// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //This method presents about information when the "About" menu entry is clicked.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jonathan Franklin\nCS 1400\nProject #5");
        }

        //This method closes the application when the "Exit" menu entry is clicked.
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Declare Variables
            bool standardShipping;
            bool expressShipping;
            bool sameDayShipping;
            bool categoryA;
            bool categoryB;
            int itemCount = 0;
            double itemWeight = 0;
            bool surcharge;
            bool noSurcharge;
            double shippingCost;

            //Set variables according to checked radios and data inputted to text boxes.
            standardShipping = standardRadio.Checked;
            expressShipping = expressRadio.Checked;
            sameDayShipping = sameDayRadio.Checked;
            categoryA = categoryARadio.Checked;
            categoryB = categoryBRadio.Checked;
            itemCount = int.Parse(itemCountTextBox.Text);
            itemWeight = double.Parse(itemWeightTextBox.Text);
            surcharge = surchargeRadio.Checked;
            noSurcharge = noSurchargeRadio.Checked;
            
            //Create new ShippingCost object name myCost
            ShippingCost myCost = new ShippingCost(standardShipping, expressShipping, sameDayShipping, categoryA, categoryB, itemCount, itemWeight, surcharge, noSurcharge);
            //Set shippingCost to actual cost calculated through myCost.CalculatedCost()
            shippingCost = myCost.CalculateCost();
            //Display shippingCost in currency format
            shippingCostTextBox.Text = $"{shippingCost:C}";
        }
    }
}
