<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="html_table_data.aspx.cs" Inherits="connection_class.WebForm1" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        td:hover {
            background-color: coral;
        }

        th:hover {
            background-color: darkgrey;
        }
    </style>
    <div>
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    </div>
</asp:Content>
