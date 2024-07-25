using Microsoft.Extensions.Hosting;

namespace DefaultTechnique.Data.OneToMany
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
