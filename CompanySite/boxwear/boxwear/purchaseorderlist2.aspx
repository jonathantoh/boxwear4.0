<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="purchaseorderlist2.aspx.cs" Inherits="boxwear.purchaseorderlist2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <center>
    <asp:Image ID="Image1" runat="server" Height="130px" ImageUrl="~/images/logo.JPG" Width="269px" />
    </center>
        
    <p class="text-center">
        <strong><span class="auto-style1">Order Status: </span></strong>&nbsp;<asp:DropDownList ID="ddlStatus" runat="server" Width="113px" AutoPostBack="True" OnSelectedIndexChanged="ddlStatus_SelectedIndexChanged">
            <asp:ListItem Selected="True">All</asp:ListItem>
            <asp:ListItem>Pending</asp:ListItem>
            <asp:ListItem>Received</asp:ListItem>
            <asp:ListItem>Fulfilled</asp:ListItem>
        </asp:DropDownList>
    </p>

  

    

    <div class="text-center">

  

    

    <asp:GridView ID="gvPurchase" runat="server" Height="174px" Width="1021px" AutoGenerateColumns="False" BorderColor="Black" DataKeyNames="PoID" ForeColor="Black" style="margin-left : 120px; " CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header" RowStyle-CssClass="rows">
        <Columns>
            <asp:BoundField DataField="PoID" HeaderText="Purchase Order ID" />
            <asp:BoundField DataField="PoStatus" HeaderText="Status" />
            <asp:BoundField DataField="PoTotalAmt" HeaderText="Total Amount" />
            <asp:BoundField DataField="CompanyName" HeaderText="Company " />
            <asp:BoundField DataField="SupplierName" HeaderText="Supplier" />
            <asp:CommandField ShowSelectButton="True" />
        </Columns>

<HeaderStyle CssClass="header"></HeaderStyle>

<PagerStyle CssClass="pager"></PagerStyle>

<RowStyle CssClass="rows"></RowStyle>
    </asp:GridView>
      

    </div>
      

    <br />
    <p class="text-center">
        <asp:Button ID="btnRaise" runat="server" Text="Raise Purchase Order" Height="52px" Width="228px" style="background-color: #4CAF50;  color: white; border-radius: 12px;" />&nbsp;&nbsp;
        <asp:Button ID="btnNum" runat="server" Height="47px" OnClick="btnNum_Click" Text="Generate PO Number" Width="175px" />
     </p>
</asp:Content>
