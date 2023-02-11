using ApiWeb.IServices;
using Entities.Entities;
using Logic.ILogic;
using Data;

namespace ApiWeb.Service
{
    public class SecurityService : ISecurityService
    {
        private readonly ISecurityLogic _securityLogic;
        public SecurityService(ServiceContext serviceContext, ISecurityLogic securityLogic)
        {
            
            _securityLogic = securityLogic;
        }
        public bool ValidateUserCredentials(string userName, string userPassWord, int idRol)
        {
            return _securityLogic.ValidateUserCredentials(userName, userPassWord, idRol);
        }
    }
}
