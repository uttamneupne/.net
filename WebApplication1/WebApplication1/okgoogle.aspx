<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="okgoogle.aspx.cs" Inherits="WebApplication1.okgoogle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            first number&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :<asp:TextBox ID="Txt1" runat="server"></asp:TextBox>
        </p>
        <p>
            second number&nbsp; :<asp:TextBox ID="Txt2" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button2" runat="server" Text="Sum" OnClick="Button2_Click" />
        <br />
        <asp:Label ID="Label1" runat="server" EnableViewState="False" ForeColor="Red" Visible="False"></asp:Label>
        <p>
            Result<asp:TextBox ID="Txt3" runat="server"></asp:TextBox>
        </p>
    </form>
</body>
</html>
