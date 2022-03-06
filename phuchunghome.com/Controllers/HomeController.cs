using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using phuchunghome.com.Service;


namespace phuchunghome.com.Controllers
{
    public class HomeController : Controller
    {
        public JsonResult Index()
        {
            var db = DatabaseConnection.Instance.ExcuteTest();
            List<Dictionary<string, object>> ds = new List<Dictionary<string, object>>();
            ds.AddRange(DatabaseConnection.Instance.GetTableRows(db));
            var json = Json(ds, JsonRequestBehavior.AllowGet);
            json.MaxJsonLength = int.MaxValue;
            return json;
          
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}