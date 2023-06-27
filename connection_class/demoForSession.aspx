<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="demoForSession.aspx.cs" Inherits="connection_class.demoForSession" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>This data is obtained through a session.</h1>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
            <asp:Button ID="Button1" runat="server" Text="BACK" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
