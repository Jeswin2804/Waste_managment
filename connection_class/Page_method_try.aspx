<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page_method_try.aspx.cs" Inherits="connection_class.Page_method__try" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dropdown Population Example</title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script type="text/javascript">
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

    </script>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true"></asp:ScriptManager>
            <asp:DropDownList ID="ddlData" runat="server"></asp:DropDownList>
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        </div>
    </form>
</body>
</html>
