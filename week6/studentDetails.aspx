<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="studentDetails.aspx.cs" Inherits="week6.studentDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <h1>Student Details</h1>
    <div class="form-group">
        <label for="txtLastName" class="col-sm-3 control-label">Last Name:</label>
        <asp:TextBox ID="txtLastName" runat="server" required />
    </div>
    <div class="form-group">
        <label for="txtFirstName" class="col-sm-3 control-label">First Name:</label>
        <asp:TextBox ID="txtFirstName" runat="server" required />
    </div>
    <div class="form-group">
        <label for="txtEDate" class="col-sm-3 control-label">Enrolment Date</label>
        <asp:TextBox ID="txtEDate" runat="server" required Type="date"/>
    </div>
    <asp:Button class="btn btn-primary col-sm-offset-3" id="btnAdd" runat="server" Text="Save" OnClick="btnAdd_Click1" />
</asp:Content>
