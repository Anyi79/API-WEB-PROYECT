using Entities.Entities;

namespace ApiWeb.IServices
{
    public interface IProductService
    {
        List<ProductItem> GetAllProducts();
        List<ProductItem> GetProductByCriteria(string Brand);
        int InsertProduct(ProductItem productItem);
        void UpdateProduct(ProductItem productItem);
        void DeleteProduct(int id);
    }
}