﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _200425671A1
{
    public partial class Form1: Form //main class
    {
        double change = 0;
        int counter = 0;

        public Form1() //Constructor
        {

            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {           
            String total = txtTotal.Text;
            String paid = txtPaid.Text;
            double numberT;
            double numberP;

            if (Double.TryParse(total, out numberT) && Double.TryParse(paid, out numberP))//if the two inputs are a valid number.
            {
                change = numberP - numberT; //change is paid - total
                txtChange.Text = change.ToString(); //output the change to the textbox as a string

                if (numberP >= numberT) //if the paid amount is greater than total. 
                {
                    FindChange(2);
                    txtToonies.Text = counter.ToString(); //use the counter from FindChaneg and assign to the correct textbox
                    counter = 0; //reset counter to 0 before using it in the next method. 
                    FindChange(1);
                    txtLoonies.Text = counter.ToString();
                    counter = 0;
                    FindChange(0.25);
                    txtQuarters.Text = counter.ToString();
                    counter = 0;
                    FindChange(0.10);
                    txtDimes.Text = counter.ToString();
                    counter = 0;
                    if (change <= 0.02)
                    {
                        txtNickels.Text = "0";
                    }
                    else
                    {
                        txtNickels.Text = "1";
                    }
                }
                else / when paid isn't high enough
                {
                    MessageBox.Show("Please, input a higher paid amount");/
                    return; //return to fix the mistake
                }
            }
            else //when they add a letter to the amount of total or paid
            {
                MessageBox.Show("Invalid Numeric Input. Please add a valid number.");
                return; //let them fix the mistake
            } 
        } //end the button calculate click event

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear all the input boxes on the form
            txtTotal.Text = "";
            txtPaid.Text = "";
            txtChange.Text = "";
            txtToonies.Text = "";
            txtLoonies.Text = "";
            txtQuarters.Text = "";
            txtDimes.Text = "";
            txtNickels.Text = "";
        }

        /// <summary>
        /// A method that takes the coin amount to be determined on how much to give back.
        /// </summary>
        /// <param name="coin">the value of coin you want change out of</param>
        public void FindChange(double coin) 
        {
            while (change>=coin) //while the amount of change left is larger than the biggest potential change back
            {
                change -= coin; //change minus the amount of the coin
                counter++; //add to a counter
            }
        }
    }
}
