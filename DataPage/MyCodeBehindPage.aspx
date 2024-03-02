<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyCodeBehindPage.aspx.cs" Inherits="carbon_footprint_application.DataPage.MyCodeBehindPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="postDataForm" runat="server">
        <h2>Enter Data</h2>
        <label for="username">Username:</label><br />
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox><br />
        <label for="email">Email:</label><br />
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br />
        <label for="message">Message:</label><br />
        <asp:TextBox ID="txtMessage" TextMode="MultiLine" Rows="4" Columns="50" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit"  />
    </form>
    <div>
        <h2>Received Data</h2>
        <asp:Label ID="lblUsername" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="lblEmail" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label><br />
    </div>
</body>
</html>
