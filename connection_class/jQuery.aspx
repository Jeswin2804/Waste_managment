<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="jQuery.aspx.cs" Inherits="connection_class.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="code.jquery.com_jquery-3.7.0.js"></script>
    <script src="jquery.validate.js"></script>
    <script type="text/javascript">


        function Button1_Click() { 
            $("#registerform").validate({
                rules: {
                    name: {
                        required: true,
                        minlength: 2
                    }
                },
                messages: {
                    name: {
                        required: "We need your email address to contact you",
                        minlength: jQuery.validator.format("At least {0} characters required!")
                    }
                }
            });
        }
    </script>



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="myForm" >
        <label for="name">Name:</label>
        <input type="text" id="name" name="name" />
        <br />
        <label for="email">Email:</label>
        <input type="email" id="email" name="email"  />
        <br />
        <input type="submit" value="Submit" />
    </form>

</asp:Content>

