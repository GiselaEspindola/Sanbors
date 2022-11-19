using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class ProductsController : Controller
    {

        [HttpGet]
        public ActionResult GetAll()
        {
           
            return View();
        }
        public JsonResult ProductosDescontinuados()
        {
            ML.Result result = BL.Products.GetAll();

            return Json(result.Objects, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetAll2()
        {

            return View();
        }

        public JsonResult ProductosCategorias()
        {
            ML.Result result = BL.Products.GetAll2();

            return Json(result.Objects, JsonRequestBehavior.AllowGet);
        }
    }
}