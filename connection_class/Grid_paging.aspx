<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Grid_paging.aspx.cs" Inherits="connection_class.Grid_paging" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" AllowSorting="true" OnSorting="GridView1_Sorting" PageSize="4">
        </asp:GridView>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </div>
</asp:Content>


