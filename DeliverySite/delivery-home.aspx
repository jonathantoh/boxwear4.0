<%@ Page Title="" Language="C#" MasterPageFile="~/DeliverySite/delivery-MasterPage.master" AutoEventWireup="true" CodeFile="delivery-home.aspx.cs" Inherits="DeliverySite_delivery_home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <title>Home</title>
     <!-- Bootstrap core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet"/>
    <link href="css/style.css" rel="stylesheet"/>
    <script src="http://cdn.ckeditor.com/4.6.1/standard/ckeditor.js"></script>
      

    <!--for 3 pictures-->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
   

    <style type="text/css">

.business-header {
  height: 50vh;
  min-height: 300px;
  background: url('delivery-images/delivery-bg.png') center center no-repeat scroll;
  -webkit-background-size: cover;
  -moz-background-size: cover;
  background-size: cover;
  -o-background-size: cover;
}

.card {
  height: 100%;
}

/* Boostrap Buttons Styling */
.btny{
    margin-left: 20px;
    margin-right: 20px;
    padding:10px 40px 10px 40px;
}

.btny-defaulty {
  font-family: Raleway-SemiBold;
  font-size: 13px;
  color: #20b2aa;
  letter-spacing: 1px;
  line-height: 15px;
  border: #20b2aa;
  border-radius: 40px;
  background: white;
  transition: all 0.3s ease 0s;
}

.btny-defaulty:hover {
  color: #FFF;
  background: #20b2aa;
  border: #20b2aa;
}

    </style>
      

   

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <!-- Header with Background Image -->
    <header class="business-header">
      <div class="container">
        <div class="row">
          <div class="col-lg-12">
            <h1 class="display-3 text-center text-white mt-4" style="font-size:56px;padding-top:30px">
                <strong>JUDO VAN SINGAPORE</strong></h1>
          </div>

        </div>
          <div class="row">
          <div class="col-lg-12">
            <h1 class="display-3 text-center text-white mt-4">
                <button type="button" class="btny btny-defaulty">Start shipping with us</button>
                <button type="button" class="btny btny-defaulty">Track your order</button>
                <button type="button" class="btny btny-defaulty">Create a return order</button>
                </h1>
          </div>

        </div>
      </div>
    </header>


    <br />

          <div class="container" style="margin-top:60px">
         <div class="row">
    <div class="col-md-4">
      <div class="thumbnail">
        <a href="/images/home_mens.jpg" target="_blank">
          <img src="/images/home_mens.jpg" alt="Lights" style="width:100%"/>
          
        </a>
      </div>
    </div>
    <div class="col-md-4">
      <div class="thumbnail">
        <a href="/images/home_womens.jpg" target="_blank">
          <img src="/images/home_womens.jpg" alt="Nature" style="width:100%"/>
          
        </a>
      </div>
    </div>
    <div class="col-md-4">
      <div class="thumbnail">
        <a href="/w3images/fjords.jpg" target="_blank">
          <img src="/images/home_mens.jpg" alt="Fjords" style="width:100%"/>
          
        </a>
      </div>
    </div>
  </div>
              

              <div class="row">
        <div class="col-sm-4 my-4">
          <div class="card">
            <img class="card-img-top" src="images/jordans.jpg" style="width:auto;height:300px" alt=""/>
            <div class="card-body">
              <h4 class="card-title"><strong>Jordans Box</strong></h4>
              <p class="card-text">$299.00</p>
            </div>
            <div class="card-footer">
              <a href="MenProducts3.aspx" class="btn btn-primary">Find Out More!</a>
            </div>
          </div>
        </div>
        <div class="col-sm-4 my-4">
          <div class="card">
            <img class="card-img-top" src="images/pants.jpg" style="width:auto;height:300px" alt="">
            <div class="card-body">
              <h4 class="card-title"><strong>Pants Box</strong></h4>
              <p class="card-text">$79.00</p>
            </div>
            <div class="card-footer">
              <a href="MenProducts3.aspx" class="btn btn-primary">Find Out More!</a>
            </div>
          </div>
        </div>
        <div class="col-sm-4 my-4">
          <div class="card">
            <img class="card-img-top" src="images/supreme.jpg" style="width:auto;height:300px" alt="">
            <div class="card-body">
              <h4 class="card-title"><strong>Tee shirt Box</strong></h4>
              <p class="card-text">$49.00</p>
            </div>
            <div class="card-footer">
              <a href="MenProducts3.aspx" class="btn btn-primary">Find Out More!</a>
            </div>
          </div>
        </div>

      </div>
      <!-- /.row -->


              
    
    </div>
    <br />
</asp:Content>

