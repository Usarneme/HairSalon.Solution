using Microsoft.AspNetCore.Mvc;
using System;
using System.Web;

namespace HairSalon.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index() { return View(); }

    [HttpGet("/Home/Search")]
    public ActionResult Search([FromQuery(Name = "Search")] string query)
    {
      // TODO
      Console.WriteLine("HIT SEARCH ROUTE; query: {0}",query);
      Console.WriteLine(query);
      ViewBag.Query = query;
      return View();
    }
  }
}
