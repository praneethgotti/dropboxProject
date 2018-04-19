<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="FinalProject.LoginPage" %>

<%@ Register Src="~/UserControlContact.ascx" TagPrefix="uc1" TagName="UserControlContact" %> <br />
<%@ Register Src="~/UserControlAbout.ascx" TagPrefix="uc1" TagName="UserControlAbout" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link href="CSS/main.css" rel ="stylesheet" />
    
    <title>
    </title>

    
</head>
    <body >
        


        
    <div class="container">
    <div class="row">
        <div class="col-md-4 col-md-offset-4">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <span class="glyphicon glyphicon-lock"></span> Login</div>
                <div class="panel-body">
                    <form class="form-horizontal" role="form" runat="server">
                    <div class="form-group">
                        <label for="inputEmail3" class="col-sm-3 control-label">
                            Username</label>
                        <div class="col-sm-9">
                            <%--<input type="email" class="form-control" id="inputEmail3" placeholder="Email" required>--%>
                            <asp:TextBox ID="inputEmail3" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="inputPassword3" class="col-sm-3 control-label">
                            Password</label>
                        <div class="col-sm-9">
                            <%--<input type="password" class="form-control" id="inputPassword3" placeholder="Password" required>--%>
                            <asp:TextBox ID="inputPassword3" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-offset-3 col-sm-9">
                            <div class="checkbox">
                                <label>
                                <%--<input type="checkbox"/>--%>
                                    <asp:CheckBox ID="CheckBox1" runat="server" Text="Remember Me" ForeColor="#72C02C" />
                                    <br />
                                    <asp:CheckBox ID="CheckBox2" runat="server" Text="Forget Me" ForeColor="#72C02C" />

                                </label>
                            </div>
                        </div>
                    </div>
                    <div class="form-group last">
                        <div class="col-sm-offset-3 col-sm-9">
                            <%--<button type="submit" class="btn btn-success btn-sm">
                                Sign in</button>--%>
                            <asp:Button ID="Login" CssClass="btn btn-success btn-sm" runat="server" Text="Login" OnClick="Login_Click" />
                            <%--<button type="reset" class="btn btn-default btn-sm">
                                Reset</button>--%>
                            <asp:Button ID="Reset" class="btn btn-default btn-sm" runat="server" Text="Reset" />
                            <br />
                            <asp:Label ID="Label1" runat="server" ForeColor="#72C02C"></asp:Label>
                        </div>
                         
                    </div>
                        <asp:Button ID="btnRedirectToAdmin" runat="server" OnClick="Button1_Click" Text="Click Here to Log In as an Admin or Super Admin" />
                    </form>
                </div>
                <div class="panel-footer">
                    Not Registered? <a href="SignupPage.aspx">Click Here To Register</a></div>
            </div>
        </div>
    </div>
</div>

    
    
</body>
</html>
