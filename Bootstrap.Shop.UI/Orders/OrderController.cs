using Microsoft.AspNetCore.Mvc;

namespace Bootstrap.Shop.UI.Orders;

public class OrderController : Controller
{
  public IActionResult Index() => View(viewName: "~/Orders/Index.cshtml");
}
