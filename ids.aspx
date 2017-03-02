<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ids.aspx.cs" Inherits="ids" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    This is <%= Page.RouteData.Values["name"] %>
        <br />
        <%= Page.RouteData.Values["id"] %>
    </div>
    </form>
</body>
</html>
