namespace MappingUsingDataAnnotations.Data.OneToOne
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }

        // Navigation property
        public UserProfile UserProfile { get; set; }
    }
}
