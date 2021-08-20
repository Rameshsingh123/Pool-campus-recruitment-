<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="PoolCampus.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<main class="app-content">
 <div class="app-title">
        <div>
          <h1><i class="fa fa-dashboard"></i> Dashboard</h1>
          <%--<p>A free and open source Bootstrap 4 admin template</p>--%>
        </div>
        <ul class="app-breadcrumb breadcrumb">
          <li class="breadcrumb-item"><i class="fa fa-home fa-lg"></i></li>
          <li class="breadcrumb-item"><a href="#">Dashboard</a></li>
        </ul>
      </div>
      <form id="form1" runat="server">
 <div class="row">
        <div class="col-md-4 col-lg-4">
          <div class="widget-small primary coloured-icon"><i class="icon fa fa-image fa-3x"></i>
            <div class="info">
              <h4>Cities</h4>
              <b><asp:Label ID="lblCityCount" runat="server" Text=""></asp:Label></b>
            </div>
          </div>
        </div>
        <div class="col-md-4 col-lg-4">
          <div class="widget-small info coloured-icon"><i class="icon fa fa-building-o fa-3x"></i>
            <div class="info">
              <h4>Colleges</h4>
              <b><asp:Label ID="lblCollegeCount" runat="server" Text=""></asp:Label></b>
            </div>
          </div>
        </div>
        <div class="col-md-4 col-lg-4">
          <div class="widget-small warning coloured-icon"><i class="icon fa fa-building fa-3x"></i>
            <div class="info">
              <h4>Companies</h4>
              <b><asp:Label ID="lblCompanyCount" runat="server" Text=""></asp:Label></b>
            </div>
          </div>
        </div>
        </div>
      </form>
</main>
</asp:Content>
