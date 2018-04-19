<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeletedFile.aspx.cs" Inherits="FinalProject.DeletedFile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:powderblue;">
    <form id="form1" runat="server">
        <div style="height: 18px">
            <asp:Label ID="Label1" runat="server" Text="Label">
                <br></br>
            </asp:Label><asp:GridView ID="GridView1" AutoGenerateColumns="False" runat="server" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" style="z-index: 1; left: 59px; top: 253px; position: absolute; height: 180px; width: 560px">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <Columns>
               <asp:TemplateField HeaderText="Date Submitted" Visible="false" HeaderStyle-Width="200px">
            <ItemTemplate>
                <asp:Label ID="Label3" runat="server" Text='<%# Eval("ID") %>'
                 />
            </ItemTemplate>
            <EditItemTemplate>
                <asp:Label ID="Label3" runat="server" Text='<%# Eval("ID") %>'></asp:Label>
            </EditItemTemplate>

<HeaderStyle Width="200px"></HeaderStyle>
        </asp:TemplateField>
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

<HeaderStyle Width="200px"></HeaderStyle>
        </asp:TemplateField>
                <asp:TemplateField HeaderText="Date Submitted" HeaderStyle-Width="200px">
            <ItemTemplate>
                <asp:Label ID="Label2" runat="server" Text='<%# Eval("DateSubmitted") %>'
                 />
            </ItemTemplate>
            <EditItemTemplate>
                <asp:Label ID="Label2" runat="server" Text='<%# Eval("DateSubmitted") %>'></asp:Label>
            </EditItemTemplate>

<HeaderStyle Width="200px"></HeaderStyle>
        </asp:TemplateField>
                
                <asp:TemplateField HeaderStyle-Width="150px">
                    
           <ItemTemplate>
                <asp:LinkButton ID="LkB1" runat="server" CommandName="Edit">Edit</asp:LinkButton>
            
            </ItemTemplate>
            <EditItemTemplate>
                <asp:LinkButton ID="LkB2" runat="server" CommandName="Update">Restore</asp:LinkButton>
                <asp:LinkButton ID="LkB3" runat="server" CommandName="Cancel">Cancel</asp:LinkButton>
            </EditItemTemplate>
            
<HeaderStyle Width="150px"></HeaderStyle>
            
        </asp:TemplateField>
            </Columns>
                        <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
                        </asp:GridView>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Dashboard" style="z-index: 1; left: 9px; top: 84px; position: absolute" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Logout" style="z-index: 1; left: 849px; top: 83px; position: absolute" />
    </form>
</body>
</html>
