    <%@ Page Title="" Language="C#" MasterPageFile="~/supplier-MasterPage.Master" AutoEventWireup="true" CodeBehind="viewPO.aspx.cs" Inherits="thebigfour.viewPO" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style9 {
            font-size: xx-large;
            text-align: center;
        }
        .auto-style10 {
            width: 205px;
            text-align: center;
        }
        .auto-style11 {
            width: 767px;
            height: 214px;
        }
        .auto-style12 {
            text-align: center;
            width: 624px;
            height: 20px;
        }
        .auto-style14 {
            text-align: center;
            height: 20px;
        }
        .auto-style15 {
            width: 100%;
            height: 99px;
        }
        .auto-style16 {
            text-align: right;
            width: 624px;
            height: 20px;
        }
        .auto-style17 {
            text-align: left;
            height: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />    
                
    <h1 class="auto-style9">
        <strong>View Purchase Orders</strong></h1>
    <h3 class="text-center">
        <strong>Purchase Order ID :
        <asp:Label ID="lblPONum" runat="server"></asp:Label>
        </strong>
    </h3>
    <table class="auto-style15">
        <tr>
            <td class="auto-style12">
                <h4><strong>Company : </strong></h4>
            </td>
            <td class="auto-style14">
                <h4><strong>Supplier : </strong></h4>
            </td>
        </tr>
        <tr>
            <td class="auto-style16">
                <asp:Image ID="Image3" runat="server" Height="140px" ImageUrl="supplier-images/boxwear-1.png" Width="429px" />
            </td>
            <td class="auto-style17">
                <asp:Image ID="Image4" runat="server" ImageUrl="supplier-images/co.jpg" Height="138px" Width="347px" />
            </td>
        </tr>
    </table>
  
   
    <h3 class="auto-style9"><strong>Products and Descriptions</strong></h3>
      <div class="text-center">
        <center>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" Height="159px" Width="987px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" >
                <Columns>
                    <asp:BoundField DataField="ProductID" HeaderText="Product ID" />
                    <asp:BoundField DataField="ProdDesc" HeaderText="Description" />
                    <asp:BoundField DataField="ProductQty" HeaderText="Quantity" />
                    <asp:BoundField DataField="UnitPrice" HeaderText="Unit Price" />
                    <asp:CommandField SelectText="View" ShowSelectButton="True" />
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
          <br />
    
     <center>
          <asp:Panel ID="Panel1" runat="server" Height="218px" Width="781px">
              <table class="auto-style11">
                  <tr>
                      <td class="auto-style10" rowspan="9">
                          <asp:Image ID="Image2" runat="server"/>
                          <br />
                          <br />
                      </td>
                      <td>&nbsp;Product ID :&nbsp;
                          <asp:Label ID="lblProdID" runat="server"></asp:Label>
                      </td>
                  </tr>
                  <tr>
                      <td>&nbsp;</td>
                  </tr>
                  <tr>
                      <td>Description :&nbsp;
                          <asp:Label ID="lblDesc" runat="server"></asp:Label>
                      </td>
                  </tr>
                  <tr>
                      <td>&nbsp;</td>
                  </tr>
                  <tr>
                      <td>Unit Price : $&nbsp;&nbsp;
                          <asp:Label ID="lblPrice" runat="server"></asp:Label>
                      </td>
                  </tr>
                  <tr>
                      <td>&nbsp;</td>
                  </tr>
                  <tr>
                      <td>Quantity :
                          <asp:Label ID="lblQty" runat="server"></asp:Label>
                      </td>
                  </tr>
                  <tr>
                      <td>&nbsp;</td>
                  </tr>
                  <tr>
                      <td>Total Price : $&nbsp;
                          <asp:Label ID="lblTotal" runat="server"></asp:Label>
                      </td>
                  </tr>
              </table>
    </asp:Panel>

         <br />
<%--<asp:Button ID="btnCO" runat="server" Text="Create CO" Height="49px" OnClick="btnCO_Click" Width="188px"></asp:Button>--%>
&nbsp;&nbsp;
          <br />
          <asp:Button ID="createDo" runat="server" Height="54px" OnClick="createDo_Click" Text="Create Delivery Order" Width="187px" />

</asp:Content>
