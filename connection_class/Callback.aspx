<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Callback.aspx.cs" Inherits="connection_class.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        function getValue() {
            useCallback();
        }
        function getNumberServer(Textbox1, context) {
            document.forms[0].Textbox1.value = Textbox1;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <input id="button1" type="button" value="random" onclick="getValue()" />
    <input id="Textbox1" type="text" />
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
</asp:Content>
