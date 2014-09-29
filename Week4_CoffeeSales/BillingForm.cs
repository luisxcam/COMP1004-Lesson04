/*
 * Name: Luis Acevedo
 * Date: Sept., 2014
 * Purpose: For a coffee shop, this project calculates the amount due based on the user selection.
 * It accumulates summary information that can be displayed as required.
 *
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4_CoffeeSales
{
    public partial class BillingForm : Form
    {
        //module level varaiables
        private RadioButton selected;
        //module level constants
        const decimal TAX_RATE_Decimal = 0.15m;
        const decimal CAPPUCCINO_PRICE_Decimal = 2m;
        const decimal ESPRESSO_PRICE_Decimal = 2.25m;
        const decimal LATTE_PRICE_Decimal = 1.75m;
        const decimal ICED_PRICE_Decimal = 2.50m;


        public BillingForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes the application
            this.Close();
        }

        private void BillingForm_Load(object sender, EventArgs e)
        {
            //default settings when the form loads
            quantityTextBox.Select();
            cappuccinoRadioButton.Checked = false;
            clearButton.Enabled = false;
            newOrderButton.Enabled = false;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //calculate the amount due for an order
            //maintain summary information
            decimal priceDecimal, taxDecimal, itemAmountDecimal;
            int quantityInteger;

            //Check if user is giving the right value
            try
            {
                itemAmountDecimal = int.Parse(quantityTextBox.Text);
                
                //check if the value is greater than zero
                if (itemAmountDecimal > 0)
                {

                }
                else
                {
                    MessageBox.Show("Value must the greater than Zero", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    quantityTextBox.SelectAll();
                    quantityTextBox.Focus();
                }

            }
            catch (FormatException exception)
            {
                if (quantityTextBox.Text == "")
                {
                    MessageBox.Show("Must provide a value", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Quantity MUST be a positive whole number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                quantityTextBox.SelectAll();
                quantityTextBox.Focus();
            }
            catch (OverflowException exception)
            {
                MessageBox.Show("Out of range", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                quantityTextBox.SelectAll();
                quantityTextBox.Focus();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error:" + exception.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                quantityTextBox.SelectAll();
                quantityTextBox.Focus();
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    } 
     
}
