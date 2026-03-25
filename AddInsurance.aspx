<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddInsurance.aspx.cs" Inherits="AddInsurance" %>
<html>
<body>
<h2>Add Insurance</h2>
<form runat="server">
<asp:TextBox ID="txtCompany" runat="server" placeholder="Company"></asp:TextBox><br/>
<asp:TextBox ID="txtName" runat="server" placeholder="Plan"></asp:TextBox><br/>
<asp:TextBox ID="txtDesc" runat="server" placeholder="Description"></asp:TextBox><br/>
<asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click"/>
</form>
</body>
</html>