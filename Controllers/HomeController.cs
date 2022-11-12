using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserData;

namespace UserAPI.Controllers
{
  public class HomeController : Controller
  {
    FormDataEntities db = new FormDataEntities();
    public ActionResult Index()
    {
      //var data = db.UserDetails.ToList();
      //return View(data);
      return View();
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