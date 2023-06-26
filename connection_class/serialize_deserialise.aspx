<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="serialize_deserialise.aspx.cs" Inherits="connection_class.serialize_deserialise" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script>
        $(document).ready(function () {
            let  jsondata;  
            $.ajax({
                type:"POST",
                url: "serialize_deserialise.aspx/getData",
                dataType: "json",
                contentType: "application/json;charset=UTF-8",
                success: function (res) {
                    jsondata = res.d;
                    $("#data").text(res.d);
                    $.ajax({
                        type: "POST",
                        url: "serialize_deserialise.aspx/getData1",
                        data: JSON.stringify({ args: jsondata }),
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        success: function (response) {
                            console.log(response.d);
                            document.cookie = "cookieName=" + response.d;
                           // window.location.href = "DataTable_to_JSON.aspx";
                        },
                        error: function (error) {
                            console.log(error.responseText);
                        }
                    });
                },
                error: function (res) {
                    console.log(res);
                }
            });
           
        });


    </script>
    <style>
        #output{
        
                 width: 100%;
            max-width: 1200px;
            border: 1px solid #ccc;
            padding: 10px;
            box-sizing: border-box;
            font-size: 16px;
            line-height: 1.5;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="output">
        <div id="data">
        </div>
        <h4> <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></h4>

</div>
</asp:Content>
