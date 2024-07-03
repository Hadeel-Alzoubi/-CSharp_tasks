<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="FormInfo.Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                        <br />
            Name&nbsp;
            <asp:TextBox ID="Text1" runat="server"></asp:TextBox>
         
            <br />
            ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Text2" runat="server"></asp:TextBox>
            <br />
            Email&nbsp; 
            <asp:TextBox ID="Text3" runat="server"></asp:TextBox>
            <br />
             <br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                  <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                  <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem Text="HTML" Value="HTML"></asp:ListItem>
                <asp:ListItem Text="CSS" Value="CSS"></asp:ListItem>
                <asp:ListItem Text="JavaScript" Value="JavaScript"></asp:ListItem>
            </asp:CheckBoxList>
         
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Height="93px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        </div>
        <p>
</p>
         My Name :
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
<p>
      My ID :
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
</p>
        <p>
        My Email :
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
</p>
        <p>
         My Gender :
        <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
</p>
        <p>
        Courses :
        <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
</p>
         <p>
         Description :
        <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
</p>
      
    </form>
</body>
</html>
