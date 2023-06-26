<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="XML_doc_save.aspx.cs" Inherits="connection_class.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style2 {
        width: 134%;
        height: 208px;
    }
    .auto-style4 {
        width: 138px;
        text-align: center;
    }
    .auto-style5 {
        text-align: center;
    }
    .auto-style6 {
        text-align: center;
        width: 49px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="auto-style2">
    <tr>
        <td class="auto-style4">Name</td>
        <td class="auto-style6">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">EmailId</td>
        <td class="auto-style6">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">City</td>
        <td class="auto-style6">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style5" colspan="2">
            <asp:Button ID="Button1" runat="server" Text="Serialize" OnClick="Button1_Click" />

        </td>
    </tr>
</table>
 <asp:GridView ID="GridView1" runat="server" ></asp:GridView>
    <h4>This Data get by XPATH</h4>
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
 

</asp:Content>
