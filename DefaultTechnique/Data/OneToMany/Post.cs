namespace DefaultTechnique.Data.OneToMany
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int BlogId { get; set; } // Foreign key
        public Blog Blog { get; set; }
    }
}
