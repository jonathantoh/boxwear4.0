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

        .newStyle3 {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
        }

        .auto-style1 {
            width: 250px;
            height: 150px;
        }
        .newStyle4 {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
        }
        .newStyle5 {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
        }
        .newStyle6 {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center"><span class="newStyle2"><strong>Pending Purchase Orders</strong></span></h1>
    <p class="text-center">&nbsp;</p>
    <div class="text-center">
        <center>
          
            <div class ="container-fluid">
            <div class="row">
                <div class="col-md-4" style="padding-left:270px;">
                    <div class="auto-style1" style="background-color:#f74747; ">
                        <div class="card-header ">
                            <h3 class="fa-inverse"><strong class="newStyle4">Number of PO</strong></h3>
                         
                        </div>
                      
                        <strong>
                      
                   <span class="glyphicon glyphicon-pencil"></span>  &nbsp;<asp:Label ID="lbl_num" runat="server" CssClass="fa-inverse"></asp:Label>

                        </strong>

                        <br />
                         &nbsp;<div class="card-footer ">
                                    <div class="fa-inverse">
                                        <span class="glyphicon glyphicon-pencil"></span>
                                    </div>
                    </div>

                     </div>

                </div>

                    <div class="col-md-4" style="padding-left:130px;">
                    <div class="card " style="background-color:#ffbb00; width:250px; height:150px;">
                        <div class="card-header ">
                            <h3 class="fa-inverse"><strong class="newStyle5">Total Amount Raised</strong></h3>
                            
                        </div>
                      
                        <strong>
                      
                     <asp:Label ID="lbl_amt" runat="server" CssClass="fa-inverse"></asp:Label>

                         </strong>&nbsp;<div class="card-footer ">
                                    <div class="fa-inverse">
                                        <span class="glyphicon glyphicon-pencil" style="left: -51px; top: -19px"></span>
                                    </div>
                    </div>

                     </div>

                </div>

                <div class="col-md-4" style="padding-right:400px;">
                    <div class="card " style="background-color:#c7ef4f; width:250px; height:150px;">
                        <div class="card-header ">
                            <h3 class="fa-inverse"><strong class="newStyle6">Company</strong></h3>
                           
                        </div>
                      
                        <strong>
                      
                     <asp:Label ID="lbl_company" runat="server" CssClass="fa-inverse"></asp:Label>

                         </strong>&nbsp;<div class="card-footer ">
                                    <div class="fa-inverse">
                                        <span class="glyphicon glyphicon-pencil"></span>
                                    </div>
                    </div>

                     </div>

                </div>

                  





            
            </div>
           </div>

            <br />

        <asp:GridView ID="gvPurchase" runat="server" AutoGenerateColumns="False" Height="212px" Width="954px" OnSelectedIndexChanged="gvPurchase_SelectedIndexChanged" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="PoID" ForeColor="Black" GridLines="Horizontal" >
            <Columns>
                <asp:BoundField DataField="PoID" HeaderText="Purchase Order ID" />
                <asp:BoundField DataField="ListOfProductID" HeaderText="Product ID" />
                <asp:BoundField DataField="ListOfUnitPrice" HeaderText="Amount" />
                <asp:BoundField DataField="PoStatus" HeaderText="Status" />
                <asp:CommandField ShowSelectButton="True" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="DelOrder" runat="server" CausesValidation="False" CommandName="Create">Create Delivery Order</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
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
    </div>
    <p class="text-center">&nbsp;</p>
</asp:Content>
