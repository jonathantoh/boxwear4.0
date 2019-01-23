<%@ Page Title="" Language="C#" MasterPageFile="~/supplier-MasterPage.Master" AutoEventWireup="true" CodeBehind="viewinvoice.aspx.cs" Inherits="thebigfour.viewinvoice" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h1 class="auto-style1"><strong>Invoice List</strong></h1>
    <center>
    <asp:GridView ID="gvInvoice" runat="server" OnSelectedIndexChanged="gvInvoice_SelectedIndexChanged" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" Height="261px" Width="929px">
        <Columns>
            <asp:BoundField DataField="InvoiceID" HeaderText="Invoice ID" />
            <asp:BoundField DataField="InvoiceDate" HeaderText="Date" />
            <asp:BoundField DataField="InvoiceAmt" HeaderText="Amount" />
            <asp:BoundField DataField="InvoiceStatus" HeaderText="Status" />
            <asp:CommandField ShowSelectButton="True" />
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
</asp:Content>
