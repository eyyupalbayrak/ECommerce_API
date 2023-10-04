using ECommerce_API.DateContext;
using ECommerce_API.Services.Abstract;
using Entities;

namespace ECommerce_API.Services.Concrete
{
    public class AuthService : IAuthService
    {
        private readonly AplicatioonDbContext _context;
        private readonly IConfiguration _config;
        private readonly IHttpContextAccessor _contextAccessor;

        public AuthService(AplicatioonDbContext context, IConfiguration config, IHttpContextAccessor contextAccessor,)
        {
            _context = context;
            _config = config;
            _contextAccessor = contextAccessor;       
        }

        public Task<ServiceResponse<bool>> ChangePassword(int userId, string oldPassword, string newPassword, string confirmPassword)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<bool>> DeleteAccount(string password)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public string GetUserEmail()
        {
            throw new NotImplementedException();
        }

        public int GetUserId()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<string>> Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<int>> Register(User user, string password)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<bool>> RoleForAdmin(string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserExist(string email)
        {
            throw new NotImplementedException();
        }
    }
}
