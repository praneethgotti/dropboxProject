<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDashBoard.aspx.cs" Inherits="FinalProject.AdminDashBoard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 236px;
            left: 886px;
            z-index: 1;
            right: 384px;
        }
        .auto-style2 {
            position: absolute;
            top: 233px;
            left: 1106px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 236px;
            left: 647px;
            z-index: 1;
            right: 588px;
        }
        .auto-style4 {
            position: absolute;
            top: 173px;
            left: 655px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 222px;
            left: 36px;
            z-index: 1;
        }
        .auto-style6 {
            z-index: 1;
            left: 119px;
            top: 299px;
            position: absolute;
        }
        .auto-style7 {
            z-index: 1;
            left: 365px;
            top: 292px;
            position: absolute;
        }
        .auto-style8 {
            position: absolute;
            top: 307px;
            left: 826px;
            z-index: 1;
        }
    </style>
</head>
<body style="background-color:powderblue;">
    <form id="form1" runat="server">
        <div>
        </div>
        <h1>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Files" CssClass="auto-style7" />
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 17px; top: 155px; position: absolute; bottom: 402px" Text="Search By User's Username"></asp:Label></h1>
        <asp:Label ID="lblusername" runat="server" style="z-index: 1; left: 36px; top: 297px; position: absolute" Text="Username"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" CssClass="auto-style6"></asp:TextBox>
        <asp:GridView ID="gvUsers" runat="server" style="z-index: 1; left: 824px; top: 344px; position: absolute; height: 180px; width: 289px" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />

        </asp:GridView>
        
        
        <asp:Label ID="Label2" runat="server" Text="Label" style="z-index: 1; left: 12px; top: 58px; position: absolute"></asp:Label>
        <asp:Label ID="Label3" runat="server" Text="Label" style="z-index: 1; left: 11px; top: 101px; position: absolute"></asp:Label>
        <br />
        <asp:TextBox ID="txtRemoveUser" runat="server" CssClass="auto-style1"></asp:TextBox>
        <asp:Button ID="btnDeleteUser" runat="server" CssClass="auto-style2" OnClick="Button2_Click" Text="Delete User" />
        <asp:Label ID="Label4" runat="server" CssClass="auto-style3" Text="Enter  User ID to delete"></asp:Label>
        <asp:Label ID="Label5" runat="server" CssClass="auto-style4" Text="Label"></asp:Label>
        <asp:Button ID="Button2" runat="server" CssClass="auto-style5" OnClick="Button2_Click1" Text="Edit User Info" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Transactions" runat="server" CssClass="auto-style8" Text="Transactions"></asp:Label>
        <asp:GridView ID="GridView1" AutoGenerateColumns="false" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" runat="server">
            <Columns>
                <asp:TemplateField HeaderText="LoginID">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("LoginID") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("LoginID") %>'></asp:Label>
                    </EditItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Username">
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("Username") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txt1" runat="server" Text='<%# Eval("Username") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Password">
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("Password") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txt2" runat="server" Text='<%# Eval("Password") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Email">
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("Email") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txt3" runat="server" Text='<%# Eval("Email") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Pno">
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("PhoneNumber") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txt4" runat="server" Text='<%# Eval("PhoneNumber") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderStyle-Width="150px">
                    
            <ItemTemplate>
                <asp:LinkButton ID="LkB1" runat="server" CommandName="Edit">Edit</asp:LinkButton>
                <asp:LinkButton ID="LkB4" runat="server" CommandName="Delete">Delete</asp:LinkButton>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:LinkButton ID="LkB2" runat="server" CommandName="Update">Update</asp:LinkButton>
                <asp:LinkButton ID="LkB3" runat="server" CommandName="Cancel">Cancel</asp:LinkButton>
            </EditItemTemplate>
        </asp:TemplateField>

            </Columns>
        </asp:GridView>
        <br />
    </form>
</body>
</html>
