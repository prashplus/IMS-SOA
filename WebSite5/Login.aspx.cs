using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ServiceReference1.Service1Client svc = new ServiceReference1.Service1Client();
        int a = svc.login(TextBox3.Text, TextBox4.Text);



        if(a==1)
        {
            Session["user"] = "admin";
            Response.Redirect("AdminInventory.aspx");
        }
        else
        {
            Response.Write("Wrong Credentials");
        }

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        ServiceReference1.Service1Client svc = new ServiceReference1.Service1Client();
        int a = svc.login(TextBox5.Text, TextBox6.Text);



        if (a == 1)
        {
            Session["user"] = "employee";
            Response.Redirect("Employee.aspx");
        }
        else
        {
            Response.Write("Wrong Credentials");
        }
    }
}