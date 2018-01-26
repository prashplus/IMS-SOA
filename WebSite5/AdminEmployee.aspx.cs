using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"].ToString() != "admin")
            Response.Redirect("Home.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        ServiceReference1.Service1Client svc = new ServiceReference1.Service1Client();
        int a = svc.addemployee(TextBox3.Text, TextBox8.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text);

        if (a == 1)
        {
            Response.Write("<script>alert('Employee Added');</script>");
        }
        else
        {
            Response.Write("<script>alert('Failed to add');</script>");
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        ServiceReference1.Service1Client svc = new ServiceReference1.Service1Client();
        int a = svc.rmemployee(int.Parse(TextBox7.Text));

        if (a == 1)
        {
            Response.Write("<script>alert('Employee Removed');</script>");
        }
        else
        {
            Response.Write("<script>alert('Failed to Remove');</script>");
        }
    }
}