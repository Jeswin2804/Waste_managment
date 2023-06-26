<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Video_Auto_play.aspx.cs" Inherits="connection_class.Video_Auto_play" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .video-over {
            position: relative;
            width: 560px;
            height: 315px;
        }

            .video-over video {
                width: 100%;
                height: 100%;
            }

        .upload {
            margin: 20px
        }
    </style>
    <script>
        window.onload = function () {
            var video = document.getElementById("<%=myVideo.ClientID%>");
            var videoContainer = document.getElementById("<%=videoContainer.ClientID%>");

            videoContainer.onmouseover = function () {
                video.play();
            };

            videoContainer.onmouseout = function () {
                video.pause();
            };
            var uploadButton = document.getElementById('uploadButton');
            uploadButton.addEventListener('click', function () {
                var fileInput = document.getElementById('File1');
                var file = fileInput.files[0];
                if (file) {
                    var formData = new FormData();
                    formData.append('file', file);
                    fetch('/upload', {
                        method: 'POST',
                        body: formData
                    })
                        .then(res => {
                            var upload_succes  =document.getElementById("upload_succes");
                            upload_succes.textContent ="Succesfully Uploaded"
                            console.log("succes")
                        })
                        .catch(res => {
                            var upload_succes = document.getElementById("upload_succes");
                            upload_succes.textContent = "Error"
                            console.log("error");
                        })
                }
            })
        };
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>When Mouse Hover the Video the video will auto play </h1>
   
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <div id="videoContainer" class="video-over" runat="server">
        <video id="myVideo" runat="server" />

    
        <div class="video-overlay"></div>
    </div>
    <h1>c# file upload</h1>
    <div class="upload">
        <asp:FileUpload ID="FileUpload1" runat="server" enctype="multipart/form-data" />
        <asp:Button ID="Button1" runat="server" Text="upload" OnClick="Button1_Click" />
    </div>
    <h1>Js File Upload</h1>
    <input id="File1" type="file" />
    <input id="uploadButton" type="button" value="Submit" />
   <h1><label id="upload_succes"></label></h1> 
</asp:Content>
