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
    This is <%= Items.Find(x=> x.id == (Convert.ToInt32(Page.RouteData.Values["id"].ToString()))).name %>
        <br />
        id: <%= Page.RouteData.Values["id"] %>
        <br />
        price:  <%= Items.Find(x=> x.id == (Convert.ToInt32(Page.RouteData.Values["id"].ToString()))).price %>
        <br />
        category id:  <%= Items.Find(x=> x.id == (Convert.ToInt32(Page.RouteData.Values["id"].ToString()))).categoryID %>
        <br />
    </div>
    </form>
</body>
</html>
