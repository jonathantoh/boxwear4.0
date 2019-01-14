<%@ Page Title="" Language="C#" MasterPageFile="~/supplier-MasterPage.Master" AutoEventWireup="true" CodeBehind="customerorders.aspx.cs" Inherits="thebigfour.customerorders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 0px;
        }
        .auto-style2 {
            font-size: xx-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center">
        <h1><strong><span class="auto-style2">View All Customer Orders</span><br />
            </strong></h1>
        <br />
        <br />
        <center>
        <asp:GridView ID="gvCustomer" runat="server" Height="248px" Width="1046px" AutoGenerateColumns="False" CssClass="auto-style1" DataKeyNames="CoNum" OnSelectedIndexChanged="gvCustomer_SelectedIndexChanged" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
            <Columns>
                <asp:BoundField DataField="CoNum" HeaderText="Customer Order ID" />
                <asp:BoundField DataField="PoNum" HeaderText="Purchase Order ID" />
                <asp:BoundField DataField="CoOrderDate" HeaderText="Order Date" />
                <asp:BoundField DataField="CoTotalAmt" HeaderText="Total" />
                <asp:BoundField DataField="CoOrderStatus" HeaderText="Status" />
                <asp:BoundField DataField="BillingAddress" HeaderText="Address" />
                <asp:BoundField DataField="CompanyName" HeaderText="Company" />
                <asp:CommandField SelectText="View" ShowSelectButton="True" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
            </center>
    </div>
</asp:Content>
