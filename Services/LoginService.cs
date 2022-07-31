using SkillTest.Interfaces;
using SkillTest.Repository;

namespace SkillTest.Services
{
    public class LoginService : ILoginService
    {
        private readonly SkillTestContext _dbContext;
        public LoginService(SkillTestContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Login(string username, string password)
        {
            return _dbContext.Users.Any(user => user.Equals(username) && user.Equals(password));
        }
    }
}
