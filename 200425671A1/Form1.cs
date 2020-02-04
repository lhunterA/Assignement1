using System;
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
        public Form1() //Constructor
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            String total = txtTotal.Text;
            String paid = txtPaid.Text;
            decimal change;
           // decimal remainder;
            //decimal track; //keep track of the change
            //int output;

            decimal numberT;
            decimal numberP;
            if (Decimal.TryParse(total, out numberT) && Decimal.TryParse(paid, out numberP))//if the two inputs are a valid number.
            {
                change = numberP - numberT; //change is paid - total
                txtChange.Text = change.ToString(); //output the change to the textbox as a string

                if (numberP >= numberT) //if the paid amount is greater than total. 
                {
                    MessageBox.Show("The if's work!");
                }
                else
                {
                    MessageBox.Show("Please, input a higher paid amount");//
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid Numeric Input. Please add a valid number.");
                return;
            }
                
            
          
            
        }

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
    }
}
