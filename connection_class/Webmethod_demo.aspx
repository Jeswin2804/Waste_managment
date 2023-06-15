<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webmethod_demo.aspx.cs" Inherits="connection_class.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        let getStudentById = () => {
            var id = document.getElementById("Text1").value;
            connection_class.WebService1.getStudents(id, getCallbackResult);
        }
        let getCallbackResult = (results) => {
            document.getElementById("Text2").value = results["Name"];
            document.getElementById("Text3").value = results["Gender"];
            document.getElementById("Text4").value = results["TotalMarks"];
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
        <Services>
            <asp:ServiceReference path="~/Student.asmx" />
        </Services>
    </asp:ScriptManager>
    <br />
    ID: <input id="Text1" type="text" />
          <input id="Button1" type="button" value="button" onclick="getStudentById()"/>
        <br />
    Name: <input id="Text2" type="text" />
        <br />
    Gender: <input id="Text3" type="text" />
        <br />
    Total Marks :<input id="Text4" type="text" />
        <br />
    
        </form>
</body>
</html>
