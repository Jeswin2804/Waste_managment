<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="update_panel.aspx.cs" Inherits="connection_class.update_panel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
        .auto-style4 {
        width: 330px;
    }
    .auto-style5 {
        width: 330px;
        text-align: left;
    }
    </style>
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:ScriptManager runat="server"></asp:ScriptManager>
    <div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
         
                <table class="auto-style2">
                    <tr>
                        <td>Name</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                        </td>
                        <td class="auto-style5">
                            <asp:Image ID="Image1" runat="server" Visible="False" Height="20px" Width="20px" />
                            <asp:Label ID="Label1" runat="server" Text="Label" Visible="false"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Password</td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style4">&nbsp;</td>
                      
                    </tr>
                    <tr>
                        <td>Confirm Password</td>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style4">&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td class="auto-style4">&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Button ID="Button1" runat="server" Text="Button" Width="125px" OnClick="Button1_Click" />
                        </td>
                        <td class="auto-style4">&nbsp;</td>
                    </tr>
                </table>
         
             </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>
