<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ProductCatalogue.aspx.cs" Inherits="boxwear.ProductCatalogue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .newStyle1 {
            font-family: "Bradley Hand ITC";
        }
        .newStyle2 {
            font-family: "Bahnschrift SemiBold Condensed";
        }
        .auto-style1 {
            text-align: center;
            font-size: xx-large;
        }
        .auto-style2 {
            width: 309px;
            height: 364px;
            position: absolute;
            top: 164px;
            left: 843px;
            z-index: 1;
        }
        .auto-style3 {
            margin-top: 0px;
        }
        .auto-style4 {
            margin-top: 0;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="auto-style1"><strong>Product Catalogue&nbsp;</strong></h1>
    <p class="auto-style1">&nbsp;</p>
        
    <div class="text-center">
        
    <asp:GridView ID="gvProduct" runat="server" AutoGenerateColumns="False" Height="192px" Width="720px" OnSelectedIndexChanged="gvProduct_SelectedIndexChanged" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" CssClass="auto-style3" ForeColor="Black" GridLines="Horizontal">
        <Columns>
            <asp:BoundField DataField="ProductID" HeaderText="Product ID" />
            <asp:BoundField DataField="ProductName" HeaderText="Name" />
            <asp:ImageField DataImageUrlField="ProductImage" HeaderText="Image">
                <ItemStyle Height="20px" Width="20px" />
            </asp:ImageField>
            <asp:BoundField DataField="ProductDesc" HeaderText="Description" />
            <asp:BoundField DataField="UnitPrice" HeaderText="Unit Price" />
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle Height="50px" Width="50px" />
        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#242121" />
    </asp:GridView>
    
        </div>
    
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server" CssClass="auto-style2" Visible="False">
            <br />
            Product ID :&nbsp;
            <asp:Label ID="lblProdId" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            Product Name :
            <asp:Label ID="lblName" runat="server"></asp:Label>
           
            <br />
           
            <br />
           
            <br />
            Product Description:&nbsp;
            <asp:Label ID="lblDesc" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            Price:
            <asp:Label ID="lblPrice" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            Quantity :
            <asp:TextBox ID="tbQuantity" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            &nbsp;
            <asp:Button ID="btnNext" runat="server" Height="32px" OnClick="btnNext_Click" Text="Next" Width="297px" CssClass="auto-style4" />
            &nbsp;&nbsp;
        </asp:Panel>
        
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        <br />
        <br />
        <br />
        <br />
        <br />
        
     

</asp:Content>
