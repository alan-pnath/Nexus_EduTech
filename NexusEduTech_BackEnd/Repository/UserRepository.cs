using Microsoft.AspNetCore.Http.HttpResults;
using NexusEduTech_BackEnd.Models;

namespace NexusEduTech_BackEnd.Repository
{
    public class UserRepository : IUser
    {
        private readonly MyContext _context;

        public UserRepository(MyContext context)
        {
            _context = context;
        }
        public void AddUser(User user) //SignUp
        {
            try
            {
                /* _context.Users.Add(user);
                 _context.SaveChanges();*/
               var studid = from s in _context.Students where s.StudentId == user.Id
                            select s.StudentId;
                var teachid = from t in _context.Teachers
                             where t.TeacherId == user.Id
                             select t.TeacherId;

                var username = from u in _context.Users where user.UserName == u.UserName
                               select u.UserName;
                if(username == null)
                {
                    if (studid != null && user.Role == "Student")
                    {
                        _context.Users.Add(user);
                        _context.SaveChanges();
                    }
                    else if (teachid != null && user.Role == "Teacher")
                    {
                        _context.Users.Add(user);
                        _context.SaveChanges();
                    }
                }
                
            }
            catch (Exception)
            {

                throw;
            }
   
        }

        public void Delete(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList(); 
        }

        public void Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public User validate(LoginUser loginUser)
        {
            return _context.Users.SingleOrDefault(u => u.UserName == loginUser.Username && u.Password == loginUser.Password);
        }
        /*public void UpdatePassword (string username, string old_password, string new_password)
        {
            var s = _context.Users.Find(username);
            if (s != null)
            {
                if (s.Password == old_password )
                {
                    s.Password = new_password;
                    _context.SaveChanges();
                }
            }
        }*/
    }
}
