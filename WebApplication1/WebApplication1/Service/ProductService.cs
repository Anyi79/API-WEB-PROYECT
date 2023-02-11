using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;
using ApiWeb.IServices;

namespace ApiWeb.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductLogic _productLogic;
        public ProductService(IProductLogic productLogic)
        {
            _productLogic = productLogic;
        }
        public int InsertProduct(ProductItem productItem)
        {
            _productLogic.InsertProductItem(productItem);
            return productItem.Id;
        }
        public List<ProductItem> GetAllProducts()
        {
            return _productLogic.GetAllProducts();
        }

        List<ProductItem> IProductService.GetProductByCriteria(string ProductBrand)
        {
            return _productLogic.GetProductByCriteria(ProductBrand);
        }

        public void UpdateProduct(ProductItem productItem)
        {
            _productLogic.UpdateProductItem(productItem);
        }

        public void DeleteProduct(int id)
        {
            _productLogic.DeleteProductItem(id);
        }
    }
}
