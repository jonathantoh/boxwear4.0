<%@ Page Title="" Language="C#" MasterPageFile="~/delivery.Master" AutoEventWireup="true" CodeBehind="deliverydetails.aspx.cs" Inherits="judovan.deliverydetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <header id="header">
      <div class="container">
        <div class="row">
          <div class="col-md-10">
            <h1><span class="glyphicon glyphicon-tasks" style="color:#ff7f50" aria-hidden="true"></span> Delivery Orders <small>Manage Your Orders</small></h1>
          </div>
          <div class="col-md-2">
            <div class="dropdown create">
              <button class="btn btn-default dropdown-toggle" type="button" id="dropdownMenu1" data-toggle="dropdown" aria-haspopup="true" aria-expanded="true">
                Create Content
                <span class="caret"></span>
              </button>
              <ul class="dropdown-menu" aria-labelledby="dropdownMenu1">
                <li><a type="button" data-toggle="modal" data-target="#addPage">Add Page</a></li>
                <li><a href="#">Add Post</a></li>
                <li><a href="#">Add User</a></li>
              </ul>
            </div>
          </div>
        </div>
      </div>
    </header>

    <section id="breadcrumb">
      <div class="container">
        <ol class="breadcrumb">
          <li class="active">Delivery Orders</li>
        </ol>
      </div>
    </section>

    <center>
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
            <HeaderStyle BackColor="#ff7f50" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>

    <%--<asp:GridView ID="gvDelivery" runat="server" AutoGenerateColumns="False" Height="212px" Width="954px" OnSelectedIndexChanged="gvPurchase_SelectedIndexChanged" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" >
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
        </asp:GridView>--%>
        </center>
</asp:Content>
