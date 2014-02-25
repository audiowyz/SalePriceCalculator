using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalePriceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal decPrice = decimal.Parse(txtPrice.Text);
            decimal decPercent = decimal.Parse(txtDiscountPercent.Text) / 100;



            lblSalePrice.Text = (decPrice - (decPrice * decPercent)).ToString("C");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
