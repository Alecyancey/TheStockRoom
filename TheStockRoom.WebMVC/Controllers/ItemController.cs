using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheStockRoom.Models;

namespace TheStockRoom.WebMVC.Controllers
{
    [Authorize]
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            var model = new ItemListItem[0];
            return View(model);
        }
        //GET
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ItemCreate model)
        {
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}