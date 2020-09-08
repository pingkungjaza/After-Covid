using Microsoft.AspNetCore.Http;
using newbackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newbackend.Services
{
    public interface IProductRepository
    {
        IEnumerable<Products> GetProducts();
        Products GetProduct(int id);
        void AddProduct(Products product, IFormFile image);
        void EditProduct(Products product, IFormFile image);
        void DeleteProduct(Products product);

    }
}
