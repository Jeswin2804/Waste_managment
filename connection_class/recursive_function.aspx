<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="recursive_function.aspx.cs" Inherits="connection_class.recursive_function" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .person-link {
            cursor: pointer;
        }
    </style>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
  <%--  <script>
        $(document).ready(function () {
            $(".person-link").on("click", function () {
                var childName = $(this).text();
                $.ajax({
                    type: "POST",
                    url: "recursive_function.aspx/GetAncestors",
                    data: JSON.stringify({ childName: childName }),
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (response) {
                        $(this).next("ul").remove();
                        $(this).parent("li").append(response.d);
                    },
                    error: function (xhr, status, error) {
                        console.log(error);
                    }
                });
            });
        });
    </script>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div>
        <asp:TreeView ID="treeView" runat="server" CssClass="my-treeview">
        </asp:TreeView>
    </div>
</asp:Content>
