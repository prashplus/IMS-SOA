<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="CSS/Login.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="maindiv"> 
     
        <div class="adminlogindiv" >
            <asp:Label ID="Label5" runat="server" CssClass="label1" Text="Admin Login"></asp:Label>
            <br />
            <br />
        
        <asp:Label ID="Label1" runat="server" Text="Username :" CssClass="label3"></asp:Label>
     &nbsp;<asp:TextBox ID="TextBox3" runat="server" CssClass="textbox2"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Password :" CssClass="label3"></asp:Label>
        &nbsp;<asp:TextBox ID="TextBox4" runat="server" CssClass="textbox2" TextMode="Password"></asp:TextBox>
            <br />
            <br />
        <asp:Button ID="Button1" runat="server" Text="Log In" CssClass="button2" OnClick="Button1_Click" />
        </div>
        <div class="emplogindiv">
            <asp:Label ID="Label6" runat="server" CssClass="label1" Text="Employee Login"></asp:Label>
            <br />
            <br />
        
        <asp:Label ID="Label7" runat="server" Text="Username :" CssClass="label3"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server" CssClass="textbox2"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Text="Password :" CssClass="label3"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" CssClass="textbox2" TextMode="Password"></asp:TextBox>
            <br />
            <br />
        <asp:Button ID="Button2" runat="server" Text="Log In" CssClass="button2" OnClick="Button2_Click" />
            <br />
    
        </div>
        
            <br />
        <br />
        <br />

    </div>
</asp:Content>

