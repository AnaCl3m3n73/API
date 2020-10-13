using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_API.Model;


namespace Projeto_API.Services
{
    public interface IProductsService
    {
         List<Product> GetProducts();

         Product AddProduct(Product productItem);

         Product UpdateProduct(string id, Product productItem);

         string DeleteProduct(string id);
    }
}
