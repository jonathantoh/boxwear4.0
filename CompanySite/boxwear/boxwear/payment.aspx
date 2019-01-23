<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="payment.aspx.cs" Inherits="boxwear.payment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-default credit-card-box">
                <div class="panel-heading display-table" >
                    <div class="row display-tr" >
                        <h3 style="text-align:center;">Payment Details</h3>
                        <div class="display-td" >                            
                            <img class="img-responsive pull-right" style="align-content:center" src="http://i76.imgup.net/accepted_c22e0.png"/>
                        </div>
                    </div>                    
                </div>
                <div class="panel-body">
                        <div class="row">
                            <div class="col-xs-12">
                                <div class="form-group">
                                    <label for="cardNumber">CARD NUMBER</label>
                                    <div class="input-group">
                                        <asp:TextBox runat="server"
                                            onkeypress="return allowOnlyNumber(event);"
                                            MaxLength="19"
                                            id="ccNo"
                                            type="tel"
                                            class="form-control"
                                            name="cardNumber"
                                            placeholder="Valid Card Number"
                                            autocomplete="cc-number"
                                            required autofocus ></asp:TextBox>
                                        
                                        <span class="input-group-addon"><i class="fa fa-credit-card"></i></span>

                                    </div>
                                    <asp:Label ID="cardtype" runat="server" Text=""></asp:Label>
                                    <asp:RegularExpressionValidator style="color:#cc0000;" Display="Dynamic" ControlToValidate="ccNo" ID="RegularExpressionValidator1" ValidationExpression="^[\s\S]{15,}$" runat="server" ErrorMessage="Please specify a valid credit card number."></asp:RegularExpressionValidator>
                                </div>                            
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-7 col-md-7">
                                <div class="form-group">
                                    <label for="cardExpiry"><span class="hidden-xs">EXPIRATION DATE</span><span class="visible-xs-inline">EXP DATE</span> </label>
                                    <asp:TextBox runat="server"
                                        onkeypress="return allowOnlyNumber(event);"
                                        onkeyup ="FormatIt(this);"
                                        MaxLength="7"
                                        id="expDate"
                                        type="tel" 
                                        class="form-control" 
                                        name="cardExpiry"
                                        placeholder="MM / yyyy"
                                        autocomplete="cc-exp"
                                        required  />
                                </div>
                                    <asp:RegularExpressionValidator style="color:#cc0000;" Display="Dynamic" ControlToValidate="expDate" ID="MyPassordMinLengthValidator" ValidationExpression="^[\s\S]{7,}$" runat="server" ErrorMessage="Invalid expiration date. (MM/yyyy)"></asp:RegularExpressionValidator>
                            </div>
                            <div class="col-xs-5 col-md-5 pull-right">
                                <div class="form-group">
                                    <label for="cardCVC">CV CODE</label>
                                    <asp:TextBox runat="server"
                                        onkeypress="return allowOnlyNumber(event);"
                                        MaxLength="4"
                                        id="ccv"
                                        type="tel" 
                                        class="form-control"
                                        name="cardCVC"
                                        placeholder="CVC"
                                        autocomplete="cc-csc"
                                        required ></asp:TextBox>
                                </div>
                                    <asp:RegularExpressionValidator style="color:#cc0000;" Display="Dynamic" ControlToValidate="ccv" ID="RegularExpressionValidator2" ValidationExpression="^[\s\S]{3,}$" runat="server" ErrorMessage="Invalid CVC."></asp:RegularExpressionValidator>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-12">
                                <asp:Button class="btn btn-success" ID="paynow_btn" runat="server" Text="Pay Now" OnClick="paynow_btn_Click" />
                            </div>
                        </div>
                        <div class="row" style="display:none;">
                            <div class="col-xs-12">
                                <p class="payment-errors"></p>
                            </div>
                        </div>
                </div>
                </div>  
        </div>
</asp:Content>
