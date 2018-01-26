<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Employee.aspx.cs" Inherits="Employee" %>

<!DOCTYPE html>
<link href="CSS/Employee.css" rel="stylesheet" />
<link href="CSS/MainMaster.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    
    <style type="text/css">
      
        .auto-style1 {
            text-align: center;
        }
      
    </style>

    
</head>
<body>
    <form id="form1" runat="server">
         <div class="topnav" id="myTopnav">
             <a class="logout" href="Home.aspx">Log Out</a>
            </div>
        
        <br />
         &nbsp;&nbsp;
         <asp:Label ID="Label17" runat="server" Text="Date :" CssClass="label3" Font-Size="30px"></asp:Label>
         <asp:Label ID="Label18" runat="server" CssClass="label3" Font-Size="20px" Width="300px"></asp:Label>
         <br />
         <br />
        <br />
        <asp:Label ID="Label14" runat="server" Text="Item ID" CssClass="label1" Width="10%"></asp:Label>
        <asp:Label ID="Label15" runat="server" Text="Item Name" CssClass="label1" Width="34%"></asp:Label>
        <asp:Label ID="Label7" runat="server" Text="Category" CssClass="label1" Width="10%"></asp:Label>
        <asp:Label ID="Label9" runat="server" Text="Brand" CssClass="label1" Width="10%"></asp:Label>
        <asp:Label ID="Label11" runat="server" Text="Price" CssClass="label1" Width="10%"></asp:Label>
        <asp:Label ID="Label12" runat="server" Text="Quantity" CssClass="label1" Width="10.5%"></asp:Label>
        <asp:Label ID="Label13" runat="server" Text="Total" CssClass="label1" Width="8%"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox68" runat="server" Width="10%" CssClass="textbox1" AutoPostBack="True" OnTextChanged="TextBox68_TextChanged"></asp:TextBox>
        <asp:TextBox ID="TextBox125" runat="server" Width="34%" CssClass="textbox1" ></asp:TextBox>
        <asp:TextBox ID="TextBox36" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox37" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox69" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox70" runat="server" Width="10%" CssClass="textbox1" AutoPostBack="True"></asp:TextBox>
        <asp:TextBox ID="TextBox34" runat="server" Width="8%" CssClass="textbox1"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox71" runat="server" Width="10%" CssClass="textbox1" AutoPostBack="True" OnTextChanged="TextBox71_TextChanged"></asp:TextBox>
        <asp:TextBox ID="TextBox126" runat="server" Width="34%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox72" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox73" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox74" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox75" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox76" runat="server" Width="8%" CssClass="textbox1"></asp:TextBox>
         <br />
        <asp:TextBox ID="TextBox77" runat="server" Width="10%" CssClass="textbox1" AutoPostBack="True" OnTextChanged="TextBox77_TextChanged"></asp:TextBox>
        <asp:TextBox ID="TextBox127" runat="server" Width="34%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox78" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox79" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox80" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox81" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox82" runat="server" Width="8%" CssClass="textbox1"></asp:TextBox>
         <br />
        <asp:TextBox ID="TextBox83" runat="server" Width="10%" CssClass="textbox1" AutoPostBack="True" OnTextChanged="TextBox83_TextChanged"></asp:TextBox>
        <asp:TextBox ID="TextBox128" runat="server" Width="34%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox84" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox85" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox86" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox87" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox88" runat="server" Width="8%" CssClass="textbox1"></asp:TextBox>
         <br />
        <asp:TextBox ID="TextBox89" runat="server" Width="10%" CssClass="textbox1" AutoPostBack="True" OnTextChanged="TextBox89_TextChanged"></asp:TextBox>
        <asp:TextBox ID="TextBox129" runat="server" Width="34%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox90" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox91" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox92" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox93" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox94" runat="server" Width="8%" CssClass="textbox1"></asp:TextBox>
         <br />
        <asp:TextBox ID="TextBox95" runat="server" Width="10%" CssClass="textbox1" AutoPostBack="True" OnTextChanged="TextBox95_TextChanged"></asp:TextBox>
        <asp:TextBox ID="TextBox130" runat="server" Width="34%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox96" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox97" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox98" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox99" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox100" runat="server" Width="8%" CssClass="textbox1"></asp:TextBox>
         <br />
        <asp:TextBox ID="TextBox101" runat="server" Width="10%" CssClass="textbox1" AutoPostBack="True" OnTextChanged="TextBox101_TextChanged"></asp:TextBox>
        <asp:TextBox ID="TextBox131" runat="server" Width="34%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox102" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox103" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox104" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox105" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox106" runat="server" Width="8%" CssClass="textbox1"></asp:TextBox>
         <br />
        <asp:TextBox ID="TextBox107" runat="server" Width="10%" CssClass="textbox1" AutoPostBack="True" OnTextChanged="TextBox107_TextChanged"></asp:TextBox>
        <asp:TextBox ID="TextBox132" runat="server" Width="34%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox108" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox109" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox110" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox111" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox112" runat="server" Width="8%" CssClass="textbox1"></asp:TextBox>
         <br />
        <asp:TextBox ID="TextBox113" runat="server" Width="10%" CssClass="textbox1" AutoPostBack="True" OnTextChanged="TextBox113_TextChanged"></asp:TextBox>
        <asp:TextBox ID="TextBox133" runat="server" Width="34%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox114" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox115" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox116" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox117" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox118" runat="server" Width="8%" CssClass="textbox1"></asp:TextBox>
         <br />
        <asp:TextBox ID="TextBox119" runat="server" Width="10%" CssClass="textbox1" AutoPostBack="True" OnTextChanged="TextBox119_TextChanged"></asp:TextBox>
        <asp:TextBox ID="TextBox134" runat="server" Width="34%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox120" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox121" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox122" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox123" runat="server" Width="10%" CssClass="textbox1"></asp:TextBox>
        <asp:TextBox ID="TextBox124" runat="server" Width="8%" CssClass="textbox1"></asp:TextBox>
         <br />
         <br />
        <asp:TextBox ID="TextBox65" runat="server" CssClass="textbox2"></asp:TextBox>
        <br />
        &nbsp;&nbsp;
        <asp:Label ID="Label8" runat="server" Text="Total" CssClass="label2"></asp:Label>
         <strong>
         <asp:Button ID="Button1" runat="server" Height="47px" OnClick="Button1_Click" Text="Check Out" Width="213px" />
         </strong>
         <p>
&nbsp;
         </p>
         <p class="auto-style1">
             <asp:Button ID="Button2" runat="server" Height="36px" Text="Print" Width="125px" OnClientClick="javascript:window.print();" Visible="False" />
         </p>
    </form>
</body>
</html>
