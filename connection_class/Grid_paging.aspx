<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Grid_paging.aspx.cs" Inherits="connection_class.Grid_paging" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" AllowSorting="true" OnSorting="GridView1_Sorting" PageSize="4">
            </asp:GridView>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
