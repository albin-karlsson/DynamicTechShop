using DynamicTechShop.Models;

namespace DynamicTechShop.Managers
{
    public static class CartManager
    {
        public static List<ProductModel> Cart { get; set; } = new();

        public static double? GetTotalPrice()
        {
            return Cart.Sum(p => p.Price);
        }
    }
}
