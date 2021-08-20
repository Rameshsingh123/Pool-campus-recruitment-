<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Admin_ViewColleges.aspx.cs" Inherits="PoolCampus.Admin_ViewColleges" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="app-content">
    <form id="Form1" runat="server">
    <div class="app-title">
     <div>
          <h1><i class="fa fa-edit"></i> View Colleges</h1>
          <p></p>
        </div>
    </div>
     <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
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
                               <asp:BoundField DataField="Name" HeaderText="College" />
                               <asp:BoundField DataField="EmailId" HeaderText="Email" />
                               <asp:BoundField DataField="ContactNumber" HeaderText="Contact Number" />
                               <asp:TemplateField HeaderText="Image">
                                   <ItemTemplate>
                                       <asp:Image ID="Image1" runat="server" Height="50px" 
                                           ImageUrl='<%# Eval("Image") %>' Width="68px" />
                                   </ItemTemplate>
                               </asp:TemplateField>
                               <asp:BoundField DataField="Address" HeaderText="Address" />
                               <asp:BoundField DataField="WebAddress" HeaderText="Web Address" />
                               <asp:TemplateField HeaderText="Edit">
                                   <ItemTemplate>
                                       <asp:LinkButton ID="lnkEdit" runat="server" 
                                           CommandArgument='<%# Eval("College_Id") %>' onclick="lnkEdit_Click">Edit</asp:LinkButton>
                                   </ItemTemplate>
                               </asp:TemplateField>
                               <asp:TemplateField HeaderText="Delete">
                                   <ItemTemplate>
                                       <asp:LinkButton ID="lnkDelete" runat="server" 
                                           CommandArgument='<%# Eval("College_Id") %>' onclick="lnkDelete_Click">Delete</asp:LinkButton>
                                   </ItemTemplate>
                               </asp:TemplateField>
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
