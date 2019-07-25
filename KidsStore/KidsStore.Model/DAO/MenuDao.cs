using KidsStore.Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsStore.Model.DAO
{
   public class MenuDao
    {
        KidsStoreDBContext db = null;
        public MenuDao()
        {
            db = new KidsStoreDBContext();
        }
        public List<Menu> ListByGroupID(int groupId)
        {
            return db.Menus.Where(x => x.TypeID == groupId).ToList();
        }
    }
}
