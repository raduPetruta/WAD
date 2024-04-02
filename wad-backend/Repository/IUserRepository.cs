using Microsoft.AspNetCore.Mvc;
using wad_backend.Models;

namespace wad_backend.Repository
{
    public interface IUserRepository
    {
        public Task<List<UserModel>> getAllUsersAsync();
        public Task<UserModel> getUserById(int id);
    }
}
