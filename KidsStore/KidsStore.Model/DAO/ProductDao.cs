using KidsStore.Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsStore.Model.DAO
{
    public class ProductDao
    {
        KidsStoreDBContext db = null;
        public ProductDao()
        {
            db = new KidsStoreDBContext();
        }
        public List<Product> ListNewProduct(int top)
        {
            return db.Products.OrderByDescending(x => x.CreateDate) .Take(top).ToList();
        }
      public List<Product>ListFeatureProduct(int top)
        {
            return db.Products.Where(x => x.TopHot != null&&x.TopHot>DateTime.Now).OrderByDescending(x => x.CreateDate).Take(top).ToList();
        }
        public List<Product> ListRelatedProduct(long productId)

        {
            var product = db.Products.Find(productId);
            return db.Products.Where(x => x.ID != productId && x.CategoryID==product.CategoryID).ToList();
        }
        public Product ViewDetail(long id)
        {
            return db.Products.Find(id);
        }
        public Product LaySP(long id)
        {
            return db.Products.Find(id);
        }
        public List<string> ListName(string keyword)
        {
            return db.Products.Where(x => x.Name.Contains(keyword)).Select(x =>x.Name).ToList();
        }
        
    }
}