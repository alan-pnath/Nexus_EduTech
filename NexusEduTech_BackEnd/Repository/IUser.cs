using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Models;

namespace NexusEduTech_BackEnd.Repository
{
    public interface IUser
    {
        void AddUser(User user);
        void Update(User user);
        void Delete(User user);
        List<User> GetAll();
    }
}
