<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="FinalProject.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 184px; top: 156px; position: absolute" Text="Username"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 184px; top: 203px; position: absolute" Text="Password"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 305px; top: 158px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 305px; top: 201px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 395px; top: 268px; position: absolute" Text="Login" OnClick="btnLogin_Click" />
    </form>
</body>
</html>
