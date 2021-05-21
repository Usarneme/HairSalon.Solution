using Microsoft.AspNetCore.Mvc;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index() { return View(); }
  }
}
