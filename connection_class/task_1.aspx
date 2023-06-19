7<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="task_1.aspx.cs" Inherits="connection_class.task_1" %>

<!DOCTYPE html><html xmlns="http://www.w3.org/1999/xhtml"><head runat="server"><title></title></head><body><form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1"  OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" runat="server" AutoPostBack="true"></asp:DropDownList>
            <asp:DropDownList ID="DropDownList2"  OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" runat="server" AutoPostBack="true"></asp:DropDownList>
            <asp:DropDownList ID="DropDownList3" runat="server"></asp:DropDownList>
      
        </div>
    </form>
</body>
</html>
