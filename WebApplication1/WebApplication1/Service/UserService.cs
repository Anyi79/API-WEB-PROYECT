using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;
using ApiWeb.IServices;

namespace ApiWeb.Services
{
    public class UserService : IUserService
    {
        private readonly IUserLogic _userLogic;
        public UserService(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }
        public int InsertUser(UserItem userItem)
        {
            _userLogic.InsertUserItem(userItem);
            return userItem.Id;
        }
        public List<UserItem> GetAllUsers()
        {
            return _userLogic.GetAllUsers();
        }
        public void UpdateUser(UserItem userItem)
        {
            _userLogic.UpdateUserItem(userItem);
        }
        public void DeleteUser(int id)
        {
            _userLogic.DeleteUserItem(id);
        }
    }
}
