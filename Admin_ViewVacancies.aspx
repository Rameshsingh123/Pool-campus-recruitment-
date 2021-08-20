<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Admin_ViewVacancies.aspx.cs" Inherits="PoolCampus.Admin_ViewVacancies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="app-content">
    <form id="Form1" runat="server">
    <div class="app-title">
     <div>
          <h1><i class="fa fa-edit"></i> View Companies</h1>
          <p></p>
        </div>
    </div>
     <%--<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>--%>
                     <div class="row">
        <div class="col-lg-6">
        <div class="tile">
    <div class="row">
    <div class="col-lg-6">
    <label>Select City</label>
    <asp:DropDownList ID="ddlCity" runat="server" class="form-control" AutoPostBack="true" 
            onselectedindexchanged="ddlCity_SelectedIndexChanged"></asp:DropDownList>
    </div>
     <div class="col-lg-6">
    <label>Select Company</label>
    <asp:DropDownList ID="ddlCompany" runat="server" class="form-control" AutoPostBack="true" 
             onselectedindexchanged="ddlCompany_SelectedIndexChanged"></asp:DropDownList>
    </div>
    </div>
    </div>
    </div>
    </div>
     <%--</ContentTemplate>
                    </asp:UpdatePanel>--%>
    <br />
                <div class="row">
                    <div class="col-lg-12">
                  <asp:GridView ID="GridView1" 
                            class=" table table-bordered table-hover table-success table-striped" 
                            runat="server" AutoGenerateColumns="False"> 
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="true"
                                        oncheckedchanged="CheckBox1_CheckedChanged" Text='<%# Eval("Vacancy_Id") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="Designation" HeaderText="Designation" />
                            <asp:BoundField DataField="NumberOfVacancies" HeaderText="Vacancies" />
                            <asp:BoundField DataField="EligibleCriteria" HeaderText="Eligible Criteria" />
                            <asp:BoundField DataField="Prerequisites" HeaderText="Prerequisites" />
                            <asp:BoundField DataField="PUCMarks_Percent" HeaderText="PUC Marks" />
                            <asp:BoundField DataField="DegreeMarks_Percent" HeaderText="Degree Marks" />
                            <asp:BoundField DataField="Benefits" HeaderText="Benefits" />
                            <asp:BoundField DataField="Salary_Range" HeaderText="Salary Range" />
                            <asp:TemplateField HeaderText="Location">
                                <ItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Visible="False" 
                                        Text='<%# Eval("Location") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Date">
                                <ItemTemplate>
                                    <asp:TextBox ID="TextBox2" runat="server" Visible="False" class="picker" 
                                        Text='<%# Eval("Date") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        </asp:GridView>
                        <div class="pull-right">
                        <asp:Button ID="btnSaveChanges" runat="server" Text="Save Changes" 
                                class="btn-primary" onclick="btnSaveChanges_Click" Visible="False" ></asp:Button>
                        </div>
                        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                    </div>
                </div>
               
    </form>
    </main>
     <script src="BootStrap_DataPicker/DatePicker/bootstrap-datepicker.js" type="text/javascript"></script>
    <script>
        $(document).ready(function () {
            $(".picker").datepicker({ format: 'dd-mm-yyyy', autoclose: true, todayBtn: 'linked', todayHighlight: true })
        });
    </script>
</asp:Content>
