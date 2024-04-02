using wad_backend.Models;

namespace wad_backend.Repository
{
    public interface IPostRepository
    {
        public Task<List<PostModel>> getAllPosts();
        public Task<PostModel> getPostById(int id);
    }
}
