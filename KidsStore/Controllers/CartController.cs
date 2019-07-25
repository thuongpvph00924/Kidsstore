
using KidsStore.Model.EF;
using KidsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class CartController : Controller
    {
        KidsStoreDBContext db = new KidsStoreDBContext();
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AddToCart(int id)
        {
            List<CartItem> giohang;
            if (Session["GioHang"] == null)//Giỏ hàng trống
            {
                giohang = new List<CartItem>();//tạo mới giỏ hàng
                //thêm vào giỏ hàng
                giohang.Add(new CartItem { Product = db.Products.Find(id), Quantity = 1 });
            }
            else//đã có giỏ hàng
            {
                giohang = (List<CartItem>)Session["GioHang"];
                //Tìm trong giỏ hàng xem đã có cuốn nào có masach = id
                CartItem s = giohang.SingleOrDefault(x => x.Product.ID == id);
                if (s != null)//nếu đã có cuốn sách đó trong giỏ hàng
                {
                    s.Quantity++;//tăng số lượng lên 1
                }
                else//nếu chưa có
                {
                    giohang.Add(new CartItem { Product = db.Products.Find(id), Quantity = 1 });
                }
            }
            //Cập nhật thông tin giỏ hàng
            Session["GioHang"] = giohang;
            return Json(new { ItemAmount = giohang.Sum(x => x.Quantity) });
        }

        public ActionResult ShoppingCart()
        {
            return View();
        }
    }
}