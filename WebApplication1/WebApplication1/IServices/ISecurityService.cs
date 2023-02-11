namespace ApiWeb.IServices
{
    public interface ISecurityService
    {
        bool ValidateUserCredentials(string userName, string userPassWord, int idRol);
    }
}
