<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Drill_Down.aspx.cs" Inherits="connection_class.Drill_Down" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        function cellClicked(cell) {
            $.ajax({
                url: "",
                data: "",
                type: "",
                contentType: "",
                success: function () {

                },
                error: function () {

                }
            })
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>



</asp:Content>
