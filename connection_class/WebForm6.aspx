<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="connection_class.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script>
         let getStudentById = () => {
             var id = document.getElementById("Text1").value;
             connection_class.WebService1.getStudents(id, getCallbackResult,getCallbackError);
         }
         let getCallbackResult = (results) => {
             if (Object.keys(results).length===0) {
                 alert("hey i m here");
             } else {
                 document.getElementById("Text2").value = results["Name"];
                 document.getElementById("Text3").value = results["Gender"];
                 document.getElementById("Text4").value = results["TotalMarks"];
             }
         }
         let getCallbackError = (err) => {
             alert(err);
         }
     </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
</asp:Content>
