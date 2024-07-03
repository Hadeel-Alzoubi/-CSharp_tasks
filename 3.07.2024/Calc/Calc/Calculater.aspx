<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculater.aspx.cs" Inherits="Calc.Calculater" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <asp:Label ID="Result" runat="server" Text=""></asp:Label>
          <br />
          <br />
          <asp:TextBox ID="Number1" runat="server" ></asp:TextBox>
          <br />
          <br />
          <asp:TextBox ID="Number2" runat="server"></asp:TextBox>
          <br />
          <br />
          <asp:Button ID="Button1" runat="server" Text="+" BackColor="#3333FF" OnClick="Button1_Click" Width="164px" />
          <asp:Button ID="Button2" runat="server" Text="-" BackColor="Yellow" Width="165px" OnClick="Button2_Click" />
          <asp:Button ID="Button3" runat="server" Text="*" BackColor="#FF66FF" Width="171px" OnClick="Button3_Click" />
          <asp:Button ID="Button4" runat="server" Text="/" BackColor="#33CC33" BorderColor="#33CC33" Width="170px" OnClick="Button4_Click" />
        </div>
    </form>
</body>
</html>
