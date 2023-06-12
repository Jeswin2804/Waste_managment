
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
    if (summary != "") {
        alert(summary);
    return false;  
                } else {  
                    return true;  
                }  
            }

    function isvaliduser() {  
                var id;
    var temp = document.getElementById("<%=txtuser.ClientID %>");
    id = temp.value;
    if (id == "") {  
                    return ("Please Enter User Name" + "\n");  
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
                    return ("Email should be in the form ex:abc@xyz.com" + "\n");  
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
                    return ("Please enter Location" + "\n");  
                } else {  
                    return "";  
                }  
            }
