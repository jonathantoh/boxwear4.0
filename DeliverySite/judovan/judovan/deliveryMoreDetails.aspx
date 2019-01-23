<%@ Page Title="" Language="C#" MasterPageFile="~/delivery.Master" AutoEventWireup="true" CodeBehind="deliveryMoreDetails.aspx.cs" Inherits="judovan.deliveryMoreDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <title>Admin Area | Dashboard</title>
    <!-- Bootstrap core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet"/>
    <link href="css/style.css" rel="stylesheet"/>
    <script src="http://cdn.ckeditor.com/4.6.1/standard/ckeditor.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
       <header id="header">
      <div class="container">
        <div class="row">
          <div class="col-md-10">
            <h1><span class="glyphicon glyphicon-tasks" style="color:#ff7f50" aria-hidden="true"></span> Delivery Orders <small>Manage Your Orders</small></h1>
          </div>
          <div class="col-md-2">
            <div class="dropdown create">
              <button class="btn btn-default dropdown-toggle" type="button" id="dropdownMenu1" data-toggle="dropdown" aria-haspopup="true" aria-expanded="true">
                Create Content
                <span class="caret"></span>
              </button>
              <ul class="dropdown-menu" aria-labelledby="dropdownMenu1">
                <li><a type="button" data-toggle="modal" data-target="#addPage">Add Page</a></li>
                <li><a href="#">Add Post</a></li>
                <li><a href="#">Add User</a></li>
              </ul>
            </div>
          </div>
        </div>
      </div>
    </header>

    <section id="breadcrumb">
      <div class="container">
        <ol class="breadcrumb">
          <li class="active">Delivery Orders</li>
        </ol>
      </div>
    </section>

      <div class="container">
            <a href="deliverydetails.aspx" class="btn btn-info btn-danger">View All Delivery Orders</a>
      </div>
    <br />
    <section id="main">
      <div class="container">
        <div class="row">
          
          <div class="col-md-12">
            <!-- Website Overview -->


              <div class="panel panel-default">
                <div class="panel-heading main-color-bg">
                  <h3 class="panel-title">Search for Delivery Information</h3>
                </div>
                <div class="panel-body">
                    <div id="custom-search-input">
                        <div class="col-md-6">
                            <asp:TextBox ID="TextBox1" class="form-control input-lg" placeholder="Search for Delivery Order ID" runat="server"></asp:TextBox>
                            <asp:Label ID="Label1" style="color:red" runat="server" Text=""></asp:Label>
                            <span class="input-group-btn">
                                <asp:Button ID="Button1" style="margin-top:10px;margin-bottom:10px;width:50%;height:50%;" class="btn btn-info btn-success" runat="server" Text="Search" OnClick="search_btn_Click" />
                            </span>
                            
                            <br />
                            <h3>Edit Delivery Information</h3>
                            <asp:DropDownList class="btn btn-primary dropdown-toggle" ID="DropDownList1" runat="server" AutoPostBack="True">
                                <asp:ListItem>Processing</asp:ListItem>
                                <asp:ListItem>In Transit</asp:ListItem>
                                <asp:ListItem>Delivered</asp:ListItem>
                            </asp:DropDownList>


                            <asp:Button ID="Button2" class="btn btn-success" runat="server" Text="Save" OnClick="save_btn_Click"/>
                            
                        </div>
                    </div>
                    
                    <div class="col-md-6">
                        <table class="table">
                              <thead>
                                <tr>
                                  <th scope="col">Delivery Order Details</th>
                                </tr>
                              </thead>
                              <tbody>
                                <tr>
                                  <th scope="row">Tracking ID</th>
                                  <td><asp:Label ID="trackingidlbl" runat="server" Text=""></asp:Label></td>
                                </tr>
                                <tr>
                                  <th scope="row">Weight</th>
                                  <td><asp:Label ID="weightlbl" runat="server" Text=""></asp:Label></td>

                                </tr>
                                <tr>
                                  <th scope="row">Status</th>
                                  <td><asp:Label ID="statuslbl" runat="server" Text=""></asp:Label></td>

                                </tr>

                                  <tr>
                                  <th scope="row">Delivery Type</th>
                                  <td><asp:Label ID="deliveryTypelbl" runat="server" Text=""></asp:Label></td>

                                </tr>
                                <tr>
                                  <th scope="row">Total Value</th>
                                  <td><asp:Label ID="valuelbl" runat="server" Text=""></asp:Label></td>

                                </tr>

                                  <tr>
                                  <th scope="row">PO ID</th>
                                  <td><asp:Label ID="poidlbl" runat="server" Text=""></asp:Label></td>

                                </tr>
                                  
                              </tbody>
                            </table>

                        <table class="table">
                              <thead>
                                <tr>
                                  <th scope="col">Customer Details</th>
                                </tr>
                              </thead>
                              <tbody>
                                <tr>
                                  <th scope="row">Email</th>
                                  <td><asp:Label ID="Label7" runat="server" Text=""></asp:Label></td>

                                </tr>
                                <tr>
                                  <th scope="row">Postal</th>
                                  <td><asp:Label ID="Label8" runat="server" Text=""></asp:Label></td>

                                </tr>
                                <tr>
                                  <th scope="row">Address</th>
                                  <td><asp:Label ID="Label9" runat="server" Text=""></asp:Label></td>

                                </tr>
                                  <tr>
                                  <th scope="row">City</th>
                                  <td><asp:Label ID="Label10" runat="server" Text=""></asp:Label></td>

                                </tr>
                                  <tr>
                                  <th scope="row">Delivery option</th>
                                  <td><asp:Label ID="Label11" runat="server" Text=""></asp:Label></td>

                                </tr>
                              </tbody>
                            </table>


                            


                    </div>
                    <br/>

                    
                
                </div>
              </div>



              <!-- Latest Users -->
              <div class="panel panel-default">
                <div class="panel-heading main-color-bg">
                  <h3 class="panel-title">Orders</h3>
                </div>
                <div class="panel-body">
                  <asp:GridView ID="gvDelivery" runat="server" AutoGenerateColumns="False" Height="212px" Width="954px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" >
            <Columns>
                <asp:BoundField DataField="trackingID" HeaderText="TrackingID" />
                <asp:BoundField DataField="weight" HeaderText="Weight" />
                <asp:BoundField DataField="deliveryStatus" HeaderText="Status" />
                <asp:BoundField DataField="PoID" HeaderText="PO ID" />
                <asp:BoundField DataField="dateRegistered" HeaderText="Date Registered" />
                <asp:BoundField DataField="deliveryType" HeaderText="Type" />
                <asp:BoundField DataField="InvoiceID" HeaderText="Invoice" />

                <asp:CommandField ShowSelectButton="True" />
                <asp:CommandField DeleteText="Reject" ShowDeleteButton="True" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#ff7f50" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
                
                </div>
              </div>


              

              
          </div>
        </div>
      </div>
    </section>









    

        <footer id="footer">
      <p>Copyright Jonathan, &copy; 2018</p>
    </footer>
</asp:Content>
