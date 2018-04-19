<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUpPage.aspx.cs" Inherits="FinalProject.SignUpPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link href="CSS/SignUp.css" rel ="stylesheet" />

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <br />
<div class="container">
    <div class="col-md-3"></div>
    <div class="col-md-6">
         <div class="row myborder">
             <h4 style="color: #7EB59E; margin: initial; margin-bottom: 10px;">Sign Up Now</h4><hr>
             
            <div class="input-group margin-bottom-20">
                <span class="input-group-addon"><i class="glyphicon glyphicon-user mycolor"></i></span>
                <%--<input size="60" maxlength="255" class="form-control" placeholder="User Name" name="UserRegistration[username]" id="UserRegistration_username" type="text">--%>
              <asp:Label ID="lblFirstName" runat="server" CssClass="auto-style1" Text="First Name" ForeColor="#72C02C"></asp:Label>
                  <asp:TextBox ID="UserRegistration_fname" CssClass="form-control" runat="server" maxlength="255" name="UserRegistration[fname]"></asp:TextBox>
            </div>
            <div class="input-group margin-bottom-20">
                <span class="input-group-addon"><i class="glyphicon glyphicon-user mycolor"></i></span>
                <%--<input size="60" maxlength="255" class="form-control" placeholder="Password" name="UserRegistration[password]" id="UserRegistration_password" type="password">--%>   
               <asp:Label ID="lblLastName" runat="server" CssClass="auto-style1" Text="Last Name" ForeColor="#72C02C"></asp:Label>
                 <asp:TextBox ID="UserRegistration_lname" CssClass="form-control" runat="server" maxlength="255" name="UserRegistration[lname]"></asp:TextBox>
            </div>
            <div class="input-group margin-bottom-20">
                <span class="input-group-addon"><i class="glyphicon glyphicon-user mycolor"></i></span>
                <%--<input size="60" maxlength="255" class="form-control" placeholder="First Name" name="UserRegistration[fname]" id="UserRegistration_fname" type="text">--%>
               <asp:Label ID="lblUserName" runat="server" CssClass="auto-style1" Text="User Name" ForeColor="#72C02C"></asp:Label>
                 <asp:TextBox ID="UserRegistration_username" CssClass="form-control" runat="server" maxlength="255" name="UserRegistration[username]"></asp:TextBox>
                
            </div>
            <div class="input-group margin-bottom-20">
                <span class="input-group-addon"><i class="glyphicon glyphicon-lock mycolor"></i></span>
                <%--<input size="60" maxlength="255" class="form-control" placeholder="Last Name" name="UserRegistration[lname]" id="UserRegistration_lname" type="text">--%> 
                <asp:Label ID="lblPassword" runat="server" CssClass="auto-style1" Text="Password" ForeColor="#72C02C"></asp:Label>
                <asp:TextBox ID="UserRegistration_password" TextMode="Password" CssClass="form-control" runat="server" maxlength="255" name="UserRegistration[password]"></asp:TextBox>
                
            </div>
            <div class="input-group margin-bottom-20">
                <span class="input-group-addon"><i class="glyphicon glyphicon-envelope mycolor" ></i></span>
                <%--<input size="60" maxlength="255" class="form-control" placeholder="Email" name="UserRegistration[address]" id="UserRegistration_address" type="text">--%>
               <asp:Label ID="lblAddress" runat="server" CssClass="auto-style1" Text="Address" ForeColor="#72C02C"></asp:Label>
                 <asp:TextBox ID="UserRegistration_address" CssClass="form-control" runat="server" maxlength="255" name="UserRegistration[address]"></asp:TextBox>
                
            </div>
            <div class="input-group margin-bottom-20">
                <span class="input-group-addon"><i class="glyphicon glyphicon-phone mycolor"></i></span>
                <%--<input size="60" maxlength="255" class="form-control" placeholder="Contact Number" name="UserRegistration[contactnumber]" id="UserRegistration_contactnumber" type="text">--%>
               <asp:Label ID="lblContactNumber" runat="server" CssClass="auto-style1" Text="Contact Number" ForeColor="#72C02C"></asp:Label>
                 <asp:TextBox ID="UserRegistration_contactnumber" runat="server" name="UserRegistration[contactnumber]" CssClass="form-control" MaxLength="10" TextMode="Number"></asp:TextBox>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <%--<button class="btn-u pull-left" type="submit">Sign Up</button>--%>
                    <asp:Button ID="UserRegistration_submit" CssClass="btn-u pull-left" runat="server" Text="Sign Up" OnClick="UserRegistration_submit_Click" />
                </div>
               
        </div>
             <div class="row">
                 <div class="col-md-12">
              <asp:Label ID="Label1" runat="server" ForeColor="#72C02C"></asp:Label>
                     </div>
            </div>
             </div>
        <div class="col-md-2">

        </div>
    </div>
      </div>

        </div>
    </form>
</body>
</html>
