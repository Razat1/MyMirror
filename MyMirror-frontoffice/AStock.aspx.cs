using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyMirror_classes;

public partial class AStock : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      

    }


    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsStock Astock = new clsStock();

        Astock.StockDes = txtDes.Text;
        Astock.Price = Convert.ToInt32(txtPrice.Text);
        Astock.Quantity = Convert.ToInt32(txtQuantity.Text);
        Astock.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
        Session["AStock"] = Astock;
        Response.Write("StockViewer.aspx");


    }
}