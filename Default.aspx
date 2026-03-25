<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<html>
<body>
<h2>Login</h2>
<form runat="server">
<asp:TextBox ID="txtUser" runat="server" placeholder="Username"></asp:TextBox><br/>
<asp:TextBox ID="txtPass" runat="server" TextMode="Password" placeholder="Password"></asp:TextBox><br/>
<asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/>
</form>
</body>
</html>