<%@ Page Title="" Language="C#" MasterPageFile="~/SupplierSite/supplier-MasterPage.master" AutoEventWireup="true" CodeFile="supplier-view-status.aspx.cs" Inherits="SupplierSite_supplier_images_supplier_view_status" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <title>Admin Area | Dashboard</title>
    <!-- Bootstrap core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet"/>
    <link href="css/style.css" rel="stylesheet"/>
    <script src="http://cdn.ckeditor.com/4.6.1/standard/ckeditor.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <header id="header">
      <div class="container">
        <div class="row">
          <div class="col-md-10">
            <h1><span class="glyphicon glyphicon-cog" aria-hidden="true"></span> Dashboard <small>Manage Your Site</small></h1>
          </div>
          <div class="col-md-2">
            <div class="dropdown create">
              <button class="btn btn-default dropdown-toggle" type="button" id="dropdownMenu1" data-toggle="dropdown" aria-haspopup="true" aria-expanded="true">
                Create Content
                <span class="caret"></span>
              </button>
              <ul class="dropdown-menu" aria-labelledby="dropdownMenu1">
                <li><a data-toggle="modal" data-target="#addPage">Add Page</a></li>
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
          <li class="active">Dashboard</li>
        </ol>
      </div>
    </section>

      <div class="container">
            <a href="admin-view-all-orders.aspx" class="btn btn-info btn-danger">View All Orders</a>
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
                            <asp:TextBox ID="search_tb" class="form-control input-lg" placeholder="Search for Order ID" runat="server"></asp:TextBox>
                            <asp:Label ID="errorlbl" style="color:red" runat="server" Text=""></asp:Label>
                            <span class="input-group-btn">
<%--                                <asp:Button ID="search_btn" style="margin-top:10px;margin-bottom:10px;width:50%;height:50%;" class="btn btn-info btn-success" runat="server" Text="Search" OnClick="search_btn_Click" />--%>
                            </span>
                            
                            <br />
                            <h3>Edit Delivery Information</h3>
<%--                            <asp:DropDownList OnSelectedIndexChanged="ddl_filter_SelectedIndexChanged" class="btn btn-primary dropdown-toggle" ID="ddl_filter" runat="server" AutoPostBack="True">
                                <asp:ListItem>Pending</asp:ListItem>
                                <asp:ListItem>In Transit</asp:ListItem>
                                <asp:ListItem>Delivered</asp:ListItem>
                            </asp:DropDownList>--%>

                            <asp:TextBox ID="tracking_tb" style="margin-top:10px;margin-bottom:10px;width:50%;height:50%;" class="primary form-control input-lg" placeholder="Tracking ID" runat="server"></asp:TextBox>

<%--                            <asp:Button ID="save_btn" class="btn btn-success" runat="server" Text="Save" OnClick="save_btn_Click"/>--%>
                            
                        </div>
                    </div>
                    
                    <div class="col-md-6">
                        <table class="table">
                              <thead>
                                <tr>
                                  <th scope="col">Order Details</th>
                                </tr>
                              </thead>
                              <tbody>
                                <tr>
                                  <th scope="row">ID</th>
                                  <td><asp:Label ID="orderid_lbl" runat="server" Text=""></asp:Label></td>
                                </tr>
                                <tr>
                                  <th scope="row">Date</th>
                                  <td><asp:Label ID="date_lbl" runat="server" Text=""></asp:Label></td>

                                </tr>
                                <tr>
                                  <th scope="row">Status</th>
                                  <td><asp:Label ID="status_lbl" runat="server" Text=""></asp:Label></td>

                                </tr>

                                  <tr>
                                  <th scope="row">Tracking ID</th>
                                  <td><asp:Label ID="tracking_lbl" runat="server" Text=""></asp:Label></td>

                                </tr>

                                  <tr>
                                  <th scope="row">Outfit No</th>
                                  <td><asp:Label ID="outfitno_lbl" runat="server" Text=""></asp:Label></td>

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
                                  <td><asp:Label ID="email_lbl" runat="server" Text=""></asp:Label></td>

                                </tr>
                                <tr>
                                  <th scope="row">Postal</th>
                                  <td><asp:Label ID="postal_lbl" runat="server" Text=""></asp:Label></td>

                                </tr>
                                <tr>
                                  <th scope="row">Address</th>
                                  <td><asp:Label ID="address_lbl" runat="server" Text=""></asp:Label></td>

                                </tr>
                                  <tr>
                                  <th scope="row">City</th>
                                  <td><asp:Label ID="city_lbl" runat="server" Text=""></asp:Label></td>

                                </tr>
                                  <tr>
                                  <th scope="row">Delivery option</th>
                                  <td><asp:Label ID="type_lbl" runat="server" Text=""></asp:Label></td>

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
                  <h3 class="panel-title">Latest Orders</h3>
                </div>
                <div class="panel-body">
                  <%--<asp:GridView ID="gvUser" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvUser_SelectedIndexChanged" OnRowDeleting="gvUser_RowDeleting" OnRowEditing="gvUser_RowEditing" OnRowCancelingEdit="gvUSer_RowCancelingEdit" OnRowUpdating="gvUser_RowUpdating" DataKeyNames="OrderID" style="width:100% ;border-collapse:collapse;" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="OrderID" ReadOnly="true" HeaderText="Order #" />
                            <asp:BoundField DataField="OrderStatus" HeaderText="Status" />
                            <asp:BoundField DataField="OrderDate" HeaderText="Date" />
                            <asp:BoundField DataField="CustEmail" HeaderText="Email" />
                            <asp:BoundField DataField="Postal" HeaderText="Postal" />
                            <asp:BoundField DataField="Address" HeaderText="Address" />
                            <asp:BoundField DataField="City" HeaderText="City" />
                            <asp:BoundField DataField="DeliveryType" HeaderText="Type" />
                            
                           
                            <asp:CommandField  ShowEditButton="True" />
                           <asp:CommandField ShowSelectButton="True" SelectText="View Order" ControlStyle-ForeColor="Blue" />
                            <asp:TemplateField ShowHeader="False">
                                <ItemTemplate>
                                    <asp:ImageButton ID="DeleteButton" runat="server" ImageUrl="~/site/img/icons/cross.png"
                                                CommandName="Delete" OnClientClick="return confirm('Are you sure you want to delete this event?');"
                                                AlternateText="Delete" />               
                                </ItemTemplate>
                            </asp:TemplateField>  
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" /> 
                </asp:GridView>--%>
                
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
