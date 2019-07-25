using KidsStore.Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsStore.Model.DAO
{
   public class FooterDao
    {
        KidsStoreDBContext db = null;
        public FooterDao()
        {
            db = new KidsStoreDBContext();
        }
        public Footer LayFooter()
        {
            return db.Footers.SingleOrDefault();
        }
    }
}
