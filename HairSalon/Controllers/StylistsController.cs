using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {

    private readonly HairSalonContext _db;

    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }

    [HttpGet("/stylists")]
    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylists.ToList();
      return View(model);
    }

    [HttpGet("/stylists/create")]
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost("/stylists/create")]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpGet("/stylists/details/{id}")]
    public ActionResult Details(int id)
    {
      Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      IEnumerable<Client> theirClients = _db.Clients.Where(client => client.StylistId == id);
      Dictionary<string, object> models = new Dictionary<string, object>();
      models.Add("stylist", thisStylist);
      models.Add("clients", theirClients);
      return View(models);
    }
  }
}
