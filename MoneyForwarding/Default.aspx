<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MoneyForwarding.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Money Forwarding: Calculate the value of money in future<br />
            <br />
            Current Value of Money:
            <asp:TextBox ID="currentValueTextBox" runat="server" Width="109px"></asp:TextBox>
            <br />
            <br />
            Return earned (interest):
            <asp:TextBox ID="interestTextBox" runat="server" Width="50px"></asp:TextBox>
&nbsp;%<br />
            <br />
            Number of years to forwards: <asp:TextBox ID="nYearsTextBox" runat="server" Width="49px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="calculateButton" runat="server" OnClick="calculateButton_Click" Text="Calculate" />
&nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="ResultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
