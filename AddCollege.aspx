<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AddCollege.aspx.cs" Inherits="PoolCampus.ManageCollege" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="app-content">
    <form id="Form1" runat="server">
    <div class="app-title">
     <div>
          <h1><i class="fa fa-plus-square-o"></i> Add College</h1>
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
                                Select City</label>
                            <asp:DropDownList ID="ddlCity" runat="server" class="form-control"></asp:DropDownList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="ddlCity" ErrorMessage="Select City" ForeColor="red" 
                             InitialValue="--Select--" ValidationGroup="A"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label for="exampleInputEmail1">
                                College Name</label>
                            <asp:TextBox ID="txtCollegeName" class="form-control" runat="server" placeholder="College Name"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtCollegeName" ForeColor="red" ValidationGroup="A"
                             runat="server" ErrorMessage="Enter College Name"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label for="exampleInputPassword1">
                                Email Id</label>
                            <asp:TextBox ID="txtEmail" class="form-control" runat="server" placeholder="Email"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtEmail" ForeColor="red" ValidationGroup="A"
                             runat="server" ErrorMessage="Enter Email"></asp:RequiredFieldValidator>
                             &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" 
                                runat="server" ErrorMessage="Enter Valid Email" ControlToValidate="txtEmail" 
                                ForeColor="Red" 
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                ValidationGroup="A"></asp:RegularExpressionValidator>
                        </div>
                        <div class="form-group">
                            <label for="exampleInputPassword1">
                                Contact Number</label>
                            <asp:TextBox ID="txtNumber" class="form-control" runat="server" placeholder="4 digit number - 7 digit number"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtNumber" ForeColor="red" ValidationGroup="A"
                             runat="server" ErrorMessage="Enter Contact Number"></asp:RequiredFieldValidator>
                        &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" 
                                runat="server" ControlToValidate="txtNumber" ErrorMessage="Enter Valid Number" 
                                ForeColor="Red" ValidationExpression="^([0-9]{4}[\-]{1}[0-9]{7})$" 
                                ValidationGroup="A"></asp:RegularExpressionValidator>
                        </div>
                        <div class="form-group">
                            <label for="exampleTextarea">
                                Image</label>
                            <asp:FileUpload ID="FileUpload1" class="form-control-file" runat="server" />
                        </div>
                        <div class="form-group">
                            <label for="exampleTextarea">
                                Address</label>
                            <asp:TextBox ID="txtAddress" class="form-control" runat="server" placeholder="Address"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtAddress" ForeColor="red" ValidationGroup="A"
                             runat="server" ErrorMessage="Enter Address"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label for="exampleInputPassword1">
                                Web Address</label>
                            <asp:TextBox ID="txtWebAddress" class="form-control" runat="server" placeholder="Web Address"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="txtWebAddress" ForeColor="red" ValidationGroup="A"
                             runat="server" ErrorMessage="Enter Web Address"></asp:RequiredFieldValidator>

                        &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator3" 
                                runat="server" ControlToValidate="txtWebAddress" 
                                ErrorMessage="Enter Valid WebAddress" ForeColor="Red" 
                                ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?" 
                                ValidationGroup="A"></asp:RegularExpressionValidator>

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
