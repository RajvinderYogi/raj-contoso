<%@ Page Title="Departments" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="departments.aspx.cs" Inherits="week6.departments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Departments</h1>
    <a href="departmentDetails.aspx">Add a Department</a>
    <asp:GridView ID="grdDepartments" runat="server" CssClass="table table-striped table-hover" 
        AutoGenerateColumns="false" DataKeyNames="DepartmentID" OnRowDeleting="grdDepartments_RowDeleting">
        <Columns>
            <asp:BoundField DataField="DepartmentID" HeaderText="ID"/>
            <asp:BoundField DataField="Name" HeaderText="Department Name"/>
            <asp:BoundField DataField="Budget" HeaderText="Budget" DataFormatString="{0:c}" />
            <asp:HyperLinkField HeaderText="Edit" Text="Edit" NavigateUrl="~/departmentDetails.aspx" 
                DataNavigateUrlFields="DepartmentID" DataNavigateUrlFormatString="~/departmentDetails.aspx?DepartmentID={0}" />
            <asp:CommandField HeaderText="Delete" ShowDeleteButton="true" ControlStyle-CssClass="confirmation"/>
        </Columns>
    </asp:GridView>
</asp:Content>
