using ApiWeb.IServices;
using Data;
using Entities;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.Collections.Specialized;
using System.Security.Authentication;


namespace ApiWeb.Controllers
{
    [ApiController]
    [Route("[controller] /[action]")]
    public class ProductController : ControllerBase
    {
        private readonly ISecurityService _securityService;
        private readonly IProductService _productService;
        private readonly IUserService _userService;
        private readonly ServiceContext _serviceContext;

        public ProductController(ISecurityService securityService, IProductService productService, IUserService userService, ServiceContext serviceContext)
        {
            _productService = productService;
            _securityService = securityService;
            _userService = userService;
            _serviceContext = serviceContext;
        }

        [HttpPost(Name = "InsertProduct")]
        public int Post([FromHeader] string userName, [FromHeader] string userPassword, [FromBody] ProductItem productItem)
        {
            var validCredentials = _securityService.ValidateUserCredentials(userName, userPassword, 1);
            if (validCredentials == true)
            {
                return _productService.InsertProduct(productItem);
            }
            else
            {
                throw new InvalidCredentialException();
            }
        }

        [HttpGet(Name = "GetAllProducts")]
        public List<ProductItem> GetAll()
        {
            return _productService.GetAllProducts();
        }

        [HttpGet(Name = "GetProductsByCriteria")]
        public List<ProductItem> GetProductByCriteria([FromQuery] string Brand)
        {

            return _productService.GetProductByCriteria(Brand);
        }

        [HttpPatch(Name = "ModifyProduct")]
        public void Patch([FromHeader] string userName, [FromHeader] string userPassword, [FromBody] ProductItem productItem)
        {
            var validCredentials = _securityService.ValidateUserCredentials(userName, userPassword, 1);
            if (validCredentials == true)
            {
                _productService.UpdateProduct(productItem);
            }
            else
            {
                throw new InvalidCredentialException();
            }

        }
        [HttpDelete(Name = "DeleteProduct")]
        public void Delete([FromHeader] string userName, [FromHeader] string userPassword, [FromQuery] int id)
        {
                var validCredentials = _securityService.ValidateUserCredentials(userName, userPassword, 1);
                if (validCredentials == true)
            { 
                _productService.DeleteProduct(id);
            }
            else
            {
                throw new InvalidCredentialException();
            }

        }

    }
}
