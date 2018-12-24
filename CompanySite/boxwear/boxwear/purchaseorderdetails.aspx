<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="purchaseorderdetails.aspx.cs" Inherits="boxwear.purchaseorderdetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 20px;
            text-align: center;
        }
        .newStyle1 {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
        }
        .newStyle2 {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
        }
        .newStyle3 {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
        }
        .newStyle4 {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
        }
        .newStyle5 {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
        }
        .newStyle6 {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
            border : thin solid #f45042;
        }
        .newStyle7 {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
             border : thin solid #f45042;
        }
        .newStyle8 {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="text-center">
    <asp:DataList ID="DataList1" runat="server" Width="482px" style="margin-left : 350px;">
        <ItemTemplate>
            <table class="nav-justified">
                <tr>
                    <td class="text-center" colspan="2">
                        <asp:Image ID="Image1" runat="server" Height="126px" ImageUrl="~/images/logo1.JPG" Width="306px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" colspan="2"><strong class="newStyle1">Purchase Order ID : </strong><strong>
                        <asp:Label ID="lblPoID" runat="server" CssClass="newStyle2"></asp:Label>
                        </strong></td>
                </tr>
                <tr>
                    <td class="text-center" colspan="2"><strong class="newStyle3">Status: </strong><strong>
                        <asp:Label ID="lblStatus" runat="server" CssClass="newStyle4"></asp:Label>
                        </strong></td>
                </tr>
                <tr>
                    <td class="text-center" colspan="2"><strong class="newStyle5">Company Name&nbsp; :
                        <asp:Label ID="lblCompany" runat="server"></asp:Label>
                        </strong></td>
                </tr>
                <tr>
                    <td class="text-center"><strong class="newStyle6">Supplier Name :
                        <asp:Label ID="lblSupplier" runat="server"></asp:Label>
                        </strong></td>
                    <td class="text-center"><strong class="newStyle7">Date Generated&nbsp; :
                        <asp:Label ID="lblDate" runat="server"></asp:Label>
                        </strong></td>
                </tr>
                <tr>
                    <td class="text-center" colspan="2"><strong class="newStyle8">Amt Payable : $&nbsp;
                        <asp:Label ID="lblAmt" runat="server"></asp:Label>
                        </strong></td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
        <br />
        <center>
        <asp:GridView ID="gvProduct" runat="server" AutoGenerateColumns="False" Height="162px" Width="1023px">
            <Columns>
                <asp:BoundField DataField="ProductID" HeaderText="Product ID" />
                <asp:BoundField DataField="ProductName" HeaderText="Name" />
                <asp:BoundField DataField="ProductDesc" HeaderText="Description" />
                <asp:BoundField DataField="ProductImage" HeaderText="Image" />
                <asp:BoundField DataField="ProductQty" HeaderText="Quantity" />
                <asp:BoundField DataField="UnitPrice" HeaderText="Unit Price" />
                <asp:BoundField DataField="TotalPrice" HeaderText="Total" />
            </Columns>
        </asp:GridView>
            </center>
    </div>
</asp:Content>
