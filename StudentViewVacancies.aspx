<%@ Page Title="" Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="StudentViewVacancies.aspx.cs" Inherits="PoolCampus.StudentViewVacancies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <main class="app-content">
    <form id="Form1" runat="server">
    <div class="app-title">
     <div>
          <h1><i class="fa fa-edit"></i> View Vacancies</h1>
          <p></p>
        </div>
    </div>
     <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                     <div class="row">
        <div class="col-lg-12">
        <div class="tile">
    <div class="row">
    <div class="col-lg-12">
    <div class="form-group">
    <label>Select Designation</label>
    <asp:DropDownList ID="ddlDesignation" runat="server" class="form-control"></asp:DropDownList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Select Designation" ControlToValidate="ddlDesignation" ForeColor="Red" ValidationGroup="A" InitialValue="--Select--"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group">
    <label>Enter PUC Percentage</label>
    <asp:TextBox ID="txtPUPercentage" runat="server" class="form-control" placeholder="eg. 60"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter PUC Percentage" ControlToValidate="txtPUPercentage" ForeColor="Red" ValidationGroup="A"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group">
    <label>Enter Degree Percentage</label>
    <asp:TextBox ID="txtDegreePercentage" runat="server" class="form-control" placeholder="eg. 60"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter Degree Percentage" ControlToValidate="txtDegreePercentage" ForeColor="Red" ValidationGroup="A"></asp:RequiredFieldValidator>
    </div>
    <div class="tile-footer pull-right">
    <asp:Button ID="btnFind" runat="server" Text="Find" onclick="btnFind_Click" ValidationGroup="A" class="btn btn-success"></asp:Button>
    </div>
    </div>
    </div>
    </div>
    </div>
    </div>
    <br />
                <div class="row">
                    <div class="col-lg-12">
                  <asp:GridView ID="GridView1" 
                            class=" table table-bordered table-hover table-success table-striped" 
                            runat="server" AutoGenerateColumns="False">
                          
                        <Columns>
                            <asp:BoundField DataField="Name" HeaderText="Company Name" />
                            <asp:BoundField DataField="NumberOfVacancies" 
                                HeaderText="Number Of Vacancies" />
                            <asp:BoundField DataField="EligibleCriteria" HeaderText="Eligible Criteria" />
                            <asp:BoundField DataField="Prerequisites" HeaderText="Prerequisites" />
                            <asp:BoundField DataField="PUCMarks_Percent" HeaderText="Cut-Off PU Percent" />
                            <asp:BoundField DataField="DegreeMarks_Percent" 
                                HeaderText="Cut-Off Degree Percent" />
                            <asp:BoundField DataField="Benefits" HeaderText="Benefits" />
                            <asp:BoundField DataField="Salary_Range" HeaderText="Salary_Range" />
                            <asp:BoundField DataField="Location" HeaderText="Location" />
                            <asp:BoundField DataField="Date" HeaderText="Date" 
                                DataFormatString="{0:dd/MMM/yyyy}" />
                        </Columns>
                          
                        </asp:GridView>
                        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                </ContentTemplate>
                    </asp:UpdatePanel>
    </form>
    </main>
</asp:Content>
