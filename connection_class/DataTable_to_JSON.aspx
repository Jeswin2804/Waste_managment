<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DataTable_to_JSON.aspx.cs" Inherits="connection_class.DataTable_to_JSON" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>

    <script>
  
        $(document).ready(function () {
            function getMethod(meth, out,id) {

                $.ajax({
                    type: "POST",
                    url: "DataTable_to_JSON.aspx/" + meth,
                    dataType: "json",
                    contentType: "application/json;charset=utf-8",
                    success: function (res, req) {
                        $("#" + out).text(res.d);
                        console.log(eval(res.d));
                        console.log(id)
                        

                    },
                    error: function (res) {
                        console.log(res.d);
                    }
                });
            }
            getMethod("call", "outputText",1);
            getMethod("javaScriptSerializer", "outputText1",2);
            getMethod("DataTableToJsonWithJsonNet", "outputText2", 3);
            getMethod("datafromJson", "outputText4", 4);
            var cookieValue = document.cookie
                .split('; ')
                .find(row => row.startsWith('cookieName='))
                .split('=')[1];

            $("#outputText3").text(cookieValue);
        });



    </script>
    <style>
        .output1 {
            width: 100%;
            max-width: 1230px;
            border: 1px solid #ccc;
            padding: 10px;
            box-sizing: border-box;
            font-size: 16px;
            line-height: 1.5;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Method 1: Using C# StringBuilder</h1>
    <div id="outputText" class="output1">
    </div>
    <h1>Method 2: Using JavaScriptSerializer</h1>
    <div id="outputText1" class="output1">
    </div>
    <h1>Method 3: Using nuget Json.Net DLL (Newtonsoft).</h1> 
    <div id="outputText2" class="output1">
    </div>
    <h1>This is from another page by using Cookie </h1>
    <div id="outputText3" class="output1">
    </div>
    <h1>This Data From SQL In JSON Format</h1>
     <div id="outputText4" class="output1">
    </div>
    <br />
    <asp:Button ID="Button1" runat="server" Text="SESSION" OnClick="Button1_Click" />
</asp:Content>
