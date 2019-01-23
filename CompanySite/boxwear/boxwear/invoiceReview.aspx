<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="invoiceReview.aspx.cs" Inherits="boxwear.invoiceReview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                  <div class="panel panel-default" style="width:90%;margin:auto;">
                <div class="panel-heading main-color-bg">
                  <h3 class="panel-title"><span class="glyphicon glyphicon-exclamation-sign" style="color:red;font-size:20px"></span> Customer's copy</h3>
                </div>

    <section id="breadcrumb">
      <div class="container text-center">
        <ol class="breadcrumb" style="margin-top:15px;padding:40px;font-size:20px;">
          <li class="main-color-bg">Thank you for your purchase </span></li>
            <li><em>Order #: <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></em></li>
            <h5>An email confirmation has been sent to <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></h5>
            <p><span class="glyphicon glyphicon-ok-circle" style="font-size: 60px;color:green;text-align:center;vertical-align: baseline;"></p>
        </ol>
          
      </div>
    </section>

    <section id="main1">
      <div class="container">
        <div class="row">
          <div class="col-md-12">
              <div class="col-md-6">
        <div class="container">
    <div class="row">
        <div class="well col-xs-10 col-sm-10 col-md-6 col-xs-offset-1 col-sm-offset-1 col-md-offset-3">
            <div class="row">
                <div class="col-xs-6 col-sm-6 col-md-6">
                    <address>
                        <strong>
                            <asp:Label ID="name" runat="server" Text="Label"></asp:Label></strong>
                        <br />
                        <strong>
                            <asp:Label ID="emailtxt" runat="server" Text="Label"></asp:Label></strong>
                        <br/>
                        <asp:Label ID="addresstxt" runat="server" Text="Label"></asp:Label>
                        <br/>
                        <asp:Label ID="postaltxt" runat="server" Text="Label"></asp:Label>
                        <br/>
                        <abbr title="Phone"><asp:Label ID="hptxt" runat="server" Text=""></asp:Label></abbr>
                    </address>
                </div>
                <div class="col-xs-6 col-sm-6 col-md-6 text-right">
                    <p>
                        <em>Invoice issued on: <asp:Label ID="date_lbl" runat="server" Text="Label"></asp:Label></em>
                    </p>
                    <p>
                        <em>Invoice due on: <asp:Label ID="duelbl" runat="server" Text="Label"></asp:Label></em>
                    </p>
                    <div id="paymentdiv">
                    <p>
                        <em>Payment made on: <asp:Label ID="paymentdatelbl" runat="server" Text="Label"></asp:Label></em>
                    </p>
                    <p>
                        <em>Payment made by: <asp:Label ID="paymentmadebylbl" runat="server" Text="Label"></asp:Label></em>
                    </p>
                        </div>
                   <p><asp:Label ID="status_lbl" runat="server" Text=""/></p>
                    <p>
                        <em>Order #: <asp:Label ID="ordernotxt" runat="server" Text="Label"></asp:Label></em>
                    </p>
                    <p>
                    <asp:Label ID="cardtype" runat="server" Text=""/>     
                    <asp:Label ID="cardNo" runat="server" Text=""/>
                    </p>
                </div>
            </div>
            <div class="row">
                <div class="text-center">
                    <img src="images/boxwear-1.png"  width="auto" height="50px" />
                    
                    <h1>Receipt</h1>
                </div>
                
                <table class="table table-hover">
                    <thead>
                    </thead>
                    <tbody>
                        <tr>
                            <td>
                            <asp:GridView ID="gvPurchase" runat="server" style="width:100%;border-collapse:collapse;margin:0px auto 0px auto" AutoGenerateColumns="False" GridLines="None"  cellpadding="10" cellspacing="5">
                                <%--<Columns>
                                    <asp:ImageField DataImageUrlField="OutfitImage" ControlStyle-Width="70" ControlStyle-Height="70">
                        <ControlStyle Height="70px" Width="70px"></ControlStyle>
                                    </asp:ImageField>
                                    <asp:BoundField DataField="OutfitID"  HeaderText="Outfit ID" />
                                        <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                                        <asp:BoundField DataField="OutfitSize" HeaderText="Size" />
                                        <asp:BoundField DataField="Qty" HeaderText="Quantity" />
                                        <asp:BoundField DataField="Price" HeaderText="Price" />
                                        <asp:BoundField DataField="TotalPrice" HeaderText="Total Price" />
                                    </Columns>--%>

                                <Columns>
                    <asp:BoundField DataField="ProductID" HeaderText="Product ID" />
                    <asp:BoundField DataField="ProdDesc" HeaderText="Description" />
                    <asp:BoundField DataField="ProductQty" HeaderText="Quantity" />
                    <asp:BoundField DataField="UnitPrice" HeaderText="Unit Price" />
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
                            </td>
                        </tr>
                        <tr>
                            <td class="text-right"><h4><strong>Total: $<asp:Label ID="lbl_TotalPrice" runat="server" Text="lbl_TotalPrice"></asp:Label></strong></h4></td>
                        </tr>
                    </tbody>
                </table>

                <div class="text-center">
                    <p class="font-italic">Thank you for shopping with BoxWear!</p>
                </div>
            </div>
        </div>
    </div>
         </div>
                        </div>
              </div>
            </div>
          </div>
        </section>

      <asp:Button ID="paybtn" class="btn btn-success" runat="server" Text="Make Payment" OnClick="paybtn_Click" />

       

                  </div>
</span>
</asp:Content>
