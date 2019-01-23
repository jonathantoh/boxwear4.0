<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="delivery.master" CodeFile="delivery-calculate-shipping.aspx.cs" Inherits="judovan.delivery_calculate_shipping" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        .signup-form{
		width: 390px;
		margin: 30px auto;
	}
	.signup-form form{
		color: #999;
		border-radius: 3px;
    	margin-bottom: 15px;
        background: #fff;
        box-shadow: 0px 2px 2px rgba(0, 0, 0, 0.3);
        padding: 30px;
    }
	.signup-form h2 {
		color: #333;
		font-weight: bold;
        margin-top: 0;
    }
    .signup-form hr {
        margin: 0 -30px 20px;
    }    
	.signup-form .form-group{
		margin-bottom: 20px;
	}
	.signup-form input[type="checkbox"]{
		margin-top: 3px;
	}
	.signup-form .row div:first-child{
		padding-right: 10px;
	}
	.signup-form .row div:last-child{
		padding-left: 10px;
	}
    .signup-form .btn{        
        font-size: 16px;
        font-weight: bold;
		background: #3598dc;
		border: none;
		min-width: 140px;
    }
	.signup-form .btn:hover, .signup-form .btn:focus{
		background: #2389cd !important;
        outline: none;
	}
    .signup-form a{
		color: grey;
		text-decoration: underline;
	}
	.signup-form a:hover{
		text-decoration: none;
	}
	.signup-form form a{
		color: #3598dc;
		text-decoration: none;
	}	
	.signup-form form a:hover{
		text-decoration: underline;
	}
    .signup-form .hint-text {
		padding-bottom: 15px;
		text-align: center;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


        <div class="container"  style="width:50%">
  <h2>Shipping Calculator</h2>
  <div class="panel panel-default">
    <div class="panel-heading">Shipping Calculator</div>
    <div class="panel-body">

        <div class="col">
                <div class="form-group">
			    <div class="row">
				    <div class="col-xs-6"><asp:TextBox ID="weightTxt" class="form-control" name="weightTxt" placeholder="Weight (KG)" required="required" runat="server"></asp:TextBox></div>
				    <div class="col-xs-6"><asp:TextBox ID="valueTxt" class="form-control" name="valueTxt" placeholder="Value (S$)" required="required" runat="server"></asp:TextBox></div>
			    </div>        	
            </div>
            <%--<div class="form-group">
     
                <div class="input-group">
                <span class="input-group-addon"><i class="fa fa-phone"> +65</i></span>
                <asp:TextBox class="form-control" name="mobile" placeholder="Mobile" required="required" ID="MobileNumber" MaxLength="8" runat="server"></asp:TextBox>
            </div>
                <asp:RegularExpressionValidator style="color:#cc0000;" Display="Dynamic" ControlToValidate="MobileNumber" ID="RegularExpressionValidator1" ValidationExpression="^[\s\S]{8,}$" runat="server" ErrorMessage="Please enter a valid phone number."></asp:RegularExpressionValidator>
                </div>
            <div class="form-group">

            </div>--%>
</div>
</div>
      </div>

      <div class="panel panel-default">
      <div class="panel-heading">Shipping Rates</div>
    <div class="panel-body">
        <div class="col">
                <div class="form-group">
                    <div class="col-xs-6"><asp:TextBox ID="economyTxt" class="form-control" name="economyTxt" placeholder="Economy" runat="server"></asp:TextBox></div>
				    <div class="col-xs-6"><asp:TextBox ID="expressTxt" class="form-control" name="expressTxt" placeholder="Express" runat="server"></asp:TextBox></div>
                  </div>
                        
                    </div>




  </div>
</div>





        



 
                


<div class="form-group">
            <a id="Button1" class="btn btn-danger btn-lg" href="delivery-dashboard.aspx" runat="server" >Cancel</a>

            <asp:Button ID="calculateBtn" class="btn btn-success btn-lg" runat="server" Text="Calculate" OnClick="calculateBtn_Click"  />
        </div>
    </div>
</asp:Content>



