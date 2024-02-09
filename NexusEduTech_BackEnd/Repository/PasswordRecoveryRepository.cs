using Microsoft.AspNetCore.Http.HttpResults;
using NexusEduTech_BackEnd.Models;

namespace NexusEduTech_BackEnd.Repository
{
    public class PasswordRecoveryRepository:IPasswordRecovery
    {
        private readonly MyContext _context;

        public PasswordRecoveryRepository(MyContext context)
        {
            _context = context;
        }

        public string verify(string email, string newpass, string Confirmpass)
        {
            try
            { 
                var u=_context.Users.Where(u=>u.Email == email).FirstOrDefault();
                if (u!= null)
                {
                    if(newpass==Confirmpass)
                    {
                        u.Password = newpass;
                        _context.Users.Update(u);
                        _context.SaveChanges();
                    }
                    else
                    {
                        return ("not same password");
                    }
                }
                else
                {
                    return ("Invalid mail id");
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
