<%@ Page Title="" Language="C#" MasterPageFile="~/supplier-MasterPage.Master" AutoEventWireup="true" CodeBehind="viewCO.aspx.cs" Inherits="thebigfour.viewCO" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .newStyle1 {
            font-size: x-large;
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
        }
        .newStyle2 {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
        }
        .auto-style1 {
            font-size: xx-large;
        }
        .auto-style2 {
            width: 601px;
            font-size: medium;
        }
        .auto-style3 {
            width: 601px;
            text-align: right;
        }
        .auto-style4 {
            font-size: medium;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center">
        <br />
        <br />
        <h1 class="auto-style1"><strong>View Customer Orders</strong></h1>
       
        <br />
        <table class="nav-justified">
            <tr>
                <td class="auto-style2"><strong>Company : </strong></td>
                <td class="auto-style4"><strong>Supplier : </strong></td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Image ID="Image1" runat="server" Height="128px" ImageUrl="supplier-images/boxwear-1.png" Width="399px" />
                </td>
                <td class="text-left">
                    <asp:Image ID="Image2" runat="server" Height="116px" ImageUrl="supplier-images/co.jpg" Width="344px" />
                </td>
            </tr>
        </table>
       
        <br />
        <h1 class="auto-style1"><strong>Products and Descriptions</strong></h1>
        <center>
        <asp:GridView ID="gvCustOrder" runat="server" Height="191px" Width="956px" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
            <Columns>
                <asp:BoundField DataField="ProductID" HeaderText="Product ID" />
                <asp:BoundField DataField="ProdDesc" HeaderText="Description" />
                <asp:BoundField DataField="ProductQty" HeaderText="Quantity" />
                <asp:BoundField DataField="UnitPrice" HeaderText="Unit Price" />
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
        </center>

    </div>
</asp:Content>
