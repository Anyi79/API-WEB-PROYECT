using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;
using ApiWeb.IServices;

namespace ApiWeb.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderLogic _orderLogic;
        public OrderService(IOrderLogic orderLogic)
        {
            _orderLogic = orderLogic;
        }
        public int InsertOrder(OrderItem orderItem)
        {
            _orderLogic.InsertOrderItem(orderItem);
            return orderItem.Id;
        }
        public List<OrderItem> GetAllOrders()
        {
            return _orderLogic.GetAllOrders();
        }
        public void UpdateOrder(OrderItem orderItem)
        {
            _orderLogic.UpdateOrderItem(orderItem);
        }
        public void DeleteOrder(int id)
        {
            _orderLogic.DeleteOrderItem(id);
        }
    }
}
