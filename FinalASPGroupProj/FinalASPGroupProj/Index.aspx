<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="FinalASPGroupProj.Customer_Register" %>

		
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
              <li><a href='Customer_Register.aspx'><span class='glyphicon glyphicon-user navbar-left'></span> Register</a></li>
              <li><a href='#' data-toggle='modal' data-target='#myModal'><span class='glyphicon glyphicon-log-in'></span> Customer login</a></li>
            </ul>
            
          </div>
        </div>
      </nav>


		<center>
			<br>
			<br>
			<div>
				<font size="2" color='white'>
					Good Afternoon Welcome to travel experts!</p>				</font>
				<div id="asiaImg" class="carousel slide img-responsive" data-ride="carousel" />
				<!-- Indicators -->
				<ol class="carousel-indicators">
					<li data-target="#myCarousel" data-slide-to="0" class="active"></li>
					<li data-target="#myCarousel" data-slide-to="1"></li>
					<li data-target="#myCarousel" data-slide-to="2"></li>
					<li data-target="#myCarousel" data-slide-to="3"></li>
				</ol>
				<!-- Wrapper for slides -->
				<!-- Wrapper for slides -->
				<div class="carousel-inner" role="listbox">
					<div class="item active">
						<img src="images/tr1.jpg" alt="malaysia">
						<div class="carousel-caption">
							<h3>Malaysia</h3>
							<p>Twin Towers are Must See ..</p>
						</div>
					</div>

					<div class="item">
						<img src="images/tr2.jpg" alt="india">
						<div class="carousel-caption">
							<h3>India</h3>
							<p>Great Sculpture to Explore..</p>
						</div>
					</div>

					<div class="item">
						<img src="images/tr3.jpg" alt="bangkok">
						<div class="carousel-caption">
							<h3>Bangkok</h3>
							<p>Great beaches up here...</p>
						</div>
					</div>

					<div class="item">
						<img src="images/tr4.jpg" alt="singapore">
						<div class="carousel-caption">
							<h3>Singapore</h3>
							<p>Different types of food makes unique this country..</p>
						</div>

					</div>
				</div>
				<!-- Left and right controls -->
				<a class="left carousel-control" href="#asiaImg" role="button" data-slide="prev">
					<span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
					<span class="sr-only">Previous</span>
				</a>
				<a class="right carousel-control" href="#asiaImg" role="button" data-slide="next">
					<span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
					<span class="sr-only">Next</span>
				</a>
			</div>
		</center>

		<style type="text/css">
			.data-toggle, .togleimg {
				margin:100px 150px 100px 80px;
				border: 1px solid #ccc;
				border-radius:5px;
				float: left;
				width: 180px;
			}

			div img:hover {
				border: 1px solid #777;
			}

			div img img {
				width:100% ;
				height: 100%;
			}
		</style>

		<div class="rows">
			<div class="col-xs-12 col-sm-6 col-md-4">
				<h1 style="padding-left:40px; font-size:20px;"><a href="#demo" class="btn btn-info" data-toggle="collapse">China</a></h1>
				<div id="demo" class="collapse">
					<img class="togleimg" src="images/china.jpg">
				</div>
				<p style="padding: 10px 30px 50px 40px;">
					Mauris vel vulputate sapien. Duis ante lacus, ultricies porttitor auctor in, suscipit a mauris. Nullam tincidunt vestibulum ornare. Integer eu odio iaculis, egestas nibh iaculis, vehicula nisl. Etiam consequat est orci, pellentesque ultricies nunc elementum vel. Nam eget auctor elit. Integer ac erat ac nisi viverra suscipit a et tortor. Quisque consequat pharetra egestas. Donec at sapien eget dolor ultricies auctor. Ut consectetur odio ut porta convallis. Quisque pretium elit interdum ultrices condimentum. Cras erat lorem, consequat eget lectus non, luctus commodo nibh.</p>
					<iframe src="http://www.youtube.com/embed/sLfPtXSb7ZQ"
					width="320" height="180" frameborder="0" allowfullscreen></iframe>
				</div>
				<div class="col-xs-12 col-sm-6 col-md-4">
					<h1 style="padding-left:40px; font-size:20px;"><a href="#demo1" class="btn btn-info" data-toggle="collapse">Myanmar</a></h1>
					<div id="demo1" class="collapse">
						<img class="togleimg" src="images/myanmar.jpg">
					</div>
					<p style="padding: 10px 30px 50px 40px;"> 
						Mauris vel vulputate sapien. Duis ante lacus, ultricies porttitor auctor in, suscipit a mauris. Nullam tincidunt vestibulum ornare. Integer eu odio iaculis, egestas nibh iaculis, vehicula nisl. Etiam consequat est orci, pellentesque ultricies nunc elementum vel. Nam eget auctor elit. Integer ac erat ac nisi viverra suscipit a et tortor. Quisque consequat pharetra egestas. Donec at sapien eget dolor ultricies auctor. Ut consectetur odio ut porta convallis. Quisque pretium elit interdum ultrices condimentum. Cras erat lorem, consequat eget lectus non, luctus commodo nibh. </p>
						<iframe src="http://www.youtube.com/embed/MpnbprgsbYc"
						width="320" height="180" frameborder="0" allowfullscreen></iframe>
					</div>
				<div class="col-xs-12 col-sm-6 col-md-4">
					<h1 style="padding-left:40px; font-size:20px;"><a href="#demo1" class="btn btn-info" data-toggle="collapse">indonesia</a></h1>
					<div id="demo1" class="collapse">
						<img class="togleimg" src="images/indonesia.jpg">
					</div>
					<p style="padding: 10px 30px 50px 40px;"> 
						Mauris vel vulputate sapien. Duis ante lacus, ultricies porttitor auctor in, suscipit a mauris. Nullam tincidunt vestibulum ornare. Integer eu odio iaculis, egestas nibh iaculis, vehicula nisl. Etiam consequat est orci, pellentesque ultricies nunc elementum vel. Nam eget auctor elit. Integer ac erat ac nisi viverra suscipit a et tortor. Quisque consequat pharetra egestas. Donec at sapien eget dolor ultricies auctor. Ut consectetur odio ut porta convallis. Quisque pretium elit interdum ultrices condimentum. Cras erat lorem, consequat eget lectus non, luctus commodo nibh. </p>
					<iframe src="http://www.youtube.com/embed/aT3mnZI9ua0"
					width="320" height="180" frameborder="0" allowfullscreen>dfd</iframe>
					</div>

				</div>
				<br /><br />

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

