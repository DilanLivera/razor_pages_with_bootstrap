namespace Bootstrap.Shop.UI.Products;

public record Product(
  string Name,
  decimal Price,
  string Description,
  bool IsOnSale,
  string Supplier);
