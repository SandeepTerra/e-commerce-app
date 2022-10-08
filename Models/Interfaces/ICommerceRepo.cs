using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace e_commerce_app.Models.Interfaces
{

    public interface ICommerceRepo
    {
        Task<HttpStatusCode> CreateProduct(Product product);

        Task<Product> GetProductById(int? id);

        Task<List<Product>> GetProducts();

        Task<Product> UpdateProduct(int id, Product product);

        Task<HttpStatusCode> DeleteProduct(int id);
    }
}
