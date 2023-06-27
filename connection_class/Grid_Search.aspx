<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Grid_Search.aspx.cs" Inherits="connection_class.Grid_Search" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Grid Search</h1>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </div>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</asp:Content>

