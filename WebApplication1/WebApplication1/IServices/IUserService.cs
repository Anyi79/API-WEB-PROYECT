using Entities.Entities;

namespace ApiWeb.IServices
{
    public interface IUserService
    {
        int InsertUser(UserItem userItem);
        List<UserItem> GetAllUsers();
        void UpdateUser(UserItem userItem);
        void DeleteUser(int id);
    }
}