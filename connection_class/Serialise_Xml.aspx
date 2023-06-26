<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Serialise_Xml.aspx.cs" Inherits="connection_class.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Button1" runat="server" Text="Serialise" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="Deserialize" OnClick="Button2_Click" />
    <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
</asp:Content>
