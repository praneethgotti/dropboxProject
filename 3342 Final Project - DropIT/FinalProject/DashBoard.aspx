<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DashBoard.aspx.cs" Inherits="FinalProject.DashBoard" %>

<%@ Register Src="~/UserControlContact.ascx" TagPrefix="uc1" TagName="UserControlContact" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            z-index: 1;
            left: 39px;
            top: 164px;
            position: absolute;
            height: 207px;
            width: 926px;
        }
         body
        {
            margin: 0;
            padding: 0;
            font-family: Arial;
            font-size: 10pt;
        }
        .modal
        {
            position: fixed;
            z-index: 999;
            height: 100%;
            width: 100%;
            top: 0;
            background-color: Black;
            filter: alpha(opacity=60);
            opacity: 0.6;
            -moz-opacity: 0.8;
        }
        .center
        {
            z-index: 1000;
            margin: 300px auto;
            padding: 10px;
            width: 130px;
            background-color: White;
            border-radius: 10px;
            filter: alpha(opacity=100);
            opacity: 1;
            -moz-opacity: 1;
        }
        .center img
        {
            height: 128px;
            width: 128px;
        }
    </style>
</head>
<body style="background-color:powderblue;">
    <form id="form1" runat="server">
        <div>

        </div>
        
        <%-- <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" style="z-index: 1; left: 252px; top: 274px; position: absolute; height: 180px; width: 289px">
            <Columns>
                <asp:BoundField DataField="FileName" HeaderText="File Name" />
                <asp:BoundField DataField="FileSize" HeaderText="File Size" />
                <asp:BoundField DataField="DateSubmitted" HeaderText="Date Submitted" />
                <asp:BoundField DataField="DownloadUpdate" HeaderText="Download/Update" />
                <asp:CommandField ButtonType="Button" HeaderText="Delete" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>--%>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowCommand="GridView1_RowCommand" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
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
                <asp:LinkButton ID="LkB4" runat="server" CommandName="Delete">Delete</asp:LinkButton>
                
            </ItemTemplate>
            <EditItemTemplate>
                <asp:LinkButton ID="LkB2" runat="server" CommandName="Update">Update</asp:LinkButton>
                <asp:LinkButton ID="LkB3" runat="server" CommandName="Cancel">Cancel</asp:LinkButton>
            </EditItemTemplate>

<HeaderStyle Width="150px"></HeaderStyle>
        </asp:TemplateField>
                <asp:TemplateField HeaderStyle-Width="150px">
                    
            <ItemTemplate>
                <asp:LinkButton ID="LKB5" runat="server" CommandName="Download">Download</asp:LinkButton>
            </ItemTemplate>

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
        <p>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
            <ProgressTemplate>
                <div class="modal">
                    <div class="center">
                        <img alt="" src="http://www.downgraf.com/wp-content/uploads/2014/09/01-progress.gif.pagespeed.ce.DETazxsDgB.gif" />
                    </div>
                </div>
            </ProgressTemplate>
            </asp:UpdateProgress>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div style="margin: 20px">
                    <asp:FileUpload ID="FileUpload1" runat="server" style="z-index: 1; left: 123px; top: -50px; position: absolute" />
       
                    <%--<asp:RequiredFieldValidator ErrorMessage="Required" ControlToValidate="FileUpload1"
                        runat="server" ForeColor="Red"></asp:RequiredFieldValidator>--%>
                    <br />
                    <br />
                    <asp:Button ID="BtnUpload" runat="server" style="z-index: 1; left: 467px; top: -52px; position: absolute" Text="Upload" OnClick="BtnUpload_Click" />
                </div>
            </ContentTemplate>
            <Triggers>
                <asp:PostBackTrigger ControlID="BtnUpload" />
            </Triggers>
            </asp:UpdatePanel>
         </p>
        <p>

            <asp:Label ID="Label1" runat="server" Text="Label" style="z-index: 1; left: 14px; top: -122px; position: absolute"></asp:Label>

        </p>
        <p>
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" style="z-index: 1; left: 821px; top: -107px; position: absolute" Text="Log Out" />
            <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 1px; top: 314px; position: absolute" Text="Need More Place?"></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="Plan Purchase" OnClick="Button1_Click" style="z-index: 1; left: 187px; top: 311px; position: absolute" />
        </p>
        <asp:Button ID="btnAccountSettings" runat="server" Text="Account Settings" style="z-index: 1; left: 416px; top: -105px; position: absolute" />
        <asp:Button ID="btnRecycleBin" runat="server" style="z-index: 1; left: 652px; top: -106px; position: absolute" Text="Recycle Bin" OnClick="btnRecycleBin_Click" />
    <script type="text/javascript">
        window.onsubmit = function () {
            if (Page_IsValid) {
                var updateProgress = $find("<%= UpdateProgress1.ClientID %>");
                window.setTimeout(function () {
                    updateProgress.set_visible(true);
                },50);
            }
        }
    </script>
        <p>
            &nbsp;</p>
    </form>
    </body>
</html>
