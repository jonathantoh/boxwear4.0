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
            width: 508px;
            height: 262px;
            position: absolute;
            top: 86px;
            left: 356px;
            z-index: 1;
        }
        .auto-style3 {
            text-align: center;
            font-size: xx-large;
            height: 86px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="auto-style1"><span class="newStyle2"><strong>Product Catalogue </strong></span> </h1>
    <p class="auto-style1">&nbsp;</p>
    <p class="auto-style3">&nbsp;</p>
    <center>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server" CssClass="auto-style2" Visible="False">
            Product ID :&nbsp;
            <asp:Label ID="lblProdId" runat="server"></asp:Label>
            <br />
            <br />
            Product Name :
            <asp:Label ID="lblName" runat="server"></asp:Label>
           
            <br />
           
            <br />
            Product Description:&nbsp;
            <asp:Label ID="lblDesc" runat="server"></asp:Label>
            <br />
            <br />
            Price:
            <asp:Label ID="lblPrice" runat="server"></asp:Label>
            <br />
            <br />
            Quantity :
            <asp:TextBox ID="tbQuantity" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btnReturn" runat="server" Height="31px" OnClick="btnReturn_Click" Text="Return" Width="83px" />
            &nbsp;
            <asp:Button ID="btnNext" runat="server" Height="32px" OnClick="btnNext_Click" Text="Next" Width="75px" />
        </asp:Panel>
        
    <asp:GridView ID="gvProduct" runat="server" AutoGenerateColumns="False" Height="192px" Width="774px" OnSelectedIndexChanged="gvProduct_SelectedIndexChanged">
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
        <RowStyle Height="50px" Width="50px" />
    </asp:GridView>
        <br />
        <br />
        <br />
        <br />
        <br />
        
        </center>

</asp:Content>
