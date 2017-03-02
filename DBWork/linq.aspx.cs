using BLL.Stor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DBWork_linq : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        StoreRepository mng = new StoreRepository();
        var items = mng.GetGoods(); //.Where(x=>x.id == 2);

        //  var items = items.Select

        //  var ten = items.Skip(3).Take(12).OrderBy(x=>x.name);

        var ten = items.Select(x => new { x.name });

        foreach (var item in items)
            Response.Write(item.name + "<hr />");


        Response.Write("<hr /> This is ten: ");
        foreach (var item in ten)
            Response.Write(item.name + "<hr />");
    }

}