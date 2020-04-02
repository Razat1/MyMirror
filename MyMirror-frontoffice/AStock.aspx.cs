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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock Astock = new clsStock();
        Int32 StockNo;
        Boolean Found = false;
        StockNo = Convert.ToInt32(txtStockNo.Text);
        Found = Astock.Find(StockNo);
        if (Found == true)
        {
            
            txtQuantity.Text = Astock.Quantity.ToString();
            txtDateAdded.Text = Astock.DateAdded.ToString();
            txtPrice.Text = Astock.Price.ToString();
            txtDes.Text = Astock.StockDescription;

        }
        
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsStock Astock = new clsStock();
        string StockDescription = txtDes.Text;
        string Quantity = txtQuantity.Text;
        string Price = txtPrice.Text;
        string DateAdded = txtDateAdded.Text;
        string Error = "";
        Error = Astock.Valid(StockDescription, Quantity, Price, DateAdded);
        if (Error == "")
        {
            Astock.StockDescription = StockDescription;
            Astock.Quantity = Convert.ToInt32(Quantity);
            Astock.Price = Convert.ToInt32(Price);
            Astock.DateAdded = Convert.ToDateTime(DateAdded);
            Session["AStock"] = Astock;
            Response.Redirect("StockViewer.aspx");
        }
        else
        {

        }
    }
}


