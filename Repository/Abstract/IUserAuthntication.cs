using Online__Store_Movies.Models.DTO;

namespace Online__Store_Movies.Repository.Abstract
{
    public interface IUserAuthntication
    {
        public Task<Status> LoginAsync(LoginModel model);
        public Task<Status> RegisterAsync(RegistrationModel model);
        public Task LogoutAsync();

    }
}
