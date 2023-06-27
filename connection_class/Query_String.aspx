<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Query_String.aspx.cs" Inherits="connection_class.Query_String" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        function loadPageInIframe(url) {
            var iframe = document.getElementById("myIframe");
            iframe.src = url;
        }

        function buttonClick() {
            var first = document.getElementById("<%= TextBox1.ClientID %>").value;
            var last = document.getElementById("<%= TextBox2.ClientID %>").value;
            var url = "welcome_page.aspx?first=" + encodeURIComponent(first) + "&last=" + encodeURIComponent(last);
            loadPageInIframe(url);
            return false; // Prevent postback
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1></h1>
    Name:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
    Last Name:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
    <h1>This Button will Show Content in the iFrame</h1>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClientClick="return buttonClick();" />
    <iframe id="myIframe" src="" width="100%" height="500px"></iframe>
</asp:Content>
