<%@ Page Title="" Language="C#" MasterPageFile="~/supplier-MasterPage.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="thebigfour._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllPurchaseOrder" TypeName="thebigfour.DAL.DalViewPurchaseOrder"></asp:ObjectDataSource>
    <br />
    <br />
    <br />
    
    
    <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" Height="110px" Width="955px"></asp:GridView>
</asp:Content>
