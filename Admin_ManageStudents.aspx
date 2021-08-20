<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Admin_ManageStudents.aspx.cs" Inherits="PoolCampus.Admin_ManageStudents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <main class="app-content">
    <form id="Form1" runat="server">
    <div class="app-title">
     <div>
          <h1><i class="fa fa-edit"></i> View Colleges</h1>
          <p></p>
        </div>
    </div>
                     <div class="row">
        <div class="col-lg-6">
        <div class="tile">
    <div class="row">
    <div class="col-lg-6">
    <label>Select City</label>
    <asp:DropDownList ID="ddlCity" runat="server" class="form-control" AutoPostBack="true" 
            onselectedindexchanged="ddlCity_SelectedIndexChanged"></asp:DropDownList>
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
                            <asp:BoundField DataField="Name" HeaderText="Student Name" />
                            <asp:BoundField DataField="EmailId" HeaderText="Email" />
                            <asp:BoundField DataField="Expr1" HeaderText="College" />
                            <asp:BoundField DataField="MobileNumber" HeaderText="Contact Number" />
                            <asp:TemplateField HeaderText="Pic">
                                <ItemTemplate>
                                    <asp:Image ID="Image1" runat="server" Height="68px" 
                                        ImageUrl='<%# Eval("Image") %>' Width="83px" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Resume">
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkDownload" runat="server" 
                                        CommandArgument='<%# Eval("Resume") %>' onclick="lnkDownload_Click">Download</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Approve">
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkApprove" runat="server" 
                                        CommandArgument='<%# Eval("Registration_Id") %>' onclick="lnkApprove_Click">Approve</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Reject">
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkReject" runat="server" 
                                        CommandArgument='<%# Eval("Registration_Id") %>' onclick="lnkReject_Click">Reject</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        </asp:GridView>
                        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                    </div>
                </div>
    </form>
    </main>
</asp:Content>
