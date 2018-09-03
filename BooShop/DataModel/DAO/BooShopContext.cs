using DataModel.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Dao
{
    public class BooShopContext
    {
        public static BooShopDBcontext Context
        {
            get
            {
                BooShopDBcontext db = null;
                var EnsureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
                if (db == null)
                    db = new BooShopDBcontext();
                return db;
            }
        }
    }
}
