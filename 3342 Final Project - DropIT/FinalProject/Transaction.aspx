<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Transaction.aspx.cs" Inherits="FinalProject.Transaction" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 13px;
            left: 236px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 37px;
            z-index: 1;
            left: 241px;
        }
        .auto-style3 {
            position: absolute;
            top: 61px;
            left: 239px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 82px;
            left: 235px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 223px;
            left: 10px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 192px;
            left: 10px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 158px;
            left: 10px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 129px;
            left: 10px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 84px;
            left: 338px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 62px;
            left: 340px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            top: 62px;
            left: 439px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: 16px;
            left: 339px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 41px;
            left: 339px;
            z-index: 1;
        }
        .auto-style15 {
            position: absolute;
            top: 41px;
            left: 431px;
            z-index: 1;
        }
        .auto-style17 {
            position: absolute;
            top: 18px;
            left: 476px;
            z-index: 1;
        }
        .auto-style19 {
            position: absolute;
            top: 42px;
            left: 515px;
            z-index: 1;
        }
    </style>
</head>
<body style="background-color:powderblue;">
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" CssClass="auto-style1" Text="Card Number"></asp:Label>
            <asp:RequiredFieldValidator ID="rfvCard" runat="server" CssClass="auto-style13" ErrorMessage="Enter Card Number" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
            
             <asp:RegularExpressionValidator ErrorMessage="Enter a 10 digit number" 
                        ControlToValidate="TextBox1" runat="server" ValidationExpression="^\d{10}$" CssClass="auto-style17" />


            <br />
            <asp:TextBox ID="TextBox2" runat="server" Width="62px"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" Width="81px"></asp:TextBox>
            <asp:Label ID="Label5" runat="server" CssClass="auto-style2" Text="mm/yy"></asp:Label>
            <asp:RequiredFieldValidator ID="rfvMonth" runat="server" CssClass="auto-style14" ErrorMessage="Enter Month" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="rfvYear" runat="server" CssClass="auto-style15" ErrorMessage="Enter Year" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
           
            
             <asp:RegularExpressionValidator ErrorMessage="Enter a 2 digit number" 
                        ControlToValidate="TextBox3" runat="server" ValidationExpression="^\d{2}$" CssClass="auto-style19" />
                        
            
            
            <br />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:Label ID="Label6" runat="server" CssClass="auto-style3" Text="CVV"></asp:Label>
            <asp:RequiredFieldValidator ID="rfvCVV" runat="server" CssClass="auto-style10" ErrorMessage="Enter CVV" ControlToValidate="TextBox4"></asp:RequiredFieldValidator>
            
            

            <asp:RegularExpressionValidator ErrorMessage="Enter a 3 digit number" 
                        ControlToValidate="TextBox4" runat="server" ValidationExpression="^\d{3}$" CssClass="auto-style12" />


            <br />
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <asp:Label ID="Label7" runat="server" CssClass="auto-style4" Text="Name"></asp:Label>
            <asp:RequiredFieldValidator ID="rfvname" runat="server" CssClass="auto-style9" ErrorMessage="Enter a name" ControlToValidate="TextBox5"></asp:RequiredFieldValidator>
            <br />
            <asp:DropDownList ID="DropDownList1" AutoPostBack="true" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>None</asp:ListItem>
                <asp:ListItem>100MB</asp:ListItem>
                <asp:ListItem>200MB</asp:ListItem>
                <asp:ListItem>Unlimited</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label" CssClass="auto-style8"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Purchase" OnClick="Button1_Click" CssClass="auto-style7" />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Label" CssClass="auto-style6"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Label" CssClass="auto-style5"></asp:Label>
        </div>
    </form>
</body>
</html>
