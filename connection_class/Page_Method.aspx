<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page_Method.aspx.cs" Inherits="connection_class.Page_Method"  MasterPageFile="~/Site1.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server" >
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
                    console.log(list);
                    var dropdownlist = $("[id*=DropDownList1]");

                    dropdownlist.empty();
                    $.each(list, function (i, item) {
                        dropdownlist.append($('<option>', {
                            text: item.Value,
                            value: item.Text
                        }));
                    });
                },
                failure: function (res) {
                    console.log(res);
                }
            });

        });
        let getData = () => {
            var selected = document.getElementById('<%= DropDownList1.ClientID %>').value;
            console.log(selected);

            var requestData = {
                country: selected
            };

            $.ajax({
                type: "POST",
                url: "Page_Method.aspx/getCountry",
                data: JSON.stringify(requestData),
                contentType: "application/json;charset=utf-8",
                dataType: "json",
                success: function (response) {
                    var list = response.d;
                    var dropdownCities = $("[id*=DropDownList2]");
                    dropdownCities.empty();
                    $.each(list, function (i, item) {
                        dropdownCities.append($('<option>', {
                            text: item.Value,
                            value: item.Text
                        }));
                    });
                },
                error: function (res) {
                    console.log("not success");
                }
            });
        };




    </script>
    </asp:Content>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>This dropDown Bind via PageMethod</h1>
        <div>
            <asp:DropDownList ID="DropDownList1" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" onchange="getData()" AutoPostBack="false" runat="server"></asp:DropDownList>
            <asp:DropDownList ID="DropDownList2" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" runat="server"></asp:DropDownList>
        </div>


</asp:Content>
