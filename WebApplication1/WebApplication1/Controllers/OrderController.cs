using ApiWeb.IServices;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Security.Authentication;

namespace ApiWeb.Controllers
{
    [ApiController]
    [Route("[controller] /[action]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        private readonly IOrderService _orderService;
        public OrderController(ILogger<OrderController> logger, IOrderService orderService)
        {
            _logger = logger;
            _orderService = orderService;
        }

        [HttpPost(Name = "InsertOrder")]
        public int Post([FromBody] OrderItem orderItem)
        {
            return _orderService.InsertOrder(orderItem);
        }

        [HttpGet(Name = "GetAllOrders")]
        public List<OrderItem> GetAll()
        {
            return _orderService.GetAllOrders();
        }

        [HttpPatch(Name = "ModifyOrder")]
        public void Patch([FromBody] OrderItem orderItem)
        {
            _orderService.UpdateOrder(orderItem);

        }
        [HttpDelete(Name = "DeleteOrder")]
        public void Delete([FromQuery] int id)
        {
            _orderService.DeleteOrder(id);

        }

    }
}