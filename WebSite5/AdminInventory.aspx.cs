using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"].ToString() != "admin")
            Response.Redirect("Home.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //int id = int.Parse(TextBox2.Text);
        string name = TextBox1.Text;
        string brand = TextBox4.Text;
        string category = TextBox5.Text;
        float costprice = float.Parse(TextBox6.Text);
        float sellprice = float.Parse(TextBox7.Text);
        float weight = float.Parse(TextBox8.Text);
        int quantity = int.Parse(TextBox3.Text);

        ServiceReference1.Service1Client svc = new ServiceReference1.Service1Client();

        int a = svc.addtoinventory(name, brand, category, costprice, sellprice, weight, quantity);

        if (a == 1)
        {
            Response.Write("<script>alert('Item Added to Inventory');</script>");
        }
        else
        {
            Response.Write("<script>alert('Item Failed to Add');</script>");
        }
    }
}