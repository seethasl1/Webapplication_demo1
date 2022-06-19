<%@ Page Title="" Language="C#" MasterPageFile="~/Mainmaster.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Project1_webapp.LoginPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       <div class="container">
    <div class="row align-items-center vh-100">
        <div class="col-6 mx-auto">
            <div class="card shadow border">
                <div class="card-body d-flex flex-column align-items-center">
                    <div>
                        <h5 class="card-title">Login</h5>
                    </div>
                     <div class="form-floating">
            <asp:TextBox type="Text" class="form-control" id="UserName" placeholder="name@example.com" runat="server"/>

  <label for="floatingInput">Email address</label>
        </div>
                    <br />
                    <div class="form-floating">
  <asp:TextBox type="Password" class="form-control" id="Password" placeholder="Ab123" runat="server"/>
  <label for="floatingPassword">Password</label>
</div>
                           <asp:Button ID="Button1" runat="server" Text="SigIn" OnClick="Button1_Click" />
                    <br />
                    <div class="form-floating">
                           &nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Remember Me:<asp:CheckBox ID="CheckBox1" runat="server" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </div>
                 

                </div>
            </div>
        </div>
    </div>
</div>
</asp:Content>
