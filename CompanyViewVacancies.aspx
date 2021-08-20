<%@ Page Title="" Language="C#" MasterPageFile="~/Company.Master" AutoEventWireup="true" CodeBehind="CompanyViewVacancies.aspx.cs" Inherits="PoolCampus.CompanyViewVacancies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <main class="app-content">
    <form id="Form1" runat="server">
    <div class="app-title">
     <div>
          <h1><i class="fa fa-edit"></i> View Vacancies</h1>
          <p></p>
        </div>
    </div>
                <div class="row">
                    <div class="col-md-12">
                    <%-- <div class="tile">
            <div class="tile-body">--%>
                  <asp:GridView ID="GridView1" 
                            class=" table table-hover table-success table-striped table-responsive" 
                            runat="server" AutoGenerateColumns="False">
                      <Columns>
                          <asp:BoundField DataField="Designation" HeaderText="Designation" />
                          <asp:BoundField DataField="NumberOfVacancies" HeaderText="Vacancies" />
                          <asp:BoundField DataField="EligibleCriteria" HeaderText="Eligible Criteria" />
                          <asp:BoundField DataField="Prerequisites" HeaderText="Prerequisites" />
                          <asp:BoundField DataField="PUCMarks_Percent" HeaderText="PUC_Marks" />
                          <asp:BoundField DataField="DegreeMarks_Percent" HeaderText="Degree_Marks" />
                          <asp:BoundField DataField="Benefits" HeaderText="Benefits" />
                          <asp:BoundField DataField="Salary_Range" HeaderText="Salary_Range" />
                          <asp:BoundField DataField="Location" HeaderText="Location" />
                          <asp:BoundField DataField="Date" HeaderText="Date" />
                          <asp:TemplateField HeaderText="Edit">
                              <ItemTemplate>
                                  <asp:LinkButton ID="lnkEdit" runat="server" 
                                      CommandArgument='<%# Eval("Vacancy_Id") %>' onclick="lnkEdit_Click">Edit</asp:LinkButton>
                              </ItemTemplate>
                          </asp:TemplateField>
                          <asp:TemplateField HeaderText="Delete">
                              <ItemTemplate>
                                  <asp:LinkButton ID="lnkDelete" runat="server" 
                                      CommandArgument='<%# Eval("Vacancy_Id") %>' onclick="lnkDelete_Click">Delete</asp:LinkButton>
                              </ItemTemplate>
                          </asp:TemplateField>
                      </Columns>
                        </asp:GridView>
                        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                        </div>
                <%--</div>
                    </div>--%>
                </div>
    </form>
    </main>
</asp:Content>
