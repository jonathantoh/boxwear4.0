<%@ Page Title="" Language="C#" MasterPageFile="~/supplier-MasterPage.Master" AutoEventWireup="true" CodeBehind="viewDeliveryDetails.aspx.cs" Inherits="thebigfour.viewDeliveryDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
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

                                  <tr>
                                  <th scope="row">Invoice id</th>
                                  <td><asp:Label ID="inidlbl" runat="server" Text=""></asp:Label>
      <asp:Button ID="viewinvoice" class="btn btn-success" runat="server" Text="View Invoice" OnClick="viewinvoice_Click"/>

                                  </td>

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

                    
<div class="panel-body">
                  <asp:GridView ID="gvDelivery" runat="server" AutoGenerateColumns="False" Height="212px" Width="954px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnSelectedIndexChanged="gvDelivery_SelectedIndexChanged" >
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
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
                
                </div>
    </center>

      <asp:Button ID="createInvoice" class="btn btn-success" runat="server" Text="Create Invoice" OnClick="createInvoice_Click"/>

</asp:Content>
