﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <h1> Exemplo Web Form</h1>

        <asp:Button ID="Button1" runat="server" Text="Clique Aqui" OnClick="Button1_Click" />

        <p>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>

    </form>
</body>
</html>
