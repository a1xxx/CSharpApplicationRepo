<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer_Register.aspx.cs" Inherits="FinalASPGroupProj.Customer_Register" %>

<!DOCTYPE html>


<style type="text/css">
    .auto-style1 {
        margin-right: -15px;
        margin-left: -15px;
        text-align: left;
    }
    .auto-style2 {
        width: 137px;
    }
    .auto-style3 {
        width: 122px;
    }
    .auto-style4 {
        width: 89px;
    }
    .auto-style5 {
        width: 165px;
    }
    .auto-style6 {
        width: 217px;
    }
    .auto-style7 {
        width: 169px;
    }
</style>


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
              <li><a href='Index.aspx'>HOME</a></li>
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




					

		
<div class="container">
					
		<form id="form1" runat="server">
					
		<div class="auto-style1">
        <div class="col-md-4">
                
               <div class="form-group">
					<label for="inputName" class="control-label">First name</label>&nbsp;
                    <br />
                    <asp:TextBox ID="txtBoxFirstName" runat="server" Height="28px" Width="706px"></asp:TextBox>
				</div>
			
            	<div class="form-group">
					<label for="inputName" class="control-label">Last name</label>
	                <br />
                    <asp:TextBox ID="txtBoxLastName" runat="server" Height="28px" OnTextChanged="txtBoxLastName_TextChanged" Width="706px"></asp:TextBox>
                    <br />
&nbsp;<br />
&nbsp;<label for="inputName" class="control-label">Password</label><br />
                    <asp:TextBox ID="txtBoxPassword" runat="server" Height="28px" Width="706px"></asp:TextBox>
&nbsp;<br />
                    <br /><strong>Confirm Password</strong><br />
                    <asp:TextBox ID="txtBoxConfirmPass" runat="server" Height="28px" Width="706px"></asp:TextBox>
            	</div>
				
			<div class="form-group">                
	                <label class="auto-style2">Gender</label> 
	                <br />
                    <asp:TextBox ID="txtBoxGender" runat="server" Height="28px" Width="706px"></asp:TextBox>
&nbsp;</div>
			
				<div class="form-group">                
	                <label class="auto-style3">Address</label> 
	                <br />
                    <asp:TextBox ID="txtBoxAddress" runat="server" Height="28px" Width="706px"></asp:TextBox>
&nbsp;</div>
		
			
			
					
				<div class="form-group">                
	                <label class="auto-style4">City</label> 
	                <br />
                    <asp:TextBox ID="txtBoxCity" runat="server" Height="28px" Width="706px"></asp:TextBox>
&nbsp;</div>
			
			
			
					
				<div class="form-group">                
	                <label>Province/State</label> 
	                <br />
                    <asp:TextBox ID="txtBoxProv" runat="server" Height="28px" Width="706px"></asp:TextBox>
&nbsp;</div>
		
				<div class="form-group">                
	                <label>PostalCode</label> 
	                <br />
                    <asp:TextBox ID="txtBoxPostal" runat="server" Height="28px" Width="706px"></asp:TextBox>
&nbsp;</div>
				
		
					
					
				<div class="form-group">                
	                <label>Country</label>
                    <br />
                    <asp:TextBox ID="txtBoxCountry" runat="server" Height="28px" Width="706px"></asp:TextBox>
&nbsp;</div>
				
				
			<div class="form-group">                
	                <label>Home Phone Number</label>
                    <asp:TextBox ID="txtBoxHomePhone" runat="server" Height="28px" OnTextChanged="txtBoxHomePhone_TextChanged" Width="706px"></asp:TextBox>
&nbsp;</div>			
			
				<div class="form-group">                
	                <label class="auto-style6">Business Phone Number</label> 
	                <asp:TextBox ID="txtBoxBusPhone" runat="server" Height="28px" Width="706px"></asp:TextBox>
&nbsp;</div>	
						
				<div class="form-group">                
	                <label class="auto-style5">Customer Email</label> 
	                <br />
                    <asp:TextBox ID="txtBoxCustEmail" runat="server" Height="28px" Width="706px"></asp:TextBox>
&nbsp;</div>	
				
				<div class="form-group">                
	                <label class="auto-style7">Customer About</label> 
	                <br />
                    <asp:TextBox ID="txtBoxCustAbout" runat="server" Height="28px" Width="706px"></asp:TextBox>
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnRegCust" runat="server" OnClick="btnRegCust_OnClick" Text="Register" />
                    <br />
&nbsp;</div>
				
				
				</div>
				
			</br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </br></br></br>
			
			
			



        </form>

			
			
			



