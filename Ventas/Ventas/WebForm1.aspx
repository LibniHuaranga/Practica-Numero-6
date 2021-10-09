<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Ventas.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .nuevoEstilo1 {
            font-family: "Arial Narrow";
        }
        .auto-style1 {
            margin-top: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" CssClass="auto-style1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="#FF9999" />
            <EditRowStyle BackColor="#669999" />
            <EmptyDataRowStyle BackColor="#FF99CC" />
            <HeaderStyle BackColor="Maroon" Font-Bold="True" Font-Italic="True" />
            <PagerStyle BackColor="White" />
            <RowStyle BackColor="#FFCCCC" />
        </asp:GridView>
    </form>
</body>
</html>