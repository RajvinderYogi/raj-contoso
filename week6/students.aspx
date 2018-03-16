<%@ Page Title="Students" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="students.aspx.cs" Inherits="week6.students" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <h1>Students</h1>
    <a href="studentDetails.aspx">Add new Student</a>
    <asp:GridView ID="grdStudents" runat="server" CssClass="table table-striped table-hover" 
        AutoGenerateColumns="false" DataKeyNames="StudentID" OnRowDeleting="grdStudents_RowDeleting">
        <Columns>
            <asp:BoundField DataField="StudentID" HeaderText="ID"/>
            <asp:BoundField DataField="LastName" HeaderText="Last Name"/>
            <asp:BoundField DataField="FirstMidName" HeaderText="First Name"/>
            <asp:BoundField DataField="EnrollmentDate" HeaderText="Enrollment Date" DataFormatString="{0:D}" />
            <asp:HyperLinkField HeaderText="Edit" Text="Edit" NavigateUrl="~/studentDetails.aspx" 
                DataNavigateUrlFields="StudentID" DataNavigateUrlFormatString="~/studentDetails.aspx?studentID={0}" />
            <asp:CommandField HeaderText="Delete" ShowDeleteButton="true" ControlStyle-CssClass="confirmation"/>
        </Columns>

    </asp:GridView>
</asp:Content>
