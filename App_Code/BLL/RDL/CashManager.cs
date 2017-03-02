using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using WebGrease;
//using System.Data.Objects;
using BLL.Stor;



/// <summary>
/// Сводное описание для CashManager
/// </summary>
public abstract class CashManager
{
    public static bool EnableCashing { get { return true; } }
    public static int CasheDuration { get { return 600; } }

    public static System.Web.Caching.Cache Cashe
    {
        get { return HttpContext.Current.Cache; }
    }

    public static void PurgeCasheItems(string prefix)
    {
        prefix = prefix.ToLower();
        List<string> itemsToRemove = new List<string>();
        IDictionaryEnumerator enumerator = Cashe.GetEnumerator();

        while (enumerator.MoveNext())
        {
            if (enumerator.Key.ToString().ToLower().StartsWith(prefix))
                itemsToRemove.Add(enumerator.Key.ToString());
        }

        foreach (string itemToRemove in itemsToRemove)
        {
            Cashe.Remove(itemToRemove);
        }
    }

    public static void CasheData(string key, object data)
    {
        if (EnableCashing && data != null)
        {
            CashManager.Cashe.Insert(key, data, null,
                DateTime.Now.AddMinutes(CasheDuration), TimeSpan.Zero);
        }
    }

    public static void CasheData(string key, object data, int duration)
    {
        if (data != null)
        {
            CashManager.Cashe.Insert(key, data, null,
                DateTime.Now.AddMinutes(duration), TimeSpan.Zero);
        }
    }
}