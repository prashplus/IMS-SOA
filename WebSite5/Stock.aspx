<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="Stock.aspx.cs" Inherits="Stock" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="position:absolute;left:25%;top:20%"> 
       <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None" Height="517px" Width="901px">
           <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
           <Columns>
               <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
               <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
               <asp:BoundField DataField="brand" HeaderText="brand" SortExpression="brand" />
               <asp:BoundField DataField="category" HeaderText="category" SortExpression="category" />
               <asp:BoundField DataField="costprice" HeaderText="costprice" SortExpression="costprice" />
               <asp:BoundField DataField="sellprice" HeaderText="sellprice" SortExpression="sellprice" />
               <asp:BoundField DataField="weight" HeaderText="weight" SortExpression="weight" />
               <asp:BoundField DataField="quantity" HeaderText="quantity" SortExpression="quantity" />
           </Columns>
    
           <EditRowStyle BackColor="#999999" />
           <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
           <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
           <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
           <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
           <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
           <SortedAscendingCellStyle BackColor="#E9E7E2" />
           <SortedAscendingHeaderStyle BackColor="#506C8C" />
           <SortedDescendingCellStyle BackColor="#FFFDF8" />
           <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    
       </asp:GridView>
       <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:soaConnectionString %>" SelectCommand="SELECT * FROM [inventory] ORDER BY [id]"></asp:SqlDataSource>
</div>
</asp:Content>

