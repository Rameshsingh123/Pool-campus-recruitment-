<%@ Page Title="" Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="StudentUpdatePassword.aspx.cs" Inherits="PoolCampus.StudentUpdatePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
<main class="app-content">
    <form id="Form1" runat="server">
    <div class="app-title">
     <div>
          <h1><i class="fa fa-plus-square-o"></i> Update Password</h1>
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
                                Old Password</label>
                            <asp:TextBox ID="txtOldPwd" class="form-control" runat="server" placeholder="Old Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtOldPwd" ForeColor="red" ValidationGroup="A"
                             runat="server" ErrorMessage="Enter Old Password"></asp:RequiredFieldValidator>
                        </div>
                         <div class="form-group">
                            <label for="exampleInputEmail1">
                                New Password</label>
                            <asp:TextBox ID="txtNewPwd" class="form-control" runat="server" placeholder="New Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ControlToValidate="txtNewPwd" ForeColor="red" ValidationGroup="A"
                             runat="server" ErrorMessage="Enter New Password"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label for="exampleInputPassword1">
                                Confirm Password</label>
                            <asp:TextBox ID="txtConPwd" class="form-control" runat="server" placeholder="Confirm Password"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtConPwd" ForeColor="red" ValidationGroup="A"
                             runat="server" ErrorMessage="Enter Confirm Password"></asp:RequiredFieldValidator>
                        &nbsp;
                            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                ControlToCompare="txtNewPwd" ControlToValidate="txtConPwd" 
                                ErrorMessage="Password Mismatch" ForeColor="Red" ValidationGroup="A"></asp:CompareValidator>
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
