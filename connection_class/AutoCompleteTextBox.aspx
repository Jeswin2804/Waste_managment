﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AutoCompleteTextBox.aspx.cs" Inherits="connection_class.AutoCompleteTextBox" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="https://ajax.aspnetcdn.com/ajax/jquery/jquery-1.8.0.js"></script>
    <script src="https://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.22/jquery-ui.js"></script>
    <link rel="stylesheet" href="https://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.10/themes/redmond/jquery-ui.css" />

    <script>
        $(document).ready(function () {
            $("#tags").autocomplete({
                source: function (req, res) {
                    var parameter = { Name: $('#tags').val() };
                    $.ajax({
                        url: "AutoCompleteTextBox.aspx/getNames",
                        data: JSON.stringify(parameter),
                        dataType: "json",
                        type: "POST",
                        contentType: "application/json; charset=utf-8",
                        dataFilter: function (data) { return data; },
                        success: function (data) {
                            res($.map(data.d, function (item) {
                                return {
                                    value: item
                                };
                            }));
                        },
                        error: function (XMLHttpRequest, textStatus, errorThrown) {
                            var err = eval("(" + XMLHttpRequest.responseText + ")");
                            alert(err.Message);
                        }
                    });
                },
                minLength: 3
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="ui-widget">
       <h1>Auto suggestion</h1>
  <label for="tags">Tags: </label>
  <input id="tags">
</div>
</asp:Content>
