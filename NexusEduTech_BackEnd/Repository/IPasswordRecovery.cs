using ActiveUp.Net.Mail;

namespace NexusEduTech_BackEnd.Repository
{
    public interface IPasswordRecovery
    {
        public string verify(string email, string newpass, string Confirmpass);

    }
}
