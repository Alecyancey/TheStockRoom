using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheStockRoom.WebMVC.Controllers
{
    public class ShelvedItemController : Controller
    {
        // GET: ShelvedItem
        public ActionResult Index()
        {
            return View();
        }
    }
}