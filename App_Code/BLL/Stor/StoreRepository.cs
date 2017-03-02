using BLL.Stor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//using BLL.Stor;

/// <summary>
/// Сводное описание для StoreRepository
/// </summary>
public class StoreRepository: IDisposable
{
    #region Stuff
    private StoreEntities db;
    private bool disposed = false;

    public StoreRepository(StoreEntities context = null)
    {
        if (context == null) this.db = new StoreEntities();
        else this.db = context;
    }

    public void Save()
    {
        db.SaveChanges();
    }

    protected virtual  void Dispose (bool disposing)
    {
        if (!this.disposed) if (disposed) db.Dispose();

        this.disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    #endregion

    #region Goods
    public List<Good> GetGoods()
    {
        var res = new List<Good>();
        var key = "b_goods";

        if(CashManager.EnableCashing && CashManager.Cashe[key] != null )
        {
            res = (List<Good>)CashManager.Cashe[key];
        }
        else
        {
            res = db.Goods.ToList();
            CashManager.CasheData(key, res);
        }

        return res;
    }

    public Good GetGood (int ID)
    {
        var res = new Good();
        var key = "b_goods_good_" + ID;

        if (CashManager.EnableCashing && CashManager.Cashe[key] != null)
        {
            res = (Good)CashManager.Cashe[key];
        }
        else
        {
            res = db.Goods.SingleOrDefault(x => x.id == ID);
            CashManager.CasheData(key, res);
        }

        return res;
    }
    
    public int SaveGood (Good item)
    {
        if (item.id == 0)
        {
            db.Goods.Add(item); // Пришлось заменить AddObject на Add, поскольку в System отсутствовал первый
            db.SaveChanges();
        }
        else
        {
            db.Goods.Attach(db.Goods.Single(x => x.id == item.id));
            // db.Goods.ApplyCurrentValues(items); -- что за метод такой? В Систем его нет, чем его надо заменить?
            db.SaveChanges();
        }

        CashManager.PurgeCasheItems("b_goods");
        return item.id;
    }
    
    public bool DeleteGood(int ID)
    {
        bool result = false;
        var item = db.Goods.FirstOrDefault(x => x.id == ID);

        if (item != null)
        {
            //db.Goods.DeleteObject(item); --тоже заменила практически наугад. Что делать?
            db.Goods.Remove(item);
            db.SaveChanges();
            result = true;
        }

        CashManager.PurgeCasheItems("b_goods");

        return result;
    }
    #endregion
}