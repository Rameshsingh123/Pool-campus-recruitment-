<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="ManageCities.aspx.cs" Inherits="PoolCampus.ManageCities" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="app-content">
    <form id="Form1" runat="server">
    <div class="app-title">
     <div>
          <h1><i class="fa fa-plus-square-o"></i> Manage Cities</h1>
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
                                City Name</label>
                            <asp:TextBox ID="txtCity" class="form-control" runat="server" placeholder="City Name"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtCity" ForeColor="red" ValidationGroup="A"
                             runat="server" ErrorMessage="Enter City Name"></asp:RequiredFieldValidator>
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
    <br />
      <div class="row">
        <div class="col-lg-12">
            <div class="tile">
                <div class="row">
                    <div class="col-lg-12">
                        
             <%--   <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>--%>
                    <asp:GridView ID="GridView1" 
                            class=" table table-bordered table-hover table-success table-striped" 
                            runat="server" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="CityName" HeaderText="City Name" />
                            <asp:TemplateField HeaderText="Edit">
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkEdit" runat="server" onclick="lnkEdit_Click" 
                                        CommandArgument='<%# Eval("City_Id") %>'>Edit</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Delete">
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkDelete" runat="server" onclick="lnkDelete_Click" 
                                        CommandArgument='<%# Eval("City_Id") %>'>Delete</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        </asp:GridView>
                        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                 <%--   </ContentTemplate>
                    </asp:UpdatePanel>--%>
                    </div>
                   
                </div>
               
            </div>
        </div>
    </div>
    </form>
    </main>
</asp:Content>
