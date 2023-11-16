<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASPApp2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Id&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" BorderColor="#0099FF"></asp:TextBox>
            <br />
            <br />
            Name&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" BorderColor="#FFFF66"></asp:TextBox>
            <br />
            <br />
            Dept&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" BorderColor="#FF6666"></asp:TextBox>
            <br />
            <br />
            Salary&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" BorderColor="#99FF66"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" BorderColor="Blue" OnClick="Button1_Click" Text="Insert" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Data Added Successfully" Visible="False"></asp:Label>
        </div>
    </form>
</body>
</html>
