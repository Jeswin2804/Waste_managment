<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Web_method.aspx.cs" Inherits="connection_class.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>

 
    <script type="text/javascript">
        $(function () {
            $.ajax({
                type: "POST",
                url: "WebService2.asmx/GetCustomers",
                data: '{}',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (r) {
                    var ddlCustomers = $("[id*=ddlCustomers]");
                    ddlCustomers.empty().append('<option selected="selected" value="0">Please select</option>');
                    $.each(r.d, function () {
                        ddlCustomers.append($("<option></option>").val(this['Value']).html(this['Text']));
                    });
                },
                error: function (err,sts,hh) {
                   // console.log(err.responseText);
                    console.log(sts);
                }
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <asp:DropDownList ID="ddlCustomers" runat="server">
</asp:DropDownList>



</asp:Content>
