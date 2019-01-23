<%@ Page Title="" Language="C#" MasterPageFile="~/supplier-MasterPage.Master" AutoEventWireup="true" CodeBehind="viewAllDelivery.aspx.cs" Inherits="thebigfour.viewAllDelivery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="breadcrumb">
      <div class="container">
        <ol class="breadcrumb" style="margin-top:20px;padding:80px;font-size:20px;">
          <li class="main-color-bg">View All Delivery <span class="glyphicon glyphicon-send"></span></li>
            <li class="main-color-bg">See all delivery orders</li>
        </ol>
          
      </div>
    </section>
    <center>
        <p class="text-center">
        <strong><span class="auto-style1">Delivery Status: </span></strong>&nbsp;<asp:DropDownList ID="ddlStatus" runat="server" Width="113px" AutoPostBack="True" OnSelectedIndexChanged="ddlStatus_SelectedIndexChanged">
            <asp:ListItem Selected="True">All</asp:ListItem>
            <asp:ListItem>Processing</asp:ListItem>
            <asp:ListItem>In Transit</asp:ListItem>
            <asp:ListItem>Delivered</asp:ListItem>
        </asp:DropDownList>
    </p>

        <asp:GridView ID="gvDelivery" runat="server" AutoGenerateColumns="False" Height="212px" Width="954px" OnSelectedIndexChanged="gvPurchase_SelectedIndexChanged" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" >
            <Columns>
                <asp:BoundField DataField="trackingID" HeaderText="TrackingID" />
                <asp:BoundField DataField="weight" HeaderText="Weight" />
                <asp:BoundField DataField="deliveryStatus" HeaderText="Status" />
                <asp:BoundField DataField="PoID" HeaderText="PO ID" />
                <asp:BoundField DataField="dateRegistered" HeaderText="Date Registered" />
                <asp:BoundField DataField="deliveryType" HeaderText="Type" />
                <asp:BoundField DataField="InvoiceID" HeaderText="Invoice" />

                <asp:CommandField ShowSelectButton="True" />
                <asp:CommandField DeleteText="Reject" ShowDeleteButton="True" />
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
</asp:Content>
