using KidsStore.Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;

namespace KidsStore.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var productDao = new ProductDao();
            ViewBag.NewProduct = productDao.ListNewProduct(4);
            ViewBag.ListFeatureProduct = productDao.ListFeatureProduct(4);

            return View();

            
        }
        [ChildActionOnly]
        public ActionResult MainMenu()
        {
            var model = new MenuDao().ListByGroupID(1);
            return PartialView(model);
        }
        [ChildActionOnly]
        public ActionResult TopMenu()
        {
            var model = new MenuDao().ListByGroupID(2);
            return PartialView(model);
        }
        [ChildActionOnly]
        public ActionResult MenuFooter()
        {
            var model = new FooterDao().LayFooter();
            return PartialView(model);
        }
    public ActionResult Detail(long id)
        {
            var product = new ProductDao().ViewDetail(id);
            ViewBag.Category = new ProductCateDao().ViewDetail(product.CategoryID.Value);
            ViewBag.RelatedProducts = new ProductCateDao().ViewDetail(product.CategoryID.Value);
                return View(product);

        }
        public ActionResult ChiTietSP(long id)
        {
            ViewBag.ctsp = new ProductDao().LaySP(id);
            return View();
        }


    }


}