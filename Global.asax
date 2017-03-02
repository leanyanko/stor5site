<%@ Application Language="C#" %>
<%@ Import Namespace="Stor5Site" %>
<%@ Import Namespace="System.Web.Optimization" %>
<%@ Import Namespace="System.Web.Routing" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        System.Web.Routing.RouteTable.Routes.MapPageRoute("ForGoods", "GetGoods/{id}", "~/ids.aspx");

        RouteConfig.RegisterRoutes(RouteTable.Routes);
        BundleConfig.RegisterBundles(BundleTable.Bundles);
    }

</script>
