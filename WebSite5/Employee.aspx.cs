using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Services;



public partial class Employee : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"].ToString() != "employee")
            Response.Redirect("Home.aspx");
        Label18.Text = DateTime.Now.ToString();


    }

    protected void TextBox34_TextChanged(object sender, EventArgs e)
    {

    }

    public class dataBucket
    {
        public String[] str = new string[11];
    }




    protected void TextBox68_TextChanged(object sender, EventArgs e)
    {


        TextBox34.Text = "0";
        TextBox82.Text = "0";
        TextBox88.Text = "0";
        TextBox94.Text = "0";
        TextBox100.Text = "0";
        TextBox106.Text = "0";
        TextBox112.Text = "0";
        TextBox118.Text = "0";
        TextBox124.Text = "0";
        TextBox76.Text = "0";
        
        SqlConnection cn = new SqlConnection(@"Data Source=NIMBUS\SQLEXPRESS;Initial Catalog=soa;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        

        dataBucket d1 = new dataBucket();

        string ins = "select name, category, brand, sellprice, quantity from inventory where id=(" + TextBox68.Text + ");";

        SqlCommand com = new SqlCommand(ins, cn);

        try
        {
            cn.Open();

            using (SqlDataReader read = com.ExecuteReader())
            {
                while (read.Read())
                {
                    d1.str[1] = (read["name"].ToString());
                    d1.str[2] = (read["category"].ToString());
                    d1.str[3] = (read["brand"].ToString());
                    d1.str[4] = (read["sellprice"].ToString());
                    d1.str[5] = (read["quantity"].ToString());
                    
                }
            }


            cn.Close();
            
        }
        catch(Exception e123)
        {
            Response.Write("Error Occured");
        }
        finally
        {
            cn.Close();
        }

        TextBox125.Text= d1.str[1];
        TextBox36.Text = d1.str[2];
        TextBox37.Text = d1.str[3];
        TextBox69.Text = d1.str[4];

        int quantity = int.Parse(TextBox70.Text);

        if(int.Parse(d1.str[5])<quantity)
        {
            Response.Write("<script>alert('Stock not available');</script>");
        }

        TextBox34.Text = (int.Parse(d1.str[4]) * int.Parse(TextBox70.Text)).ToString();

   

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Button2.Visible = true;
        TextBox65.Text = (int.Parse(TextBox34.Text)+ int.Parse(TextBox76.Text) + int.Parse(TextBox82.Text) + int.Parse(TextBox88.Text) + int.Parse(TextBox94.Text) + int.Parse(TextBox100.Text) + int.Parse(TextBox106.Text) + int.Parse(TextBox112.Text) + int.Parse(TextBox118.Text)).ToString();

        SqlConnection cn = new SqlConnection(@"Data Source=NIMBUS\SQLEXPRESS;Initial Catalog=soa;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        
        SqlConnection cn2 = new SqlConnection(@"Data Source=NIMBUS\SQLEXPRESS;Initial Catalog=soa;Integrated Security=True");
        SqlCommand cmd2 = new SqlCommand();
        int oldquantity, newquantity, id,a;
        string ins,ins2;
        SqlDataReader dr;


       
        cn.Open();
        cn2.Open();
        oldquantity = newquantity = id = 0;
        ins = "select * from inventory where id=(" + TextBox68.Text + ");";
        cmd2 = new SqlCommand(ins, cn2);
       

        dr = cmd2.ExecuteReader();

        if (dr.HasRows == true)
        {

            try
            {
                if (dr.Read())
                {
                    oldquantity = int.Parse(dr["quantity"].ToString());
                    id = int.Parse(dr["id"].ToString());
                    dr.Close();
                }



                newquantity = oldquantity - int.Parse(TextBox70.Text);
                ins2 = "UPDATE inventory SET quantity = " + newquantity + " where id=" + id + ";";

                cmd = new SqlCommand(ins2, cn);
                a = cmd.ExecuteNonQuery();
             

            }

            catch (Exception e1235)
            {
                Response.Write("<script>alert('Error');</script>");
            }
            finally
            {
                cn.Close();
                cn2.Close();
            }
        }


        if(TextBox71.Text != "")
        {
            cn.Open();
            cn2.Open();
            oldquantity = newquantity = id = 0;
            ins = "select * from inventory where id=(" + TextBox71.Text + ");";
            cmd2 = new SqlCommand(ins, cn2);


            dr = cmd2.ExecuteReader();

            if (dr.HasRows == true)
            {

                try
                {
                    if (dr.Read())
                    {
                        oldquantity = int.Parse(dr["quantity"].ToString());
                        id = int.Parse(dr["id"].ToString());
                        dr.Close();
                    }



                    newquantity = oldquantity - int.Parse(TextBox75.Text);
                    ins2 = "UPDATE inventory SET quantity = " + newquantity + " where id=" + id + ";";

                    cmd = new SqlCommand(ins2, cn);
                    a = cmd.ExecuteNonQuery();


                }

                catch (Exception e1235)
                {
                    Response.Write("<script>alert('Error');</script>");
                }
                finally
                {
                    cn.Close();
                    cn2.Close();
                }
            }
        }


        if (TextBox77.Text != "")
        {
            cn.Open();
            cn2.Open();
            oldquantity = newquantity = id = 0;
            ins = "select * from inventory where id=(" + TextBox77.Text + ")";
            cmd2 = new SqlCommand(ins, cn2);


            dr = cmd2.ExecuteReader();

            if (dr.HasRows == true)
            {

                try
                {
                    if (dr.Read())
                    {
                        oldquantity = int.Parse(dr["quantity"].ToString());
                        id = int.Parse(dr["id"].ToString());
                        dr.Close();
                    }



                    newquantity = oldquantity - int.Parse(TextBox81.Text);
                    ins2 = "UPDATE inventory SET quantity = " + newquantity + " where id=" + id + ";";

                    cmd = new SqlCommand(ins2, cn);
                    a = cmd.ExecuteNonQuery();


                }

                catch (Exception e1235)
                {
                    Response.Write("<script>alert('Error');</script>");
                }
                finally
                {
                    cn.Close();
                    cn2.Close();
                }
            }
        }

        //4
        if (TextBox83.Text != "")
        {
            cn.Open();
            cn2.Open();
            oldquantity = newquantity = id = 0;
            ins = "select * from inventory where id=(" + TextBox83.Text + ");";
            cmd2 = new SqlCommand(ins, cn2);


            dr = cmd2.ExecuteReader();

            if (dr.HasRows == true)
            {

                try
                {
                    if (dr.Read())
                    {
                        oldquantity = int.Parse(dr["quantity"].ToString());
                        id = int.Parse(dr["id"].ToString());
                        dr.Close();
                    }



                    newquantity = oldquantity - int.Parse(TextBox87.Text);
                    ins2 = "UPDATE inventory SET quantity = " + newquantity + " where id=" + id + ";";

                    cmd = new SqlCommand(ins2, cn);
                    a = cmd.ExecuteNonQuery();


                }

                catch (Exception e1235)
                {
                    Response.Write("<script>alert('Error');</script>");
                }
                finally
                {
                    cn.Close();
                    cn2.Close();
                }
            }
        }

        //5
        if (TextBox89.Text != "")
        {
            cn.Open();
            cn2.Open();
            oldquantity = newquantity = id = 0;
            ins = "select * from inventory where id=(" + TextBox89.Text + ");";
            cmd2 = new SqlCommand(ins, cn2);


            dr = cmd2.ExecuteReader();

            if (dr.HasRows == true)
            {

                try
                {
                    if (dr.Read())
                    {
                        oldquantity = int.Parse(dr["quantity"].ToString());
                        id = int.Parse(dr["id"].ToString());
                        dr.Close();
                    }



                    newquantity = oldquantity - int.Parse(TextBox93.Text);
                    ins2 = "UPDATE inventory SET quantity = " + newquantity + " where id=" + id + ";";

                    cmd = new SqlCommand(ins2, cn);
                    a = cmd.ExecuteNonQuery();


                }

                catch (Exception e1235)
                {
                    Response.Write("<script>alert('Error');</script>");
                }
                finally
                {
                    cn.Close();
                    cn2.Close();
                }
            }
        }


        //6
        if (TextBox95.Text != "")
        {
            cn.Open();
            cn2.Open();
            oldquantity = newquantity = id = 0;
            ins = "select * from inventory where id=(" + TextBox95.Text + ");";
            cmd2 = new SqlCommand(ins, cn2);


            dr = cmd2.ExecuteReader();

            if (dr.HasRows == true)
            {

                try
                {
                    if (dr.Read())
                    {
                        oldquantity = int.Parse(dr["quantity"].ToString());
                        id = int.Parse(dr["id"].ToString());
                        dr.Close();
                    }



                    newquantity = oldquantity - int.Parse(TextBox99.Text);
                    ins2 = "UPDATE inventory SET quantity = " + newquantity + " where id=" + id + ";";

                    cmd = new SqlCommand(ins2, cn);
                    a = cmd.ExecuteNonQuery();


                }

                catch (Exception e1235)
                {
                    Response.Write("<script>alert('Error');</script>");
                }
                finally
                {
                    cn.Close();
                    cn2.Close();
                }
            }
        }

        //7
        if (TextBox101.Text != "")
        {
            cn.Open();
            cn2.Open();
            oldquantity = newquantity = id = 0;
            ins = "select * from inventory where id=(" + TextBox101.Text + ");";
            cmd2 = new SqlCommand(ins, cn2);


            dr = cmd2.ExecuteReader();

            if (dr.HasRows == true)
            {

                try
                {
                    if (dr.Read())
                    {
                        oldquantity = int.Parse(dr["quantity"].ToString());
                        id = int.Parse(dr["id"].ToString());
                        dr.Close();
                    }



                    newquantity = oldquantity - int.Parse(TextBox105.Text);
                    ins2 = "UPDATE inventory SET quantity = " + newquantity + " where id=" + id + ";";

                    cmd = new SqlCommand(ins2, cn);
                    a = cmd.ExecuteNonQuery();


                }

                catch (Exception e1235)
                {
                    Response.Write("<script>alert('Error');</script>");
                }
                finally
                {
                    cn.Close();
                    cn2.Close();
                }
            }
        }

        //8
        if (TextBox107.Text != "")
        {
            cn.Open();
            cn2.Open();
            oldquantity = newquantity = id = 0;
            ins = "select * from inventory where id=(" + TextBox107.Text + ");";
            cmd2 = new SqlCommand(ins, cn2);


            dr = cmd2.ExecuteReader();

            if (dr.HasRows == true)
            {

                try
                {
                    if (dr.Read())
                    {
                        oldquantity = int.Parse(dr["quantity"].ToString());
                        id = int.Parse(dr["id"].ToString());
                        dr.Close();
                    }



                    newquantity = oldquantity - int.Parse(TextBox111.Text);
                    ins2 = "UPDATE inventory SET quantity = " + newquantity + " where id=" + id + ";";

                    cmd = new SqlCommand(ins2, cn);
                    a = cmd.ExecuteNonQuery();


                }

                catch (Exception e1235)
                {
                    Response.Write("<script>alert('Error');</script>");
                }
                finally
                {
                    cn.Close();
                    cn2.Close();
                }
            }
        }
        //9
        if (TextBox113.Text != "")
        {
            cn.Open();
            cn2.Open();
            oldquantity = newquantity = id = 0;
            ins = "select * from inventory where id=(" + TextBox113.Text + ");";
            cmd2 = new SqlCommand(ins, cn2);


            dr = cmd2.ExecuteReader();

            if (dr.HasRows == true)
            {

                try
                {
                    if (dr.Read())
                    {
                        oldquantity = int.Parse(dr["quantity"].ToString());
                        id = int.Parse(dr["id"].ToString());
                        dr.Close();
                    }



                    newquantity = oldquantity - int.Parse(TextBox117.Text);
                    ins2 = "UPDATE inventory SET quantity = " + newquantity + " where id=" + id + ";";

                    cmd = new SqlCommand(ins2, cn);
                    a = cmd.ExecuteNonQuery();


                }

                catch (Exception e1235)
                {
                    Response.Write("<script>alert('Error');</script>");
                }
                finally
                {
                    cn.Close();
                    cn2.Close();
                }
            }
        }
        //10
        if (TextBox119.Text != "")
        {
            cn.Open();
            cn2.Open();
            oldquantity = newquantity = id = 0;
            ins = "select * from inventory where id=(" + TextBox119.Text + ");";
            cmd2 = new SqlCommand(ins, cn2);


            dr = cmd2.ExecuteReader();

            if (dr.HasRows == true)
            {

                try
                {
                    if (dr.Read())
                    {
                        oldquantity = int.Parse(dr["quantity"].ToString());
                        id = int.Parse(dr["id"].ToString());
                        dr.Close();
                    }



                    newquantity = oldquantity - int.Parse(TextBox123.Text);
                    ins2 = "UPDATE inventory SET quantity = " + newquantity + " where id=" + id + ";";

                    cmd = new SqlCommand(ins2, cn);
                    a = cmd.ExecuteNonQuery();


                }

                catch (Exception e1235)
                {
                    Response.Write("<script>alert('Error');</script>");
                }
                finally
                {
                    cn.Close();
                    cn2.Close();
                }
            }
        }

    }

    protected void TextBox71_TextChanged(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=NIMBUS\SQLEXPRESS;Initial Catalog=soa;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();



        dataBucket d1 = new dataBucket();

        string ins = "select name, category, brand, sellprice, quantity from inventory where id=(" + TextBox71.Text + ");";

        SqlCommand com = new SqlCommand(ins, cn);

        try
        {
            cn.Open();

            using (SqlDataReader read = com.ExecuteReader())
            {
                while (read.Read())
                {
                    d1.str[1] = (read["name"].ToString());
                    d1.str[2] = (read["category"].ToString());
                    d1.str[3] = (read["brand"].ToString());
                    d1.str[4] = (read["sellprice"].ToString());
                    d1.str[5] = (read["quantity"].ToString());

                }
            }


            cn.Close();

        }
        catch (Exception e123)
        {
            Response.Write("Error Occured");
        }
        finally
        {
            cn.Close();
        }

        TextBox126.Text = d1.str[1];
        TextBox72.Text = d1.str[2];
        TextBox73.Text = d1.str[3];
        TextBox74.Text = d1.str[4];

        int quantity = int.Parse(TextBox75.Text);

        if (int.Parse(d1.str[5]) < quantity)
        {
            Response.Write("<script>alert('Stock not available');</script>");
        }

        TextBox76.Text = (int.Parse(d1.str[4]) * int.Parse(TextBox75.Text)).ToString();



    }

    protected void TextBox77_TextChanged(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=NIMBUS\SQLEXPRESS;Initial Catalog=soa;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();



        dataBucket d1 = new dataBucket();

        string ins = "select name, category, brand, sellprice, quantity from inventory where id=(" + TextBox77.Text + ");";

        SqlCommand com = new SqlCommand(ins, cn);

        try
        {
            cn.Open();

            using (SqlDataReader read = com.ExecuteReader())
            {
                while (read.Read())
                {
                    d1.str[1] = (read["name"].ToString());
                    d1.str[2] = (read["category"].ToString());
                    d1.str[3] = (read["brand"].ToString());
                    d1.str[4] = (read["sellprice"].ToString());
                    d1.str[5] = (read["quantity"].ToString());

                }
            }


            cn.Close();

        }
        catch (Exception e123)
        {
            Response.Write("Error Occured");
        }
        finally
        {
            cn.Close();
        }

        TextBox127.Text = d1.str[1];
        TextBox78.Text = d1.str[2];
        TextBox79.Text = d1.str[3];
        TextBox80.Text = d1.str[4];

        int quantity = int.Parse(TextBox81.Text);

        if (int.Parse(d1.str[5]) < quantity)
        {
            Response.Write("<script>alert('Stock not available');</script>");
        }

        TextBox82.Text = (int.Parse(d1.str[4]) * int.Parse(TextBox81.Text)).ToString();

    }

    protected void TextBox83_TextChanged(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=NIMBUS\SQLEXPRESS;Initial Catalog=soa;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();



        dataBucket d1 = new dataBucket();

        string ins = "select name, category, brand, sellprice, quantity from inventory where id=(" + TextBox83.Text + ");";

        SqlCommand com = new SqlCommand(ins, cn);

        try
        {
            cn.Open();

            using (SqlDataReader read = com.ExecuteReader())
            {
                while (read.Read())
                {
                    d1.str[1] = (read["name"].ToString());
                    d1.str[2] = (read["category"].ToString());
                    d1.str[3] = (read["brand"].ToString());
                    d1.str[4] = (read["sellprice"].ToString());
                    d1.str[5] = (read["quantity"].ToString());

                }
            }


            cn.Close();

        }
        catch (Exception e123)
        {
            Response.Write("Error Occured");
        }
        finally
        {
            cn.Close();
        }

        TextBox128.Text = d1.str[1];
        TextBox84.Text = d1.str[2];
        TextBox85.Text = d1.str[3];
        TextBox86.Text = d1.str[4];

        int quantity = int.Parse(TextBox87.Text);

        if (int.Parse(d1.str[5]) < quantity)
        {
            Response.Write("<script>alert('Stock not available');</script>");
        }

        TextBox88.Text = (int.Parse(d1.str[4]) * int.Parse(TextBox87.Text)).ToString();
    }

    protected void TextBox89_TextChanged(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=NIMBUS\SQLEXPRESS;Initial Catalog=soa;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();



        dataBucket d1 = new dataBucket();

        string ins = "select name, category, brand, sellprice, quantity from inventory where id=(" + TextBox89.Text + ");";

        SqlCommand com = new SqlCommand(ins, cn);

        try
        {
            cn.Open();

            using (SqlDataReader read = com.ExecuteReader())
            {
                while (read.Read())
                {
                    d1.str[1] = (read["name"].ToString());
                    d1.str[2] = (read["category"].ToString());
                    d1.str[3] = (read["brand"].ToString());
                    d1.str[4] = (read["sellprice"].ToString());
                    d1.str[5] = (read["quantity"].ToString());

                }
            }


            cn.Close();

        }
        catch (Exception e123)
        {
            Response.Write("Error Occured");
        }
        finally
        {
            cn.Close();
        }

        TextBox129.Text = d1.str[1];
        TextBox90.Text = d1.str[2];
        TextBox91.Text = d1.str[3];
        TextBox92.Text = d1.str[4];

        int quantity = int.Parse(TextBox93.Text);

        if (int.Parse(d1.str[5]) < quantity)
        {
            Response.Write("<script>alert('Stock not available');</script>");
        }

        TextBox94.Text = (int.Parse(d1.str[4]) * int.Parse(TextBox93.Text)).ToString();
    }

    protected void TextBox95_TextChanged(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=NIMBUS\SQLEXPRESS;Initial Catalog=soa;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();



        dataBucket d1 = new dataBucket();

        string ins = "select name, category, brand, sellprice, quantity from inventory where id=(" + TextBox95.Text + ");";

        SqlCommand com = new SqlCommand(ins, cn);

        try
        {
            cn.Open();

            using (SqlDataReader read = com.ExecuteReader())
            {
                while (read.Read())
                {
                    d1.str[1] = (read["name"].ToString());
                    d1.str[2] = (read["category"].ToString());
                    d1.str[3] = (read["brand"].ToString());
                    d1.str[4] = (read["sellprice"].ToString());
                    d1.str[5] = (read["quantity"].ToString());

                }
            }


            cn.Close();

        }
        catch (Exception e123)
        {
            Response.Write("Error Occured");
        }
        finally
        {
            cn.Close();
        }

        TextBox130.Text = d1.str[1];
        TextBox96.Text = d1.str[2];
        TextBox97.Text = d1.str[3];
        TextBox98.Text = d1.str[4];

        int quantity = int.Parse(TextBox99.Text);

        if (int.Parse(d1.str[5]) < quantity)
        {
            Response.Write("<script>alert('Stock not available');</script>");
        }

        TextBox100.Text = (int.Parse(d1.str[4]) * int.Parse(TextBox99.Text)).ToString();
    }

    protected void TextBox101_TextChanged(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=NIMBUS\SQLEXPRESS;Initial Catalog=soa;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();



        dataBucket d1 = new dataBucket();

        string ins = "select name, category, brand, sellprice, quantity from inventory where id=(" + TextBox101.Text + ");";

        SqlCommand com = new SqlCommand(ins, cn);

        try
        {
            cn.Open();

            using (SqlDataReader read = com.ExecuteReader())
            {
                while (read.Read())
                {
                    d1.str[1] = (read["name"].ToString());
                    d1.str[2] = (read["category"].ToString());
                    d1.str[3] = (read["brand"].ToString());
                    d1.str[4] = (read["sellprice"].ToString());
                    d1.str[5] = (read["quantity"].ToString());

                }
            }


            cn.Close();

        }
        catch (Exception e123)
        {
            Response.Write("Error Occured");
        }
        finally
        {
            cn.Close();
        }

        TextBox131.Text = d1.str[1];
        TextBox102.Text = d1.str[2];
        TextBox103.Text = d1.str[3];
        TextBox104.Text = d1.str[4];

        int quantity = int.Parse(TextBox105.Text);

        if (int.Parse(d1.str[5]) < quantity)
        {
            Response.Write("<script>alert('Stock not available');</script>");
        }

        TextBox106.Text = (int.Parse(d1.str[4]) * int.Parse(TextBox105.Text)).ToString();
    }

    protected void TextBox107_TextChanged(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=NIMBUS\SQLEXPRESS;Initial Catalog=soa;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();



        dataBucket d1 = new dataBucket();

        string ins = "select name, category, brand, sellprice, quantity from inventory where id=(" + TextBox107.Text + ");";

        SqlCommand com = new SqlCommand(ins, cn);

        try
        {
            cn.Open();

            using (SqlDataReader read = com.ExecuteReader())
            {
                while (read.Read())
                {
                    d1.str[1] = (read["name"].ToString());
                    d1.str[2] = (read["category"].ToString());
                    d1.str[3] = (read["brand"].ToString());
                    d1.str[4] = (read["sellprice"].ToString());
                    d1.str[5] = (read["quantity"].ToString());

                }
            }


            cn.Close();

        }
        catch (Exception e123)
        {
            Response.Write("Error Occured");
        }
        finally
        {
            cn.Close();
        }

        TextBox132.Text = d1.str[1];
        TextBox108.Text = d1.str[2];
        TextBox109.Text = d1.str[3];
        TextBox110.Text = d1.str[4];

        int quantity = int.Parse(TextBox111.Text);

        if (int.Parse(d1.str[5]) < quantity)
        {
            Response.Write("<script>alert('Stock not available');</script>");
        }

        TextBox112.Text = (int.Parse(d1.str[4]) * int.Parse(TextBox111.Text)).ToString();
    }

    protected void TextBox113_TextChanged(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=NIMBUS\SQLEXPRESS;Initial Catalog=soa;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();



        dataBucket d1 = new dataBucket();

        string ins = "select name, category, brand, sellprice, quantity from inventory where id=(" + TextBox113.Text + ");";

        SqlCommand com = new SqlCommand(ins, cn);

        try
        {
            cn.Open();

            using (SqlDataReader read = com.ExecuteReader())
            {
                while (read.Read())
                {
                    d1.str[1] = (read["name"].ToString());
                    d1.str[2] = (read["category"].ToString());
                    d1.str[3] = (read["brand"].ToString());
                    d1.str[4] = (read["sellprice"].ToString());
                    d1.str[5] = (read["quantity"].ToString());

                }
            }


            cn.Close();

        }
        catch (Exception e123)
        {
            Response.Write("Error Occured");
        }
        finally
        {
            cn.Close();
        }

        TextBox133.Text = d1.str[1];
        TextBox114.Text = d1.str[2];
        TextBox115.Text = d1.str[3];
        TextBox116.Text = d1.str[4];

        int quantity = int.Parse(TextBox117.Text);

        if (int.Parse(d1.str[5]) < quantity)
        {
            Response.Write("<script>alert('Stock not available');</script>");
        }

        TextBox118.Text = (int.Parse(d1.str[4]) * int.Parse(TextBox117.Text)).ToString();
    }

    protected void TextBox119_TextChanged(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=NIMBUS\SQLEXPRESS;Initial Catalog=soa;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();



        dataBucket d1 = new dataBucket();

        string ins = "select name, category, brand, sellprice, quantity from inventory where id=(" + TextBox119.Text + ");";

        SqlCommand com = new SqlCommand(ins, cn);

        try
        {
            cn.Open();

            using (SqlDataReader read = com.ExecuteReader())
            {
                while (read.Read())
                {
                    d1.str[1] = (read["name"].ToString());
                    d1.str[2] = (read["category"].ToString());
                    d1.str[3] = (read["brand"].ToString());
                    d1.str[4] = (read["sellprice"].ToString());
                    d1.str[5] = (read["quantity"].ToString());

                }
            }


            cn.Close();

        }
        catch (Exception e123)
        {
            Response.Write("Error Occured");
        }
        finally
        {
            cn.Close();
        }

        TextBox134.Text = d1.str[1];
        TextBox120.Text = d1.str[2];
        TextBox121.Text = d1.str[3];
        TextBox122.Text = d1.str[4];

        int quantity = int.Parse(TextBox123.Text);

        if (int.Parse(d1.str[5]) < quantity)
        {
            Response.Write("<script>alert('Stock not available');</script>");
        }

        TextBox124.Text = (int.Parse(d1.str[4]) * int.Parse(TextBox123.Text)).ToString();
    }

   
}