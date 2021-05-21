using Microsoft.AspNetCore.Mvc;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index() { return View(); }
  }
}
