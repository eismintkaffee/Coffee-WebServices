<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CoffeeSortForm.aspx.cs" Inherits="CoffeeSort.CoffeeSortForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Coffee Sort</h1>
        <h5>Sorts the coffee menu alphabetically, by price and by calories</h5>
    </div>
         <div>
    <h2>Menu</h2>

    </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:Button ID="Alpha" runat="server" OnClick="Alpha_Click" Text="A-Z" />
            <asp:Button ID="alphaZ" runat="server" Text="Z-A" OnClick="alphaZ_Click" />
            <asp:Button ID="priceLow" runat="server" Text="Price Lowest" OnClick="priceLow_Click" />
            <asp:Button ID="priceHigh" runat="server" Text="Prices Highest" OnClick="priceHigh_Click" />
            <asp:Button ID="calLow" runat="server" Text="Calories Lowest" OnClick="calLow_Click" />
            <asp:Button ID="calHigh" runat="server" Text="Calories Highest" OnClick="calHigh_Click" />
        </p>
    </form>
</body>
</html>
