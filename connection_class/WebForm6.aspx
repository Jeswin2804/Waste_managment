<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="connection_class.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script>
         let getStudentById = () => {
             var id = document.getElementById("Text1").value;
             connection_class.WebService1.getStudents(id, getCallbackResult,getCallbackError);
         }
         let getCallbackResult = (results) => {
             if (Object.keys(results).length===0) {
                 alert("No Data");
             } else {
                 var lab1 = document.getElementById("Text2");
                 lab1.textContent = results["Name"];

             }
         }
         let getCallbackError = (err) => {
             alert(err);
         }
//student.asmx
     </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:ScriptManager ID="ScriptManager1" runat="server">
        <Services>
            <asp:ServiceReference path="~/Student.asmx" />
        </Services>
    </asp:ScriptManager>
    <br />
    <h1>Enter a the ID </h1>
    ID: <input id="Text1" type="text" />
          <input id="Button1" type="button" value="button" onclick="getStudentById()"/>
        <br />
    Name: <label id="Text2" />
        <br />

        <br />
</asp:Content>

