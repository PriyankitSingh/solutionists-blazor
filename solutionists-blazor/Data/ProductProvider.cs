using System;
using System.Collections.Generic;
using System.Linq;

namespace solutionists_blazor.Data
{
    public interface IProductProvider
    {
        IEnumerable<Product> GetAllProducts();
    }

    public class ProductProvider : IProductProvider
    {
        private readonly IList<string> _productNames = new List<string> {"Pen", "Shampoo", "Book", "Laptop"};
        private readonly Random _random = new();

        public IEnumerable<Product> GetAllProducts()
        {
            return GenerateFakeProducts(5);
        }

        private IEnumerable<Product> GenerateFakeProducts(int numberOfProducts)
        {
            IList<Product> generatedProducts = new List<Product>();

            for (var i = 0; i < numberOfProducts; i++)
            {
                yield return new Product
                {
                    Name = _productNames.ElementAt(_random.Next(_productNames.Count)),
                    ProductId = _random.Next(int.MaxValue),
                    Price = _random.Next(200),
                    Stock = _random.Next(1000),
                    Image = "www.example.image.path"
                };
            }
        }
    }
}