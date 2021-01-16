using EntityFrameWorkCore.Context;
using EntityFrameWorkCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameWorkCore.Interface
{
    public interface IProductRepository
    {
        Product GetById(int productid);
        IQueryable<Product> Products { get; }
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int productid);

    }
}  
