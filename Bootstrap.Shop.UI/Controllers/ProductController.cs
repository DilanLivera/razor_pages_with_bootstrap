using Microsoft.AspNetCore.Mvc;

namespace Bootstrap.Shop.UI.Controllers;

public class ProductController : Controller
{
  public IActionResult Index() => View();
}
