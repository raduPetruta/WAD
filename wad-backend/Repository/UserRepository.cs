using Microsoft.EntityFrameworkCore;
using wad_backend.Context;
using wad_backend.Models;

namespace wad_backend.Repository
{
    public class UserRepository: IUserRepository
    {
        private readonly SocialMediaContext _context;

        public UserRepository(SocialMediaContext context) 
        {
            this._context = context;
        }

        public async Task<List<UserModel>> getAllUsersAsync()
        {
            var users = await _context.Users.Select(x => new UserModel()
            {
                id = x.id,
                username = x.username,
                password = x.password,
                email = x.email,
                biography = x.biography,
                age = x.age
            }).ToListAsync();

            return users;
        }

        public async Task<UserModel> getUserById(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.id == id);
        }
    }
}
