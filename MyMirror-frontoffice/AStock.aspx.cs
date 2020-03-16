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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock Astock = new clsStock();
        Int32 AstockNo;
        Boolean Found = false;
        AstockNo = Convert.ToInt32(txtStockNo.Text);
        Found = Astock.Find(AstockNo);
        if (Found == true) {
            txtStockNo.Text = Astock.StockNo.ToString();
            txtQuantity.Text = Astock.Quantity.ToString();
            txtDateAdded.Text = Astock.DateAdded.ToString();
            txtPrice.Text = Astock.Price.ToString();
            txtDes.Text = Astock.StockDes;
            
        }

    }
}