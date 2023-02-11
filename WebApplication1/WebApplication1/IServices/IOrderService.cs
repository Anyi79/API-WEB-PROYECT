using Entities.Entities;

namespace ApiWeb.IServices
{
    public interface IOrderService
    {
        List<OrderItem> GetAllOrders();
        int InsertOrder(OrderItem orderItem);
        void UpdateOrder(OrderItem orderItem);
        void DeleteOrder(int id);
    }
}