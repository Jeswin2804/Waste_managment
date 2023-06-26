<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="use_control.aspx.cs" Inherits="connection_class.WebForm13" %>
<%@ Register src="UserControl1.ascx" tagname="UserControl1" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UserControl1 ID="UserControl11" runat="server" />
    <asp:Button ID="Button1" runat="server" Text="Button" />
</asp:Content>
