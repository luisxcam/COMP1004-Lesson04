/*
 * Name: Anju cHawla
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

       

    } 

      
}
