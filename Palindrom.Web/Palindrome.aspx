<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Palindrome.aspx.cs" Inherits="Palindrom.Web.Palindrome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Palindrome Checker</title>
</head>
<body>
    <h1>Palindrome Checker</h1>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:TextBox ID="input" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Check for Palindrome" Width="239px" />
        <p>
            <asp:TextBox ID="result" runat="server" ReadOnly="true" ></asp:TextBox>
        </p>
    </form>
</body>
</html>
