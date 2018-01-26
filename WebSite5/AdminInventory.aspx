<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="AdminInventory.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="CSS/AdminInventory.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
            height: 499px;
        }
        .auto-style2 {
            font-family: Calibri;
            font-size: 16px;
            text-align: left;
            padding: 4px 4px;
            margin-bottom: 8px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="auto-style1" >
        <br />
        <asp:Label ID="Label1" runat="server" Text="Item Name :" CssClass="label2"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="textbox1" ></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Brand :" CssClass="label2"></asp:Label>
        <asp:TextBox ID="TextBox4" CssClass="auto-style2" runat="server" Width="201px"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Category :" CssClass="label2"></asp:Label>
        <asp:TextBox ID="TextBox5" CssClass="auto-style2" runat="server" Width="201px"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Costprice :" CssClass="label2"></asp:Label>
        <asp:TextBox ID="TextBox6" CssClass="auto-style2" runat="server" Width="201px"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Sellprice :" CssClass="label2"></asp:Label>
        <asp:TextBox ID="TextBox7" CssClass="auto-style2" runat="server" Width="201px"></asp:TextBox>
        <br />
        <asp:Label ID="Label8" runat="server" Text="Weight :" CssClass="label2"></asp:Label>
        <asp:TextBox ID="TextBox8" CssClass="auto-style2" runat="server" Width="201px"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Quantity :" CssClass="label2"></asp:Label>
        <asp:TextBox ID="TextBox3" CssClass="auto-style2" runat="server" Width="201px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Add" CssClass="button1" OnClick="Button1_Click" />
        </div>
</asp:Content>

