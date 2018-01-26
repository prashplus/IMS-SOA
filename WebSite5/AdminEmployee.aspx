<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="AdminEmployee.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="CSS/AdminEmployee.css" rel="stylesheet" />
    <style type="text/css">
        
        .auto-style1 {
            position: absolute;
            right: 50px;
            top: 10px;
            width: 397px;
        }
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="div">
        <asp:Label ID="Label1" runat="server" Text="Employee ID :" CssClass="label2" Width="150px"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="textbox1"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" CssClass="button1" Text="Search" />
        <asp:DetailsView ID="DetailsView1" CssClass="auto-style1" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Height="50px" AutoGenerateRows="False" DataSourceID="SqlDataSource1">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <Fields>
                <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="designation" HeaderText="designation" SortExpression="designation" />
                <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                <asp:BoundField DataField="mobileno" HeaderText="mobileno" SortExpression="mobileno" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
            </Fields>
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        </asp:DetailsView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:soaConnectionString %>" SelectCommand="SELECT * FROM [employee] WHERE ([id] = @id)">
            <SelectParameters>
                <asp:ControlParameter ControlID="TextBox1" DefaultValue="1" Name="id" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <br />
    </div>  
    <div class="div">
        <asp:Label ID="Label3" runat="server" Text="Employee Name :" CssClass="label2" Width="150px"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" CssClass="textbox1"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="Address :" CssClass="label2"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" CssClass="textbox1"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Designation :" CssClass="label2" Width="150px"></asp:Label>
        <asp:TextBox ID="TextBox8" runat="server" Height="26px" Width="204px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="Mobile No. :" CssClass="label2"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" CssClass="textbox1"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" CssClass="button1" Text="Add Employee" Width="150px" OnClick="Button2_Click" />
        <br />
        <div style="width:432px;display:inline-block;">

            </div>
        <asp:Label ID="Label6" runat="server" Text="Email :" CssClass="label2"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" CssClass="textbox1"></asp:TextBox>
        
    </div>
    <div class="div">
            
        <asp:Label ID="Label8" runat="server" Text="Employee ID :" CssClass="label2"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server" CssClass="textbox1"></asp:TextBox>
        <asp:Button ID="Button3" runat="server" CssClass="button1" Text="Remove Employee" Width="160px" OnClick="Button3_Click" />
            
        </div>
</asp:Content>

