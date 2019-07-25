using KidsStore.Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsStore.Model.DAO
{
   public class ProductCateDao
    {
        KidsStoreDBContext db = null;
		public ProductCateDao()
        {
            db = new KidsStoreDBContext();
        }
		public List<ProductCategory>ListAll()
        {
            return db.ProductCategories.Where(x => x.Status == true).OrderBy(x => x.DisplayOrder).ToList();
        }
		public ProductCategory ViewDetail(long id)
        {
            return db.ProductCategories.Find(id);
        }
    }
}
