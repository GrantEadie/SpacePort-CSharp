using Microsoft.AspNetCore.Mvc;

namespace SpacePort.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}