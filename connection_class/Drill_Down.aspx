<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Drill_Down.aspx.cs" Inherits="connection_class.Drill_Down" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        /* Apply styles to the table */
        table {
            border-collapse: collapse;
            width: 100%;
            font-family: Arial, sans-serif;
        }

        /* Style the table header */
        th {
            background-color: #f2f2f2;
            text-align: left;
            padding: 8px;
        }

        /* Style the table cells */
        td {
            padding: 8px;
        }

        /* Apply alternating row colors */
        tr:nth-child(even) {
            background-color: #f9f9f9;
        }

        /* Add hover effect to table rows */
        tr:hover {
            background-color: #e5e5e5;
        }
    </style>

    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script>
        var clickedRow = [];
        function cellClicked(cell) {
            var input = $(cell).text();
            console.log(input);
            //get index
            var rowIndex = $(cell).closest('tr').index();
            console.log("clicked index " + rowIndex);
            //if (clickedRow.includes(rowIndex)) {//check clicked or not 
            //    console.log("already clicked");
            //   /* $("#myTable tr#sub").remove();*/
            //    return;
            //}
            $.ajax({
                url: "Drill_Down.aspx/addvalues",
                data: JSON.stringify({ input: input }),
                type: "POST",
                contentType: "application/json; charset=utf-8",
                success: function (res) {
                    for (var i = 0; i < res.d.length; i++) {
                        var newRow = res.d[i];
                        console.log(newRow);
                        var $newRow = $("<tr id='sub' ><td onclick='subCellClicked(this)' colspan='3'>" + newRow + "</td></tr>");
                        $('#myTable tr').eq(rowIndex).after($newRow);
                    }

                },
                error: function (err) {
                    console.log(err);
                }
            });
        }

        function subCellClicked(data) {
            var rowIndex = data.parentNode.rowIndex;
            data = $(data).text();
            console.log(data);
          
         
            $.ajax({
                url: "Drill_Down.aspx/addsubvalues",
                data: JSON.stringify({ data: data }),
                type: "POST",

                contentType: "application/json; charset=utf-8",

                success: function (res) {

                    var $mewTable = $(" <table ><tr><td> cc:" + res.d[0] + "</td><td>power:" + res.d[1] + "</td>  <td>Mielage:" + res.d[2] + "</td></tr></table>")
                    $('#myTable tr').eq(rowIndex).after($mewTable)

                  //  $('#myTable tr').eq(rowIndex).after($newRow);

                    //for (var i = 0; i < res.d.length; i++) {

                    //    var newRow = res.d[i];
                       
                    //    var $newRow = $("<tr><td>" + newRow + "</td></tr>")

                    //    $('#myTable tr').eq(rowIndex).after($newRow);

                    //}

                },
                error: function (err) {

                    console.log(err);

                },
            })
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
</asp:Content>


<%--  var $newRow = $("<tr><td colspan='3'>" + data + "</td></tr>");
            var $newRowHed = $("<tr><td>cc</td><td>power</td><td>mileage</td></tr>");--%>