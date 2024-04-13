using Microsoft.AspNetCore.Mvc;

namespace Bootstrap.Shop.UI.Products;

public class ProductController : Controller
{
  public IActionResult Index() => View(viewName: "~/Products/Index.cshtml");
}
