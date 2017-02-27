<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer_Login.aspx.cs" Inherits="FinalASPGroupProj.Customer_Login" %>


<!DOCTYPE html>
<div class="modal fade" id="myModal" role="dialog">
	<div class="modal-dialog">
		<div class="modal-content">
			<div class="modal-header">
				<button type="button" class="close" data-dismiss="modal">&times;</button>
				<center><h5 class="modal-title">LOGIN TO TRAVEL EXPERTS</h5></center>
				<form method="post" action="checklogin.php" class="formato ajax">
					<div  class="form-group" id="form_container">
						<p class="modal-title">User ID* (to test this application use "user1" as user ID and "user1" as password) </p>
						<div class="message-ajax " id='message-log'></div>
						<input id="AgentUserID" type="text" class="form-control" maxlength="128" size="14"value=""  name="AgtUserId" placeholder="Enter your user ID"/>
						<label>User ID* </label>
						<input type="password" name="AgtPassword" class="form-control" maxlength="128" size="14" value="" placeholder="Enter password"/><br/>
						<center> <input  class="btn btn-info" type="submit" value="Log In" /> </center>
					</div>
				</form>
			</div>
		</div>
	</div>
</div>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script> <div class="modal fade" id="myModal2" role="dialog">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal">&times;</button>
         <center><h5 class="modal-title">LOG OUT FROM TRAVEL EXPERTS</h5></center>
        <form method="post" action="logout.php" class="formato">
          <div  class="form-group" id="form_container">
           <center>
             <p class="modal-title">Are you sure you want to log out?</p>
           </center>
           <center>
             <div class="row">
               <input  class="btn btn-danger btn-t" type="submit" name="submit" value="Log out" /> 
               <input  class="btn btn-info btn-t" type="submit" name="submit" value="Cancel" /> 
               </div>
           </center>
         </div>
       </form>
     </div>
   </div>
 </div>
</div>
<html lang="en">
<head runat="server">
	<meta charset="UTF-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
	<link rel="stylesheet" type="text/css" href="styles/mystyle.css" media="all">
</head>
<body data-spy="scroll" data-target=".navbar" data-offset="50">
	<div class="container">
		      <nav class='navbar navbar-inverse'>
        <div class='container-fluid'>
          <div class='navbar-header'>
            <button type='button' class='navbar-toggle' data-toggle='collapse' data-target='#myNavbar'>
              <span class=icon-bar></span>
              <span class=icon-bar></span>
              <span class='icon-bar'></span>
            </button>
            <a class='navbar-brand' href='#'></a>
          </div>
          <div class='collapse navbar-collapse' id='myNavbar'>
            <ul class='nav navbar-nav'>
              <li><a href='index.php'>HOME</a></li>
              <li><a href='contact.php'>CONTACTS</a></li>
              <li><a href='Packages.php'>DESTINATIONS</a></li> 
            </ul>
            <ul class="nav navbar-nav navbar-right">
              <li><a href='register.php'><span class='glyphicon glyphicon-user navbar-left'></span> Register</a></li>
              <li><a href='#' data-toggle='modal' data-target='#myModal'><span class='glyphicon glyphicon-log-in'></span> Customer login</a></li>
            </ul>
            
          </div>
        </div>
      </nav>


   
              <form id="form1" runat="server">
<br/>
                  <br />
                  <br />
      <label>Customer ID </label>
                  <br/>
                  <asp:TextBox ID="txtBoxCustId" runat="server" Width="515px"></asp:TextBox>
                  <br/><br/>

   <div  class="form-group" id="form_container">
      &nbsp;<br />
      <label>Password<br />
       <asp:TextBox ID="txtBoxCustPass" runat="server" OnTextChanged="TextBox2_TextChanged" Width="515px"></asp:TextBox>
       </label>
       <br />
      <center> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Button ID="btnCustLogin" runat="server" OnClick="btnCustLogin_Click" Text="Login" />
       </center>
      
   </div>
              </form>
<br />
	</div>
	<br><br><br>
	<br><br><br>
	<style>
		.copyright {
			width: 100%;
			display: block;
			bottom: 0px;
			margin: 50px auto 5px auto;
			font-color:#fff;

		}
		.row
		{
			border:5px,solid,#ccc;
			background-color:#222;
			font-family: "Arial", Georgia, Cursive;
		}
		.footer-links

		{
			font-size:10px;
		}

	</style>
	<div class="container text-center">
		<br />
		<br />
		<div class="row">

			<div class="col-sm-4">
				<ul class="nav nav-pills nav-stacked">
					<li><a href="#">About us</a></li>
					<li><a href="#">Contact Us</a></li>
					<li><a href="#">Dashboard</a></li>
				</ul>
			</div>
			<div class="col-sm-4">
				<ul class="nav nav-pills nav-stacked">
					<li><a href="#">Package1</a></li>
					<li><a href="#">Package2</a></li>
					<li><a href="#">Package3</a></li>
				</ul>
			</div>
			<div class="col-sm-4">
				<ul class="nav nav-pills nav-stacked">
					<li><a href="#">Agent SignUp</a></li>
					<li><a href="#">Customer SignUp</a></li>
					<li><a href="#">GoogleMap</a></li>          
				</ul>
			</div>
		</div>
		<hr>
	</div>
</div>
<div class="copyright">
	<center><div class="copyright"> Copyright 2016 &#169; Travel Experts, Inc.</div></center>
</div>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
<script src="scripts/script.js"></script>
</body>
</html>