using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace week6
{
    public partial class tip : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            // get the amount
            Double amount = Convert.ToDouble(txtAmount.Text);

            //get the tip percent
            Double tip = Convert.ToDouble(ddlPercent.SelectedValue);

            //calculate the tip and total
            Double tipAmount = amount * tip;
            Double Total = amount + tipAmount;

            //display the results
            lblTip.Text = tipAmount.ToString("c");
            lblTotal.Text = Total.ToString("c");

            //show the hidden label
            lblTip.Visible = true;
            lblTotal.Visible = true;
        }
    }
}