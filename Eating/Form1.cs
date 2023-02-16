namespace Eating
{
    public partial class Form1 : Form
    {
        double orderTotal = 0.00;
        const double Tax = 7.75d;
        const double burgerPrice = 6.95d;
        const double pizzaPrice = 5.95d;
        const double saladPrice = 4.95d; double addOn = 0;
        double addOnPrice = 0;
        public Form1()
        {
            InitializeComponent();
            if (radioHamburger.Checked)
            {
                groupBox1.Text = "Add-on items ($0.75/each";
                chkOption1.Text = "Lettuce, tomato and onions";
                chkOption2.Text = "Ketchup, mustard, and mayo";
                chkOption3.Text = "French fries";
                addOnPrice = 0.75d;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
             
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkOption1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOption1.Checked)
            {
                addOn += addOnPrice;
            }
            else
            {
                addOn -= addOnPrice;
            }
        }

        private void chkOption2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOption2.Checked)
            {
                addOn += addOnPrice;
            }
            else
            {
                addOn -= addOnPrice;
            }
        }

        private void radioHamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (radioHamburger.Checked)
            {
                groupBox1.Text = "Add-on items ($0.75/each";
                chkOption1.Text = "Lettuce, tomato and onions";
                chkOption2.Text = "Ketchup, mustard, and mayo";
                chkOption3.Text = "French fries";
                addOnPrice = 0.75d;
            }

        }

        private void radioPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPizza.Checked)
            {
                groupBox1.Text = "Add-on items ($0.50/each";
                chkOption1.Text = "Pepperoni";
                chkOption2.Text = "Sausage";
                chkOption3.Text = "Olives";
                addOnPrice = 0.50d;
            }

        }

        private void radioSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSalad.Checked)
            {
                groupBox1.Text = "Add-on items ($0.25/each";
                chkOption1.Text = "Croutons";
                chkOption2.Text = "Bacon bits";
                chkOption3.Text = "Bread sticks";
                addOnPrice = 0.25d;
            }
        }

        private void chkOption3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOption3.Checked)
            {
                addOn += addOnPrice;
            }
            else
            {
                addOn -= addOnPrice;
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (radioHamburger.Checked)
            {
                orderTotal += burgerPrice;
            }
            if (radioPizza.Checked)
            {
                orderTotal += pizzaPrice;
            }
            if (radioSalad.Checked)
            {
                orderTotal += saladPrice;
            }
            orderTotal += addOn;
            double totalTax = (orderTotal * Tax) / 100; txtSubtotal.Text = "$" + String.Format("{0:0.00}", (orderTotal));
            txtSalesTax.Text = "$" + String.Format("{0:0.00}", (totalTax));
            txtOrderTotal.Text = "$" + String.Format("{0:0.00}", (orderTotal + totalTax));
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            //radioHamburger.Checked;
            txtOrderTotal.Text = "";
            txtSalesTax.Text = "";
            txtSubtotal.Text = "";
            orderTotal = 0.00;
            addOn = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            txtOrderTotal.Text = "";
            txtSalesTax.Text = "";
            txtSubtotal.Text = "";
            orderTotal = 0.00;
            addOn = 0;
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    } 
}