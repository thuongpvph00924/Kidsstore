using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidsStore.Model.EF;


namespace KidsStore.Controllers
{
    public class SarchController : Controller
    {
        // GET: Sarch
        public ActionResult KetQuaTimKiem()
        {

            return View();
        }
    }
}