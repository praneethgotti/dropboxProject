<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDashBoard.aspx.cs" Inherits="FinalProject.AdminDashBoard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 205px;
            left: 798px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 249px;
            left: 805px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 173px;
            left: 746px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 300px;
            left: 793px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 200px;
            left: 23px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <h1>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Files" style="z-index: 1; left: 596px; top: 255px; position: absolute" />
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 203px; top: 153px; position: absolute; bottom: 287px" Text="Search By User's Username"></asp:Label></h1>
        <asp:Label ID="lblusername" runat="server" style="z-index: 1; left: 250px; top: 267px; position: absolute" Text="Username"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 379px; top: 263px; position: absolute"></asp:TextBox>
        <asp:GridView ID="gvUsers" runat="server" style="z-index: 1; left: 297px; top: 367px; position: absolute; height: 180px; width: 289px">
        </asp:GridView>
        <asp:Label ID="Label2" runat="server" Text="Label" style="z-index: 1; left: 12px; top: 58px; position: absolute"></asp:Label>
        <asp:Label ID="Label3" runat="server" Text="Label" style="z-index: 1; left: 11px; top: 101px; position: absolute"></asp:Label>
        <br />
        <asp:TextBox ID="txtRemoveUser" runat="server" CssClass="auto-style1"></asp:TextBox>
        <asp:Button ID="btnDeleteUser" runat="server" CssClass="auto-style2" OnClick="Button2_Click" Text="Delete User" />
        <asp:Label ID="Label4" runat="server" CssClass="auto-style3" Text="Enter the ID of user to delete"></asp:Label>
        <asp:Label ID="Label5" runat="server" CssClass="auto-style4" Text="Label"></asp:Label>
        <asp:Button ID="Button2" runat="server" CssClass="auto-style5" OnClick="Button2_Click1" Text="Edit User Info" />
    </form>
</body>
</html>
