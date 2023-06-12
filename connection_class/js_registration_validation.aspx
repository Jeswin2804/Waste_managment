<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="js_registration_validation.aspx.cs" Inherits="connection_class.js_registration_validation" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 40px;
        }
    </style>
    <script>

        function validationCheck() {
            var summary = "";
            summary += isvaliduser();
            summary += isvalidpassword();
            summary += isvalidConfirmpassword();
            summary += isvalidFirstname();
            summary += isvalidLastname();
            summary += isvalidEmail();
            summary += isvalidphoneno();
            summary += isvalidLocation();
            isvalidDateofbirth();
            if (summary != "") {
                alert(summary);
                return false;
            } else {
                return true;
            }
        }

        function isvaliduser() {
            var id;
            var temp = document.getElementById("<%=txtfname.ClientID %>");
            id = temp.value;
            if (id == "") {
                return ("please eneter name" + "/n");

            } else {
                return "";
            }

        }

        function isvalidpassword() {
            var id;
            var temp = document.getElementById("<%=txtpwd.ClientID %>");
            id = temp.value;
            if (id == "") {
                return ("Please enter password" + "\n");
            } else {
                return "";
            }
        }

        function isvalidConfirmpassword() {
            var uidpwd;
            var uidcnmpwd;
            var tempcnmpwd = document.getElementById("<%=txtcnmpwd.ClientID %>");
            uidcnmpwd = tempcnmpwd.value;
            var temppwd = document.getElementById("<%=txtpwd.ClientID %>");
            uidpwd = temppwd.value;
            if (uidcnmpwd == "" || uidcnmpwd != uidpwd) {
                return ("Please re-enter password to confrim" + "\n");
            } else {
                return "";
            }
        }

        function isvalidFirstname() {
            var id;
            var temp = document.getElementById("<%=txtfname.ClientID %>");
            id = temp.value;
            if (id == "") {
                return ("Please enter first name" + "\n");
            } else {
                return "";
            }
        }

        function isvalidLastname() {
            var id;
            var temp = document.getElementById("<%=txtlname.ClientID %>");
            id = temp.value;
            if (id == "") {
                return ("Please enter last name" + "\n");
            } else {
                return "";
            }
        }

        function isvalidEmail() {
            var id;
            var temp = document.getElementById("<%=txtEmail.ClientID %>");
            id = temp.value;
            var re = /\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*/;
            if (id == "") {
                return ("Please Enter Email" + "\n");
            } else if (re.test(id)) {
                return "";
            } else {
                return ("Email should be in the form ex:abc@xyz.com" + "\n"); 7
            }
        }

        function isvalidphoneno() {
            var id;
            var temp = document.getElementById("<%=txtphone.ClientID %>");
            id = temp.value;
            var re;
            re = /^[0-9]+$/;
            var digits = /\d(10)/;
            if (id == "") {
                return ("Please enter phone no" + "\n");
            } else if (re.test(id)) {
                return "";
            } else {
                return ("Phone no should be digits only" + "\n");
            }
        }

        function isvalidLocation() {
            var id;
            var temp = document.getElementById("<%=txtlocation.ClientID %>");
            id = temp.value;
            if (id == "") {
                return ("Please enter location" + "\n");
            } else {
                return "";
            }
        }

        function isvalidDateofbirth() {
            var today = new Date();
            var input = document.getElementById("<%=txtdateofbirth.ClientID%>").value;
            var _input = new Date(input);
            today.setFullYear(today.getFullYear - 18);
            if (today <= _input) {
                return true;
            }
        }

    </script>
    <div>
        <h1>Registration Form</h1>
        <table>
            <tr>
                <td>Username</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtuser" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Password</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtpwd" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>confirm password</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtcnmpwd" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>First name</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtfname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>last name</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtlname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Emial Address</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Phone number</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtphone" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Location</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtlocation" runat="server" Height="22px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Date OF Birth</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtdateofbirth" runat="server" Height="22px" TextMode="Date" Width="272px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td class="auto-style1">
                    <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" OnClientClick="return validationCheck();" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>



