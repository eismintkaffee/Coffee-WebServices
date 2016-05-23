<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CoffeeSearch.aspx.cs" Inherits="CoffeeSearch.CoffeeSearch1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Coffee Search</h1>
        <p class="lead">Search for Coffee by name</p>
    </div>
        <div>
             <h2>Menu</h2>

        </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
        </p>
        <asp:Label ID="Label2" runat="server" Text="Coffee"></asp:Label>
    </form>
</body>
</html>
