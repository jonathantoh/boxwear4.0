<%@ Page Title="" Language="C#" MasterPageFile="~/supplier-MasterPage.Master" AutoEventWireup="true" CodeBehind="pendingpurchaseorders.aspx.cs" Inherits="thebigfour.pendingpurchaseorders" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .newStyle1 {
            font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
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

        .auto-style3 {
            color: #fff;
            font-size: 16px;
        }

        .newStyle7 {
            font-family: Arial, Helvetica, sans-serif;
        }

        .newStyle8 {
            font-family: Arial, Helvetica, sans-serif;
        }

        .auto-style4 {
            font-family: Arial, Helvetica, sans-serif;
            text-align: center;
            font-size: xx-large;
        }

        .auto-style5 {
            position: relative;
            min-height: 1px;
            float: left;
            width: 33.33333333%;
            text-align: left;
            padding-left: 15px;
            padding-right: 15px;
        }

        .danger {
            background-color: #ffdddd;
            border-left: 6px solid #f44336;
        }

        .success {
            background-color: #ddffdd;
            border-left: 6px solid #4CAF50;
        }

        .info {
            background-color: #e7f3fe;
            border-left: 6px solid #2196F3;
        }


        .warning {
            background-color: #ffffcc;
            border-left: 6px solid #ffeb3b;
        }

        .hello {
            float: left;
            margin-right: 20px;
            border-radius: 50%;
          
        }




    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="auto-style4"><span class="newStyle2"><strong>Pending Purchase Orders</strong></span></h1>
    <p class="newStyle7">&nbsp;</p>
    <div class="text-center">

        <div class="container-fluid">


            <div class="row">
                <div class="col-md-4">

                    <div class="card ">

                        <div class="card-header ">
                            <h3 class="card-title"><strong class="newStyle4">Delivery Order ID + Status</strong></h3>
                            <p class="card-category">Last Generated Date and Amount</p>
                        </div>
                        <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource1" Palette="None" PaletteCustomColors="145, 182, 242; 205, 244, 132; 252, 213, 95; 180, 247, 223; 244, 132, 124">
                            <Series>
                                <asp:Series Name="Series1" ChartType="Pyramid" Legend="Legend1" XValueMember="DeliveryStatus" YValueMembers="PoID">
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



                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:thebigfour %>" SelectCommand="SELECT [PoID], [DeliveryStatus] FROM [DeliveryOrders]"></asp:SqlDataSource>





                    </div>
                </div>

                <div class="col-md-4">
                    <div class="auto-style1" style="background-color: #f74747;">
                        <div class="card-header ">
                            <h3 class="fa-inverse"><strong class="newStyle4">Number of PO</strong></h3>
                            <p class="fa-inverse">&nbsp;</p>

                        </div>

                        <strong>&nbsp;<asp:Label ID="lbl_num" runat="server" CssClass="auto-style3"></asp:Label>

                        </strong>

                        <br />
                        &nbsp;<div class="card-footer ">
                            <div class="fa-inverse">
                                <span class="glyphicon glyphicon-pencil"></span>
                            </div>
                        </div>

                    </div>

                </div>

                <div class="col-md-4">
                    <div class="card " style="background-color: #ffbb00; width: 250px; height: 150px;">
                        <div class="card-header ">
                            <h3 class="fa-inverse"><strong class="newStyle5">Status of Purchase Orders</strong></h3>

                        </div>

                        <strong>

                            <asp:Label ID="lbl_amt" runat="server" CssClass="fa-inverse"></asp:Label>

                        </strong>&nbsp;<div class="card-footer ">
                            <div class="fa-inverse">
                                <span class="glyphicon glyphicon-pencil" style="left: -6px; top: 17px"></span>
                            </div>
                        </div>

                    </div>

                </div>

                <div class="col-md-4">
                    <div class="card " style="background-color: #c7ef4f; width: 250px; height: 150px;">
                        <div class="card-header ">
                            <h3 class="fa-inverse"><strong class="newStyle6">Company</strong></h3>
                            <p class="fa-inverse">&nbsp;</p>

                        </div>

                        <strong>

                            <asp:Label ID="lbl_company" runat="server" CssClass="auto-style3"></asp:Label>

                        </strong>&nbsp;<br />
                        <br />
                        <div class="card-footer ">
                            <div class="fa-inverse">
                                <span class="glyphicon glyphicon-pencil"></span>
                            </div>
                        </div>

                    </div>

                </div>

                <div class="col-md-4">
                    <div class="card " style="background-color: #93edc6; width: 250px; height: 150px;">
                        <div class="card-header ">
                            <h3 class="fa-inverse"><strong class="newStyle6">Supplier</strong></h3>
                            <p class="fa-inverse">&nbsp;</p>

                        </div>

                        <strong>

                            <asp:Label ID="lblSupplier" runat="server" CssClass="auto-style3">TheBigFour</asp:Label>

                        </strong>&nbsp;<br />
                        <br />
                        <div class="card-footer ">
                            <div class="fa-inverse">
                                <span class="glyphicon glyphicon-pencil"></span>
                            </div>
                        </div>

                    </div>

                </div>
            </div>


            <div class="row">
                <div class="auto-style5">
                    <div class="text-center">
                        <div class="card-header ">
                            <h3 class="card-title"><strong class="newStyle4">Products + Unit Price</strong></h3>
                            <p class="card-category">Last Generated Date and Amount</p>
                        </div>

                        <asp:Chart ID="Chart2" runat="server" DataSourceID="SqlDataSource2" Palette="None" PaletteCustomColors="242, 203, 77; 146, 244, 212; 206, 237, 116">
                            <Series>
                                <asp:Series Name="Series1" ChartArea="ChartArea1" ChartType="Doughnut" XValueMember="ProductName" YValueMembers="UnitPrice"></asp:Series>
                            </Series>
                            <ChartAreas>
                                <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                            </ChartAreas>
                        </asp:Chart>

                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:thebigfour %>" SelectCommand="SELECT [ProductName], [UnitPrice] FROM [Products]"></asp:SqlDataSource>

                    </div>


                </div>

                <div class="col-md-8">
                    <div class="danger">
                        <p><strong>Danger!</strong> Some text...</p>
                    </div>

                    <div class="success">
                        <p><strong>Success!</strong> Some text...</p>
                    </div>

                    <div class="info">
                        <p><strong>Info!</strong> Some text...</p>
                    </div>

                    <div class="warning">
                        <p><strong>Warning!</strong> Some text...</p>
                    </div>


                </div>
               
                  <div class="col-md-8">
                    <div class="card " style="background-color: #eee;  border: 2px solid #ccc;   border-radius: 5px; height: 100px;">
                        <img src="supplier-images/a1.png" alt="Avatar" style="width: 90px" class="hello"/>
                        <p><span>Chris Fox.</span> CEO at Mighty Schools.</p>
                        <p>John Doe saved us from a web disaster.</p>
                        </div>
                      </div>

                <div class="col-md-8">
                    <div class="card " style="background-color: #eee;  border: 2px solid #ccc;   border-radius: 5px; height: 100px;">
                        <img src="supplier-images/a2.png" alt="Avatar" style="width: 90px" class="hello"/>
                        <p><span>Chris Fox.</span> CEO at Mighty Schools.</p>
                        <p>John Doe saved us from a web disaster.</p>
                        </div>
                      </div>


                <div class="col-md-8">
                    <div class="card " style="background-color: #eee;  border: 2px solid #ccc;   border-radius: 5px; height: 100px;">
                        <img src="supplier-images/a3.png" alt="Avatar" style="width: 90px" class="hello"/>
                        <p><span>Chris Fox.</span> CEO at Mighty Schools.</p>
                        <p>John Doe saved us from a web disaster.</p>
                        </div>
                      </div>





            </div>

        </div>

        <br />












    </div>


    <center>
          


        <asp:GridView ID="gvPurchase" runat="server" AutoGenerateColumns="False" Height="212px" Width="954px" OnSelectedIndexChanged="gvPurchase_SelectedIndexChanged" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" >
            <Columns>
                <asp:BoundField DataField="PoID" HeaderText="Purchase Order ID" />
                <asp:BoundField DataField="ListOfProductID" HeaderText="Product ID" />
                <asp:BoundField DataField="ListOfUnitPrice" HeaderText="Amount" />
                <asp:BoundField DataField="PoStatus" HeaderText="Status" />
                <asp:CommandField ShowSelectButton="True" />
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

    <p class="text-center">&nbsp;</p>
</asp:Content>
