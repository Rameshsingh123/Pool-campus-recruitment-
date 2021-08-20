<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="PoolCampus.LogIn" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<!DOCTYPE HTML>
<html>

<head>
<link  rel="icon" href="images/icoLogin.ico"/>
	<title>Pool Campus</title>
	<!-- Meta Tags -->
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<meta name="keywords" content="Precise Contact Form template Responsive, Login form web template,Flat Pricing tables,Flat Drop downs Sign up Web Templates, 
 Flat Web Templates, Login sign up Responsive web template, SmartPhone Compatible web template, free web designs for Nokia, Samsung, LG, SonyEricsson, Motorola web design">
	<script type="application/x-javascript">
		addEventListener("load", function () {
			setTimeout(hideURLbar, 0);
		}, false);

		function hideURLbar() {
			window.scrollTo(0, 1);
		}
	</script>
	<!--// Meta Tags -->
	<!-- Stylesheet -->
	<%--<link href="css/style.css" rel='stylesheet' type='text/css' />--%>
    <link href="LogIn/css/style.css" rel="stylesheet" type="text/css" />
    <link href="LogIn/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
	<!--// Stylesheet -->
	<!--fonts-->
	<link href="//fonts.googleapis.com/css?family=Montserrat:300,400,500,600,700,800" rel="stylesheet">
	<!--//fonts-->
</head>

<body>
	<!--background-->
	<!-- Contact form -->
<br /><br /><br /><br /><br /><br />
	<h1></h1>
	<div class="contact-main-w3-agile">
		<div class="top-section-wthree">
			<h2 class="sub-title">Log In</h2>
			<p></p>
		</div>
		<div class="form-agileits-w3layouts">
            <form id="Form1" runat="server">
            <div>
                <select required class="example" name="Type">
                    <option value="">--Select--</option>
                    <option value="Admin">Admin</option>
                    <option value="Company">Company</option>
                    <option value="Student">Student</option>
                </select>
                <%-- <asp:DropDownList ID="ddlType" class="example" runat="server">
                    <asp:ListItem>--Select--</asp:ListItem>
                    <asp:ListItem>Admin</asp:ListItem>
                </asp:DropDownList>--%>
            </div>
            <div class="form-w3layouts-fields">
                <input type="email" name="Email" onfocus="this.value=''" placeholder="Email" required="" />
            </div>
            <div class="form-w3layouts-fields">
                <input type="password" name="Password" placeholder="Password" required="" />
            </div>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            
            <div class="pull-left">
                <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Index.aspx">Home</asp:LinkButton>
            </div>
            </form>
		</div>
		<!-- // Contact form -->
	</div>
	<div class="clear"></div>
	<div class="copy-right-agileinfo">
		<%--<p>© 2018 Precise Contact Form. All Rights Reserved | Design by
			<a href="http://w3layouts.com/"> W3layouts</a>
		</p>--%>
	</div>
	<!--//background-->
</body>

</html>
