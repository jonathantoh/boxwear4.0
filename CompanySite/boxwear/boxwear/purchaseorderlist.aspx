<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="purchaseorderlist.aspx.cs" Inherits="boxwear._default" %>


<%--<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>--%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <style type="text/css">
        .newStyle1 {
            font-family: "Franklin Gothic Medium";
        }
        .newStyle2 {
            font-family: Consolas;
            text-align:center;
        }
        .auto-style1 {
            font-size: 30px;
        }
        .newStyle3 {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
        }
        .newStyle4 {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
        }
    </style>
    <link rel="stylesheet" type="text/css" href="mydatagrid.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
    <asp:Image ID="Image1" runat="server" Height="130px" ImageUrl="~/images/logo.JPG" Width="269px" />
    </center>
        <br />
         <div class ="container-fluid">
            <div class="row">
                <div class="col-md-4" style="padding-left:130px;">
                    <div class="card ">
                        <div class="card-header ">
                            <h3 class="card-title"><strong class="newStyle3">Purchase Order Dates and Amount</strong></h3>
                            <p class="card-category">Last Generated Date and Amount</p>
                        </div>
                      
                        <asp:Chart ID="Chart1" runat="server" Height="342px" Width="488px">
                            <Series>
                                <asp:Series Name="Series1" ChartType="Pie" IsValueShownAsLabel="True" Legend="Legend1">

                                </asp:Series>

                            </Series>
                            <ChartAreas>
                                <asp:ChartArea Name="ChartArea1"></asp:ChartArea>

                            </ChartAreas>

                            <Legends>
                                <asp:Legend Name="Legend1">
                                </asp:Legend>
                            </Legends>

                        </asp:Chart>

                         <div class="card-footer ">
                                    <div class="stats">
                                        <i class="fa fa-clock-o"></i> Campaign sent 2 days ago
                                    </div>
                    </div>

                     </div>

                </div>
                <p></p>
                   <div class="col-md-8" style="padding-left:100px;">
                    <div class="card ">
                        <div class="card-header ">
                            <h3 class="card-title"><strong class="newStyle4">Purchase Order ID + Status</strong></h3>
                            <p class="card-category">Last Generated Date and Amount</p>
                        </div>
                       <asp:Chart ID="Chart2" runat="server" DataSourceID="SqlDataSource1" Height="321px" Palette="None" PaletteCustomColors="174, 224, 80" Width="742px">
                           <Series>
                               <asp:Series ChartType="Bar" Name="Series1" XValueMember="PoStatus" YValueMembers="PoID">
                               </asp:Series>
                           </Series>
                           <ChartAreas>
                               <asp:ChartArea Name="ChartArea1">
                               </asp:ChartArea>
                           </ChartAreas>
                       </asp:Chart>
                       <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:boxwear %>" SelectCommand="SELECT [PoID], [PoDate], [PoStatus] FROM [PurchaseOrders]"></asp:SqlDataSource>
                         <div class="card-footer ">
                                    <div class="stats">
                                        <i class="fa fa-clock-o"></i> Campaign sent 2 days ago
                                    </div>
                    </div>
                    </div>
                   </div>
            </div>
           </div>
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
            <asp:BoundField DataField="PoDate" HeaderText="Date " />
            <asp:BoundField DataField="PoStatus" HeaderText="Status" />
            <asp:BoundField DataField="PoTotalAmt" HeaderText="Total Amount" />
            <asp:BoundField DataField="CompanyName" HeaderText="Company " />
            <asp:BoundField DataField="SupplierName" HeaderText="Supplier" />
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
      

    </div>
      

    <br />
    <p class="text-center">
        <asp:Button ID="btnRaise" runat="server" Text="Raise Purchase Order" Height="59px" Width="382px" style="background-color: #4CAF50;  color: white; border-radius: 12px;" /></p>
</asp:Content>
