<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="cascading _dropDown.aspx.cs" Inherits="connection_class.cascading__dropDown" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DropDownList ID="DropDownList1" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" runat="server" AutoPostBack="True"></asp:DropDownList>

    <asp:DropDownList ID="DropDownList2" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" runat="server" AutoPostBack="True"></asp:DropDownList>

    <asp:DropDownList ID="DropDownList3" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged" runat="server" AutoPostBack="true"></asp:DropDownList>

    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

</asp:Content>
