using UsersAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsersAPI.Repository
{
    public interface IUserRepo
    {
        IEnumerable<UserServiceInfo> GetAllUsers();

        UserServiceInfo GetUserServiceInfoById(string id);
        UserServiceInfo GetUserServiceInfoByUserName(string Username);
        UserServiceInfo GetUserServiceInfoByAadhaar(string Aadhaar);
        Task<UserServiceInfo> PostUser(UserServiceInfo item);
        Task<UserServiceInfo> RemoveUser(string id);
        Task<UserServiceInfo> EditUser(string id, UserServiceInfo item);
        //object GetUserServiceInfoById(string id);
    }
}
