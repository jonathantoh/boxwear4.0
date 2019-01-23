<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="deliveryOrderDetails.aspx.cs" Inherits="boxwear.deliveryOrderDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-12">
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
                                  <tr>
                                  <th scope="row">Invoice ID</th>
                                  <td><asp:Label ID="invoicelbl" runat="server" Text=""></asp:Label></td>

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

                    
        
      <asp:Button ID="viewinvoice" class="btn btn-success" runat="server" Text="View Invoice" OnClick="viewinvoice_Click"/>

</asp:Content>
