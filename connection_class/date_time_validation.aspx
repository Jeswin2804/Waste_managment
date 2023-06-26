<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="date_time_validation.aspx.cs" Inherits="connection_class.WebForm7" MaintainScrollPositionOnPostBack="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script>

           
        function togglePasswordMode() {
            var textBox = document.getElementsByClassName("passwordTextBox")[0];
            if (textBox.type === "password") {
                textBox.type = "text";
            } else {
                textBox.type = "password";
            }
        }
    
        let validate = () => {
            var endDate = document.getElementById('<%=TextBox2.ClientID%>').value;
            var startDate = document.getElementById('<%=TextBox1.ClientID%>').value;
            var stDate = new Date(startDate);
            var enDate = new Date(endDate);
            var compDate = enDate - stDate;
            console.log(compDate);
            if (compDate >= 0) {
                return true;
            } else {
                alert("INVAILD DATE");
                return false;
            }

            }
        function showPass() {
            var checkBox = document.getElementById("myCheck");
            var text = document.getElementById("text");
            if (checkBox.checked == true) {
                text.style.display = "block";
            } else {
                text.style.display = "none";
            }
        }
        let showPassword = () => {
            var passwordTextBox = document.getElementById('<%= txtPassword.ClientID %>');
            passwordTextBox.type = 'text';
        }
        let hidePassword = () => {
            var passwordTextBox = document.getElementById('<%= txtPassword.ClientID %>');
            passwordTextBox.type = 'password';
        }

        /*

         $(document).ready(function () {
           
            PageMethods.GetDropdownData(onSuccess, onFailure);
        });

      
        function onSuccess(data) {
            var dropdown = $("#ddlData");
            dropdown.empty();
            dropdown.append($('<option>').text('Select').val(''));

            for (var i = 0; i < data.length; i++) {
                dropdown.append($('<option>').text(data[i].Text).val(data[i].Value));
            }
        }

     
        function onFailure(error) {
            console.log(error);
        }

        */

    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Date validation</h1>
    Start date
    <asp:TextBox ID="TextBox1" runat="server" TextMode="Date"></asp:TextBox>
    End date
    <asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
    <asp:Button ID="Button1" OnClientClick=" validate()" runat="server" Text="Button" />
   
    <h1>show password</h1>
     <h2> using css </h2>
    <input type="checkbox" id="myCheck" onclick="showPass()">
    <p id="text" style="display:none">password</p>
    <h2>toggle image button</h2>
   <asp:TextBox ID="txtPassword" TextMode="Password" CssClass="passwordTextBox" runat="server"></asp:TextBox>
<asp:ImageButton ID="ImageButton1" runat="server" Height="15px" ImageUrl="~/pngwing.com.png" OnClientClick="togglePasswordMode(); return false;" Width="20px" />

</asp:Content>
