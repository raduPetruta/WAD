namespace wad_backend.Models
{
    public class UserModel
    {
        public int id{ get; set; }
        public required string username { get; set; }
        public required string password { get; set; }
        public required string email { get; set; }
        public string? biography { get; set; }
        public string? age { get; set;} 
    }
}
