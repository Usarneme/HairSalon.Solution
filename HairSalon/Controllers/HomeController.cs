using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class HomeController : Controller
  {
    private readonly HairSalonContext _db;

    public HomeController(HairSalonContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index() { return View(); }

    [HttpGet("/Home/Search")]
    public ActionResult Search([FromQuery(Name = "Search")] string query)
    {
      ViewBag.Stylists = _db.Stylists.FirstOrDefault(stylist => stylist.Name == query);
      ViewBag.Clients = _db.Clients.FirstOrDefault(client => client.Name == query);
      ViewBag.Query = query;
      return View();
    }
  }
}
