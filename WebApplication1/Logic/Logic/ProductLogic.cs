using Data;
using Entities.Entities;
using Logic.ILogic;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class ProductLogic : BaseContextLogic, IProductLogic
    {
        public ProductLogic(ServiceContext serviceContext) : base(serviceContext) { }

        public List<ProductItem> GetAllProducts()
        {
            return _serviceContext.Set<ProductItem>().ToList();
        }

        public List<ProductItem> GetProductByCriteria(string Brand)
        {
            var brandFilter = new ProductItem();
            brandFilter.Brand = Brand;

            var resultList = _serviceContext.Set<ProductItem>()
                                .Where(p => p.Brand == Brand);

            if (brandFilter.Brand == Brand)
            {
                resultList = resultList.Where(p => p.Brand == Brand);
            }


            return resultList.ToList();
        }
        public int InsertProductItem(ProductItem productItem)
        {
            _serviceContext.Products.Add(productItem);
            _serviceContext.SaveChanges();
            return productItem.Id;
        }
        public void UpdateProductItem(ProductItem productItem)
        {
            _serviceContext.Products.Update(productItem);
            _serviceContext.SaveChanges();
        }

        public void DeleteProductItem(int id)
        {
            var productToDelete = _serviceContext.Set<ProductItem>()
            .Where(u => u.Id == id).First();
            productToDelete.IsActive = false;
            _serviceContext.SaveChanges();
        }
    }
}

