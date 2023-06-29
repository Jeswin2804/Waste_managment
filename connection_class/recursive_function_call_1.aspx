<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="recursive_function_call_1.aspx.cs" Inherits="connection_class.recursive_function_call_1" %>

<asp:Content ID="content1" ContentPlaceHolderID="head" runat="server">
    <script>
        function factorial(num) {
            if (num === 0) {
                return 1;
            } else {
                return num * factorial(num - 1);
            }
        }

        function calculateFactorial() {
            var input = parseInt(document.getElementById('input').value);
            var result = factorial(input);
            document.getElementById('resultLabel').innerHTML = 'Factorial of ' + input + ' is: ' + result;
            return false; // Prevent page refresh
        }
    </script>
</asp:Content>

<asp:Content ID="content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>C#</h1>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <br />
        <h1>This result is created using recursion: 
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </h1>
        <h1>Factorial Calculation</h1>
        <input type="text" id="input" />
        <button onclick="return calculateFactorial();">Calculate</button>
        <br />
        <h2 id="resultLabel"></h2>
    </div>
</asp:Content>
