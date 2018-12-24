<%@ Page Title="" Language="C#" MasterPageFile="~/supplier-MasterPage.Master" AutoEventWireup="true" CodeBehind="pendingpurchaseorders.aspx.cs" Inherits="thebigfour.pendingpurchaseorders" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .newStyle1 {
            font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
        }

        .newStyle2 {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center"><span class="newStyle2"><strong>Pending Purchase Orders</strong></span></h1>
    <div class="text-center">
        <center>
           <br />
           <br />
       
                        <div class="row">
          <div class="card text-white" style="max-width: 18rem; background-color:#f74747; color:white; border-radius: 5px;">
          <div class="card-header">Header</div>
          <div class="card-body">
            <h5 class="card-title">Danger card title</h5>
            <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
          </div>
            </div>


<div class="card text-white" style="max-width: 18rem; background-color:#f74747; color:white; border-radius: 5px;">
          <div class="card-header">Header</div>
          <div class="card-body">
            <h5 class="card-title">Danger card title</h5>
            <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
          </div>
            </div>






                    </div>


        <asp:GridView ID="gvPurchase" runat="server" AutoGenerateColumns="False" Height="212px" Width="851px" >
            <Columns>
                <asp:BoundField DataField="PoID" HeaderText="Purchase Order ID" />
                <asp:BoundField DataField="CompanyName" HeaderText="Company " />
                <asp:BoundField DataField="PoDate" HeaderText="Raised On" />
                <asp:BoundField DataField="PoTotalAmt" HeaderText="Amount" />
                <asp:CommandField ShowSelectButton="True" />
                <asp:CommandField DeleteText="Reject" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        </center>
    </div>
    <p class="text-center">&nbsp;</p>
</asp:Content>
