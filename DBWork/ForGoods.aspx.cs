using BLL.Stor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DBWork_ForGoods : System.Web.UI.Page
{
    private StoreRepository _mng = new StoreRepository();
    public List<Good> Items;

    //    string parameter = Page.RouteData.Values["id"].ToString();

  

    protected void Page_Load(object sender, EventArgs e)
    {
        var s = _mng.GetGoods().Count;
        Items = _mng.GetGoods();
        //Response.Write(s);
        var name = _mng.GetGood(1);
        Response.Write(name.name);

  //   string par = Page.RouteData.Values["1"].ToString();
    }
}