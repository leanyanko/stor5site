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
            <a  href="<%="/getgoods/" + item.id %>"><%=item.name %></a> 
        </p>
        <%}
         %>

    </div>
    </form>
</body>
</html>
