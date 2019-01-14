<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="purchaseorderlist3.aspx.cs" Inherits="boxwear.purchaseorderlist3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
       .chip {
  display: inline-block;
  padding: 0 25px;
  height: 50px;
  font-size: 16px;
  line-height: 50px;
  border-radius: 25px;
  background-color: #f1f1f1;
}

.chip img {
  float: left;
  margin: 0 10px 0 -25px;
  height: 50px;
  width: 50px;
  border-radius: 50%;
}
       .auto-style1 {
           width: 97px;
       }


       * {box-sizing: border-box}
        .card-text {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
        }
   </style>
    <%-- <p class="card-category">Last Generated Date and Amount</p>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h1 class="text-center"><strong>Create Purchase Order</strong></h1>
    
         <div class ="container-fluid">
              <div class="row">
                   <div class="col-md-4" style="padding-left:130px;">

                        <div class="card ">
                             <div class="card-header ">
                            <h3 class="card-title"><strong>Type of products and quantity</strong></h3>
                            <p class="card-category">Last Generated Quantity</p>
                        </div>

                            <asp:Chart ID="Chart1" runat="server" Height="404px" Width="393px">
                                <Series>
                                    <asp:Series Name="Series1" ChartType="Pie"></asp:Series>
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

                   <div class="col-md-4" style="padding-left:100px;">
                    <div class="card ">
                        <div class="card-header ">
                            <h3 class="card-title"><strong class="newStyle4">Purchase Order ID + Status</strong></h3>
                            <p class="card-category">Last Generated Date and Amount</p>
                        </div>
                        <asp:Chart ID="Chart2" runat="server" DataSourceID="SqlDataSource1" Height="347px" Palette="SeaGreen" Width="390px">
                            <Series>
                                <asp:Series Name="Series1" ChartArea="ChartArea1" ChartType="Doughnut" XValueMember="ProductName" YValueMembers="ProductQty"></asp:Series>
                            </Series>
                            <ChartAreas>
                                <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                            </ChartAreas>
                        </asp:Chart>
                         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:boxwear %>" SelectCommand="SELECT [ProductName], [ProductQty] FROM [ProductCatalogue]"></asp:SqlDataSource>
                         <div class="card-footer ">
                                    <div class="stats">
                                        <i class="fa fa-clock-o"></i> Campaign sent 2 days ago
                                    </div>
                    </div>
                    </div>
                   </div>

                    <div class="col-md-4" style="padding-left:100px;">
                    <div class="card ">
                        <div class="card-header ">
                            <h3 class="card-title"><strong>Supplier Contacts - TheBigFour&nbsp;</strong></h3>
                           <%-- <p class="card-category">Last Generated Date and Amount</p>--%>
                        </div>

                        <div class="chip">
                            <img src="images/avatar1.jpg" alt="Person" height="96" class="auto-style1"/>
                            Jonathan 
                        </div>

                        <div class="chip">
                            <img src="images/avatar1.jpg" alt="Person" height="96" class="auto-style1"/>
                            JiaJin 
                        </div>

                        <div class="chip">
                            <img src="images/avatar1.jpg" alt="Person" height="96" class="auto-style1"/>
                            JingRui 
                        </div>

                          <div class="chip">
                            <img src="images/avatar2.png" alt="Person" height="96" class="auto-style1"/>
                            Joan
                        </div>
                      

                         <div class="chip">
                            <img src="images/avatar1.jpg" alt="Person" height="96" class="auto-style1"/>
                            Reagan
                        </div>
                    </div>
                    </div>
                   </div>


             <br />
               <div class="row">
                     <div class="col-md-4" style="padding-left:130px;">
                         <div class="card" style="width: 18rem;">
                             <img src="images/cap.jpg" class="card-img-top" alt="..."/>
                             <div class="card-body">
                                 <h3><strong>Supreme Cap </strong></h3>
                                 <p class="card-text">Buy in bulk and enjoy cheaper price @ $4 each</p>
                                 <asp:Button ID="btnProduct" runat="server" Text="Shop Now!" Height="46px" Width="125px" style="background-color:red" ForeColor="White" OnClick="btnProduct_Click" />
                             </div>
                         </div>
                         </div>

                 




                   </div>









         
                  </div>   
    <br />
    <center>


    <asp:GridView ID="gvPurchase" runat="server" AutoGenerateColumns="False" Height="189px" Width="982px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" >
        <Columns>
            <asp:BoundField DataField="CatalogueID" HeaderText="Catalogue ID" />
            <asp:BoundField DataField="ProductID" HeaderText="Product ID" />
            <asp:BoundField DataField="ProdDesc" HeaderText="Description" />
            <asp:BoundField DataField="ProductQty" HeaderText="Quantity" />
            <asp:BoundField DataField="UnitPrice" HeaderText="Unit Price" />
            
            <asp:TemplateField>
    <ItemTemplate>
     <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" />
    </ItemTemplate>
            </asp:TemplateField>
            
            <asp:CommandField EditText="Amend" ShowEditButton="True" />
            <asp:CommandField ShowDeleteButton="True" />
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
        <br />
        <asp:Button ID="btnPO" runat="server" Height="41px" OnClick="btnPO_Click" Text="Create PO" Width="217px" />
        <br />
        </center>
</asp:Content>
