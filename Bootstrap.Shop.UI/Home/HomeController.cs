using System.Diagnostics;
using Bootstrap.Shop.UI.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Bootstrap.Shop.UI.Home;

public class HomeController : Controller
{
  private readonly ILogger<HomeController> _logger;

  public HomeController(ILogger<HomeController> logger) => _logger = logger;

  public IActionResult Index() => View(viewName: "~/Home/Index.cshtml");

  public IActionResult Privacy() => View(viewName: "~/Home/Privacy.cshtml");

  [ResponseCache(
    Duration = 0,
    Location = ResponseCacheLocation.None,
    NoStore = true)]
  public IActionResult Error() => View(
    viewName: $"../Shared/{nameof(Error)}",
    new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
}
