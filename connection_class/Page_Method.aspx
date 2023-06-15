<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page_Method.aspx.cs" Inherits="connection_class.Page_Method" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script>
        $(function () {
            $.ajax({
                type: "POST",
                url: "Page_Method.aspx/getCountries",
                data: '{}',
                contentType: "application/json;charset=utf-8",
                dataType: "json",
                success: function (res) {
                    var list = res.d;
                    console.log(list)
                    var dropdownlist = $("[id*=DropDownList1]");
                    dropdownlist.empty();
                    $.each(list, function (i, item) {
                        dropdownlist.append($('<option>', {
                            text: item.Value,
                           Value: item.Text
                        }));
                    });
                  },
                failure: function (res) {
                    console.log(res)
                }
             })
        })
        let change = (country) => {
            $.ajax({
                type: "POST",
                url: "Page_Method.aspx/getCountry",
                data: JSON.stringify({ country: country }),
                
            })
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"  AutoPostBack="false" runat="server"></asp:DropDownList>
            <asp:DropDownList ID="DropDownList2" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" runat="server"></asp:DropDownList>

        </div>
    </form>
</body>
</html>
