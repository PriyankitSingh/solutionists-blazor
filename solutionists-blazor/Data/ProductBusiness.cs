using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solutionists_blazor.Data
{
    public interface IProductBusiness
    {
        Task<Product[]> GetAllProducts();
    }

    public class ProductBusiness : IProductBusiness
    {
        private readonly IProductProvider _productProvider;

        public ProductBusiness(IProductProvider productProvider)
        {
            _productProvider = productProvider;
        }

        public Task<Product[]> GetAllProducts()
        {
            return Task.FromResult(_productProvider.GetAllProducts().ToArray());
        }
    }
}