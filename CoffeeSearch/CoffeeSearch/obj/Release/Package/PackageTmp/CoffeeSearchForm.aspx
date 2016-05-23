<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CoffeeSearchForm.aspx.cs" Inherits="CoffeeSearch.CoffeeSearchForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Coffee Search</h1>

    </div>
        <div>
            <h2>Menu</h2>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
        </p>
        <asp:Label ID="Label2" runat="server" Text="Enter a coffee to be searched"></asp:Label>
            </div>
    </form>
</body>
</html>
