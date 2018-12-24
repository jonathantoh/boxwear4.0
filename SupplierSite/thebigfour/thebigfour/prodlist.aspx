<%@ Page Title="" Language="C#" MasterPageFile="~/supplier-MasterPage.Master" AutoEventWireup="true" CodeBehind="prodlist.aspx.cs" Inherits="thebigfour.prodlist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <center>
    <asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="False" Height="217px" Width="1034px">
        <Columns>
            <asp:BoundField DataField="ProductID" HeaderText="Product ID" />
            <asp:BoundField DataField="ProductName" HeaderText="Name" />
            <asp:ImageField DataImageUrlField="ProductImage" HeaderText="Image">
            </asp:ImageField>
            <asp:BoundField DataField="ProductDesc" HeaderText="Description" />
            <asp:BoundField DataField="UnitPrice" DataFormatString="{0:C}" HeaderText="Unit Price" />
        </Columns>
    </asp:GridView>
        <br />
        </center>
</asp:Content>
