<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            User Name*<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <p>
            Password*<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            Confirm Password*<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
            Age*<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>
            Pincode*<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
