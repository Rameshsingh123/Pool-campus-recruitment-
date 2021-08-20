<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="PoolCampus.Registration" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<!DOCTYPE html>
<html lang="en">
<head>
<link rel="icon" href="images/reg.ico" />
<title>Registration</title>
<!-- metatags-->
<meta name="viewport" content="width=device-width, initial-scale=1">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="keywords" content="wedlock register form a Flat Responsive Widget,Login form widgets, Sign up Web forms , Login signup Responsive web form,Flat Pricing table,Flat Drop downs,Registration Forms,News letter Forms,Elements" />
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false);
function hideURLbar(){ window.scrollTo(0,1); } </script>
<!-- Meta tag Keywords -->
<!-- css -->
    <link href="Registration/css/style.css" rel="stylesheet" type="text/css" />
<!--// css -->
   <%-- <a href="Registration/fonts/Cabin-Regular.ttf"></a>
    <a href="Registration/fonts/Philosopher-Regular.ttf"></a>
    <a href="Registration/fonts/TitilliumWeb-Regular.ttf"></a>--%>
<link href="//fonts.googleapis.com/css?family=Cabin" rel="stylesheet">
<link href="//fonts.googleapis.com/css?family=Titillium+Web" rel="stylesheet">
<link href="//fonts.googleapis.com/css?family=Philosopher" rel="stylesheet">
</head>
<body>
	<section class="agile-header">
		<div class="agile-heading">
			<h1><span class="image"></span>register form</h1>
		</div>
		<div class="agile-form">
			<form id="Form1" runat="server">
                <div class="agile-email">
					<p>Name</p>
					<input type="text" name="name" placeholder="Name" required="">
				</div>
				<div class="agile-email">
					<p>email-address</p>
					<input type="email" name="email-address" placeholder="email-address" required="">
				</div>
				<div class="agile-password">
					<p>password</p>
					<input type="password" name="password" placeholder="password" required="">
				</div>
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                 <div class="agile-password">
					<p>Select City</p>
					<asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="true"
                         onselectedindexchanged="ddlCity_SelectedIndexChanged"></asp:DropDownList>
				</div>
                <div class="agile-password">
					<p>Select College</p>
					<asp:DropDownList ID="ddlCollege" runat="server"></asp:DropDownList>
				</div>
                </ContentTemplate>
                </asp:UpdatePanel>
                <div class="agile-password">
					<p>Mobile Number</p>
					<input type="text" name="mobile-number" placeholder="mobile-number" required="">
				</div>
                  <div class="agile-password">
					<p>Image</p>
					<asp:FileUpload ID="FileUpload1" runat="server"></asp:FileUpload>
				</div>
                 <div class="agile-password">
					<p>Resume</p>
					<asp:FileUpload ID="FileUpload2" runat="server"></asp:FileUpload>
				</div>
				<%--<div class="agile-profile">
					<p>profile seeking for</p>
					<select>
					<option value="" label="Select" selected="selected">Select</option>
					<option>self</option>
					<option>son</option>
					<option>daughter</option>
					<option>brother</option>
					<option>sister</option>
					<option>friend</option>
					<option>relative</option>
					</select>
				</div>--%>
				<%--<div class="agile-fname">
					<p>first name</p>
					<input type="text" name="username" placeholder="first name">
				</div>--%>
				<%--<div class="agile-lname">
					<p>last name</p>
					<input type="text" name="username" placeholder="last name">
				</div>--%>
				<%--<div class="clear"></div>
				<div class="agile-gender">
					<p>gender</p>
					<div class="agile-mgender">
						<input type="radio" name="gender" value="male">
						<span>male</span>
					</div>
					<div class="agile-fgender">
						<input type="radio" name="gender" value="female">
						<span>female</span>
					</div>
					<div class="clear"></div>
				</div>--%>
				<%--<div class="agile-dob">
					<p>date of birth</p>
					<select class="agile-month">
						<option value="" label="Select" selected="selected">Select</option>
						<option>january</option>
						<option>febuary</option>
						<option>march</option>
						<option>april</option>
						<option>may</option>
						<option>june</option>
						<option>july</option>
						<option>august</option>
						<option>september</option>
						<option>october</option>
						<option>november</option>
						<option>december</option>
					</select>
					<select class="agile-date">
						<option value="" label="Select" selected="selected">Select</option>
						<option>1</option>       
						<option>2</option>       
						<option>3</option>       
						<option>4</option>       
						<option>5</option>       
						<option>6</option>       
						<option>7</option>       
						<option>8</option>       
						<option>9</option>       
						<option>10</option>       
						<option>11</option>       
						<option>12</option>       
						<option>13</option>       
						<option>14</option>       
						<option>15</option>       
						<option>16</option>       
						<option>17</option>       
						<option>18</option>       
						<option>19</option>       
						<option>20</option>       
						<option>21</option>       
						<option>22</option>       
						<option>23</option>       
						<option>24</option>       
						<option>25</option>       
						<option>26</option>       
						<option>27</option>       
						<option>28</option>       
						<option>29</option>       
						<option>30</option>       
						<option>31</option>       
					</select>
					<select class="agile-year">
						<option value="" label="Select" selected="selected">Select</option>
						<option>2009</option>       
						<option>2010</option>       
						<option>2011</option>       
						<option>2012</option>       
						<option>2013</option>       
						<option>2014</option>       
						<option>2015</option>       
						<option>2016</option>       
						<option>2017</option>       
						<option>2018</option>     
					</select>
					<div class="clear"></div>
				</div>--%>
				<%--<div class="agile-religion">
					<p> religion</p>
					<select>
						<option value="" label="Select" selected="selected">Select</option>
						<option>Hindu</option>
						<option>Muslim</option>
						<option>Christian</option>
						<option>Sikh</option>
						<option>Parsi</option>
						<option>Jain</option>
						<option>Buddhist</option>
						<option>Jewish</option>
						<option>No Religion</option>
						<option>Spiritual</option>
						<option>Other</option>
					</select>
				</div>--%>
				<%--<div class="agile-tongue">
					<p> mother tongue</p>
					<select>
							<option value="" label="Select" selected="selected">Select</option>
							<option>Tamil</option>
							<option>Telugu</option>
							<option>Assamese</option>
							<option>Bengali</option>
							<option>English</option>
							<option>Gujarati</option>
							<option>Hindi</option>
							<option>Urdu</option>
							<option>Kannada</option>
							<option>Konkani</option>
							<option>Malayalam</option>
							<option>Marathi</option>
							<option>Marwari</option>
							<option>Odia</option>
							<option>Punjabi</option>
							<option>Sindhi</option>
						
						</select>
				</div>--%>
				<div class="agile-submit">
					<%--<input type="submit" value="register">--%>
                    <asp:Button ID="btnRegister" runat="server" Text="Register" 
                        onclick="btnRegister_Click"></asp:Button>
				</div>
                <asp:LinkButton ID="lnkHome" runat="server" PostBackUrl="~/Index.aspx">Home</asp:LinkButton>
			</form>
		</div>
		<div class="clear"></div>
		 <footer>
			&copy;2018 All Rights Reserved
		  </footer>
		
	</section>

</body>
</html>