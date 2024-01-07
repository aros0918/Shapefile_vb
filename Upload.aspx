<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Upload.aspx.vb" Inherits="shapefileimport.Upload" %>

<!DOCTYPE html>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "https://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Upload Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:FileUpload ID="Uploader" runat="server" Width="512px" Multiple="Ture" />

            <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" />

            <br />

            <br />

            <asp:Label ID="lblInfo" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>
