<%@ Page Title="" Language="C#" MasterPageFile="~/Company.Master" AutoEventWireup="true" CodeBehind="Company_AddVacancies.aspx.cs" Inherits="PoolCampus.Company_AddVacancies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
<main class="app-content">
    <form id="Form1" runat="server">
    <div class="app-title">
     <div>
          <h1><i class="fa fa-plus-square-o"></i> Add Vacancy</h1>
          <p></p>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12">
            <div class="tile">
                <div class="row">
                <div class="col-lg-12">
                        <div class="form-group">
                            <label for="exampleInputEmail1">
                                Designation</label>
                            <asp:TextBox ID="txtDesignation" class="form-control" runat="server" placeholder="Designation"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtDesignation" ForeColor="red" ValidationGroup="A"
                             runat="server" ErrorMessage="Enter Designation"></asp:RequiredFieldValidator>
                        </div>
                         <div class="form-group">
                            <label for="exampleInputEmail1">
                                Number Of Vacancies</label>
                            <asp:TextBox ID="txtVacancies" class="form-control" runat="server" placeholder="Vacancies"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ControlToValidate="txtVacancies" ForeColor="red" ValidationGroup="A"
                             runat="server" ErrorMessage="Enter Vacancies"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label for="exampleInputPassword1">
                                Eligible Criteria</label>
                            <asp:TextBox ID="txtEligible" class="form-control" runat="server" TextMode="MultiLine" Width="40%" Height="150px"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtEligible" ForeColor="red" ValidationGroup="A"
                             runat="server" ErrorMessage="Enter Eligibility Criteria"></asp:RequiredFieldValidator>
                        </div>
                         <div class="form-group">
                            <label for="exampleInputPassword1">
                                Prereqisites</label>
                            <asp:TextBox ID="txtPrerequisites" class="form-control" runat="server" TextMode="MultiLine" Width="40%" Height="150px"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator11" ControlToValidate="txtPrerequisites" ForeColor="red" ValidationGroup="A"
                             runat="server" ErrorMessage="Enter Prerequisites"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label for="exampleInputPassword1">
                                Cut Off Percentage In PUC</label>
                            <asp:TextBox ID="txtPUCPercent" class="form-control" runat="server" placeholder="In Percentage"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtPUCPercent" ForeColor="red" ValidationGroup="A"
                             runat="server" ErrorMessage="Enter PUC Percentage"></asp:RequiredFieldValidator>
                        </div>
                         <div class="form-group">
                            <label for="exampleInputPassword1">
                                Cut Off Percentage In Degree</label>
                            <asp:TextBox ID="txtDegreePercent" class="form-control" runat="server" placeholder="In Percentage"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ControlToValidate="txtDegreePercent" ForeColor="red" ValidationGroup="A"
                             runat="server" ErrorMessage="Enter Degree Percentage"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label for="exampleInputPassword1">
                                Benefits</label>
                            <asp:TextBox ID="txtBenefits" class="form-control" runat="server" TextMode="MultiLine" Width="40%" Height="150px"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="txtBenefits" ForeColor="red" ValidationGroup="A"
                             runat="server" ErrorMessage="Enter Benefits"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label for="exampleTextarea">
                                Salary Range</label>
                            <asp:TextBox ID="txtSalary" class="form-control" runat="server" placeholder="10,000-20,000"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtSalary" ForeColor="red" ValidationGroup="A"
                             runat="server" ErrorMessage="Enter Salary Range"></asp:RequiredFieldValidator>
                        </div>
                        <div class="tile-footer pull-right">
                    <asp:Button ID="btnSubmit" class="btn btn-primary" runat="server" Text="Submit" 
                                  onclick="btnSubmit_Click" ValidationGroup="A" />
                    </div>
     </div>
                   
                </div>
               
            </div>
        </div>
    </div>
    </form>
    </main>
</asp:Content>
