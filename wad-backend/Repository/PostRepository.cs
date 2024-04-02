using Microsoft.EntityFrameworkCore;
using wad_backend.Context;
using wad_backend.Models;

namespace wad_backend.Repository
{
    public class PostRepository: IPostRepository
    {
        private readonly SocialMediaContext _context;

        public PostRepository(SocialMediaContext context)
        {
            this._context = context;
        }

        public async Task<List<PostModel>> getAllPosts()
        {
            var posts = await _context.Posts.Select(x => new PostModel()
            {
                id = x.id,
                content = x.content,
            }).ToListAsync();
            return posts;
        }
        public async Task<PostModel> getPostById(int id)
        {
            return await _context.Posts.FirstOrDefaultAsync(u => u.id == id);
        }
    }
}
