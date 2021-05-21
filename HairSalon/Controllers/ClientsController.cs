using Microsoft.AspNetCore.Mvc;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    [HttpGet("/clients")]
    public ActionResult Index() { return View(); }
  }
}
