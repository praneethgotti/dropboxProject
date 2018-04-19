<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DashBoard.aspx.cs" Inherits="FinalProject.DashBoard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            z-index: 1;
            left: 39px;
            top: 129px;
            position: absolute;
            height: 207px;
            width: 926px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        </div>
        <asp:Button ID="BtnUpload" runat="server" style="z-index: 1; left: 467px; top: -52px; position: absolute" Text="Upload" OnClick="BtnUpload_Click" />
        <%-- <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" style="z-index: 1; left: 252px; top: 274px; position: absolute; height: 180px; width: 289px">
            <Columns>
                <asp:BoundField DataField="FileName" HeaderText="File Name" />
                <asp:BoundField DataField="FileSize" HeaderText="File Size" />
                <asp:BoundField DataField="DateSubmitted" HeaderText="Date Submitted" />
                <asp:BoundField DataField="DownloadUpdate" HeaderText="Download/Update" />
                <asp:CommandField ButtonType="Button" HeaderText="Delete" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>--%>
        <asp:GridView ID="GridView1" runat="server" OnRowEditing="GridView1_RowEditing" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting">
            <Columns>
               
                 <asp:TemplateField HeaderText="File Name" HeaderStyle-Width="200px">
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("FileName") %>'
                 />
            </ItemTemplate>
            <EditItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("FileName") %>'
                 />
                <br></br>
                <asp:FileUpload ID="FileUpload2" runat="server" />
            </EditItemTemplate>
        </asp:TemplateField>
                <asp:TemplateField HeaderText="Date Submitted" HeaderStyle-Width="200px">
            <ItemTemplate>
                <asp:Label ID="Label2" runat="server" Text='<%# Eval("DateSubmitted") %>'
                 />
            </ItemTemplate>
            <EditItemTemplate>
                <asp:Label ID="Label2" runat="server" Text='<%# Eval("DateSubmitted") %>'></asp:Label>
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
        <p>
        <asp:FileUpload ID="FileUpload1" runat="server" style="z-index: 1; left: 123px; top: -50px; position: absolute" />
        </p>
        <p>

            <asp:Label ID="Label1" runat="server" Text="Label" style="z-index: 1; left: 14px; top: -122px; position: absolute"></asp:Label>

        </p>
        <p>
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" style="z-index: 1; left: 803px; top: -107px; position: absolute" Text="Log Out" />
        </p>
        <asp:Button ID="btnAccountSettings" runat="server" Text="Account Settings" />
    </form>
</body>
</html>
