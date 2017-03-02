<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ForGoods.aspx.cs" Inherits="DBWork_ForGoods" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <%
        foreach(var item in Items) { %> 
        <p>
            <span data-itemID="<%=item.id %>""><%=item.name %></span>
            <a  href="<%="/getgoods/" + item.id %>"><%=item.name %></a> 
        </p>
        <%}
         %>


        <a runat="server" href="~/getgoods/1">id1</a>
    </div>
    </form>
</body>
</html>
