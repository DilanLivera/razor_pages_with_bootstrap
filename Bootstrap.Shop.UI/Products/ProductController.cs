using Microsoft.AspNetCore.Mvc;

namespace Bootstrap.Shop.UI.Products;

public class ProductController : Controller
{
  public IActionResult Index()
  {
    var products = new ProductsViewModel(GenerateMockProducts());

    return View(
      viewName: "~/Products/Index.cshtml",
      products);
  }

  private static List<Product> GenerateMockProducts() =>
  [
    new Product("Laptop", 899.99m, "High-performance laptop with SSD storage", false, "TechCo"),
    new Product("Smartphone", 599.00m, "5G smartphone with dual cameras", true, "GadgetWorld"),
    new Product("Wireless Headphones", 129.99m,
      "Noise-canceling headphones with long battery life", true, "AudioTech"),
    new Product("Fitness Tracker", 49.95m, "Waterproof fitness tracker with heart rate monitor",
      false, "FitGear"),
    new Product("Coffee Maker", 39.99m, "Programmable coffee machine for home use", true,
      "HomeAppliances"),
    new Product("Bluetooth Speaker", 79.99m, "Portable speaker with rich sound quality", true,
      "SoundWave"),
    new Product("Gaming Mouse", 49.95m,
      "High-precision gaming mouse with customizable RGB lighting", true, "GameGear"),
    new Product("Yoga Mat", 29.99m, "Eco-friendly non-slip yoga mat for home workouts", false,
      "WellnessSupplies"),
    new Product("Wireless Charger", 24.99m, "Fast-charging pad for smartphones and accessories",
      true, "PowerTech"),
    new Product("Running Shoes", 89.95m, "Lightweight running shoes with breathable mesh", false,
      "FootFit"),
    new Product("Digital Watch", 69.00m, "Water-resistant digital watch with multiple features",
      true, "TimeTech"),
    new Product("Cookware Set", 149.00m, "Non-stick cookware set for everyday cooking", false,
      "KitchenEssentials"),
    new Product("Desk Organizer", 19.99m, "Compact desk organizer with compartments", true,
      "OfficeSupplies"),
    new Product("Sunglasses", 59.95m, "Polarized sunglasses for UV protection", false,
      "SunStyle"),
    new Product("Reusable Water Bottle", 12.99m, "BPA-free water bottle with flip-top lid", true,
      "EcoLife"),
    new Product("Wireless Earbuds", 79.00m, "True wireless earbuds with noise cancellation", true,
      "AudioTech"),
    new Product("Backpack", 49.99m, "Durable backpack with laptop compartment", false,
      "AdventureGear")
  ];
}
