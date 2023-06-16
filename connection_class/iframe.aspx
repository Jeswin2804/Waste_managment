<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="iframe.aspx.cs" Inherits="connection_class.iframe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <iframe width="560" height="315" src="https://www.youtube.com/embed/EzwBuqILfds"    allowfullscreen></iframe><br />
    <iframe src="https://www.google.com/maps/embed?pb=!1m14!1m12!1m3!1d31433.19785080835!2d76.35827694422606!3d10.004488195138746!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!5e0!3m2!1sen!2sin!4v1686908570254!5m2!1sen!2sin" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
    <iframe id="ifrm" runat="server" width="560" height="315" visible="false"></iframe>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
</asp:Content>
