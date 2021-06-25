<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="FirstWebApp.edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="tbProductName" runat="server"></asp:TextBox>
            <asp:Button ID="btEdit" Text="Edit" runat="server" OnClick="btEdit_Click" />
        </div>
    </form>
</body>
</html>
