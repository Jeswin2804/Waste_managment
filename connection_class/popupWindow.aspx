<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="popupWindow.aspx.cs" Inherits="connection_class.popupWindow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js"></script>
    <script src="https://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.9/jquery-ui.js" type="text/javascript"></script>
    <link href="https://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.9/themes/start/jquery-ui.css"
        rel="stylesheet" type="text/css" />
    <script>
        $(document).ready(function () {
            $("[id*=openModel]").live("click", function () {
                $("#dialog").dialog({
                    title: "hey ",
                    buttons: {
                        close: function () {
                            $(this).dialog('close');
                        }
                    },
                    modal: true
                });
            });
        });
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>MODAL USING JQUERY</h1>
    <div id="dialog" style="display: none">
    hey i m here
    </div>
   <input type="button" id="openModel" value="show"/>
 </asp:Content>
