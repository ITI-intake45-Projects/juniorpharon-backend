using JuniorPharon.Models;

namespace JuniorPharon.ViewModels
{
    public static class ProductExt
    {
        public static Product ToCreate(this ProductCreateVM vm)
        {
            return new Product
            {
                Price = vm.Price,
                StockQuantity = vm.StockQuantity,
                IsActive = vm.IsActive,
                CreatedAt = DateTime.Now
            };
        }

        public static ProductDetailsVM ToDetails(this Product product)
        {
            return new ProductDetailsVM
            {
                Id = product.Id,
                Price = product.Price,
                StockQuantity = product.StockQuantity,
                IsActive = product.IsActive,
                CreatedAt = product.CreatedAt
            };
        }

        public static Product ToEdit(this ProductEditVM vm, Product product)
        {
            product.Price = vm.Price;
            product.StockQuantity = vm.StockQuantity;
            product.IsActive = vm.IsActive;

            return product;
        }
    }
}