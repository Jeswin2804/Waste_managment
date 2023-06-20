<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="~/JqueryValidation.aspx.cs" Inherits="connection_class.WebForm3" MasterPageFile="~/Site1.Master" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <title>jquery</title>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.19.3/jquery.validate.min.js"></script>
    <script>
        $(document).ready(function () {
            $.validator.addMethod('strongPassword', function (value, element) {
                return this.optional(element)
                    || (value.length >= 6 && /\d/.test(value));
            }, 'Password must be at least 6 characters long and contain at least one digit.');


            $("#myForm").validate({
                rules: {
                    name: {
                        required: true
                    },
                    email: {
                        required: true,
                        email: true
                    },
                    password: {
                        required: true,
                        strongPassword: true
                       
                    }
                },
                messages: {
                    name: {
                        required: "Please enter your name"
                    },
                    email: {
                        required: "Please enter your emal address",
                        email: "Please enter a valid email address",
                    },
                   
                },
                submitHandler: function (form) {
                    form.submit();
                }
            });
            function btn_submit() {
                var start_date = document.getElementById("#start-date").value;
                var end_date = document.getElementById("#end-date").value;
                var stDate = new Date(start_date);
                var enDate = new Date(end_date);
                var compDate = enDate - stDate;

                if (compDate > 0) {
                    return true;
                } else {
                    alert("wrong date entry");
                    return false;
                }
            }
        });

        const ajaxTest = () => {
            let xxx = {
                name: "john",
                age: 3,
                tt:null
            }
           
        }

    </script>
</asp:Content>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <form id="myForm">
         Name:
         <input type="text" id="name" name="name" />
         <br />
         Email:
         <input type="email" id="email" name="email" />
         <br />
         Password:
         <input type="Password" id="Password" name="Password" />
         <br />
         Confirm Password
         <input type="password" id="password" name="password" />

         <br />
         <input type="date" id="start-date" name="start-date" />
         <br />
         <input type="date" id="end-date" name="end-date" />
         <br />
         <input type="submit" value="Submit" OnClientClick="btn_submit()"/>
    </form>
    </asp:Content>--%>





<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.19.3/jquery.validate.min.js"></script>
    <script>
        $(document).ready(function () {
            $.validator.addMethod("stromgPassword", function (value, element) {
                return $('')
            })

            


            $("#form1").validate({
                rules: {
                    name: {
                        required: true
                    },
                    email: {
                        required: true,
                        email: true
                    },
                    password: {
                        required: true,
                        strongPassword: true
                    },
                    Password: {
                        required: true,
                    }

                },
                messages: {
                    name: {
                        required: "Please enter your name"
                    },
                    email: {
                        required: "Please enter your emal address",
                        email: "Please enter a valid email address"
                    },
                    password: {
                        required: "Please enter ",
                        strongPassword: "password is not safe"
                    }
                },
                submitHandler: function (form) {
                    form.submit();
                }
            });
        });
    </script>
</asp:Content>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <div id="">
          Name:
        <input type="text" id="name" name="name" />
        <br />
        Email:
        <input type="email" id="email" name="email" />
        <br />
        Password:
         <input type="Password" id="Password" name="Password" />
        <br />
        Confirm Password
           <input type="password" id="re_password" name="re_password" />
        <br />
        <input type="submit" value="Submit" />
    </div>

</asp:Content>