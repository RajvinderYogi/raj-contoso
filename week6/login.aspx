<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="week6.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <h1>Login</h1>
    <div class="form-group">
        <asp:Label ID="lblMessage" runat="server" CssClass="alert alert-info col-sm-offset-3"
             Text="Please enter your credentials" />
    </div>

    <div class="form-group">
        <label for="txtUsername" class="control-label col-sm-3">Username:</label>
        <asp:TextBox ID="txtUsername" runat="server" required />
    </div>
    <div class="form-group">
        <label for="txtPassword" class="control-label col-sm-3">Password:</label>
        <asp:TextBox ID="txtPassword" runat="server" required TextMode="Password" />
    </div>
    <asp:Button runat="server" ID="btnLogin" CssClass="btn btn-success col-sm-offset-3" Text="Login" OnClick="btnLogin_Click" />
</asp:Content>
