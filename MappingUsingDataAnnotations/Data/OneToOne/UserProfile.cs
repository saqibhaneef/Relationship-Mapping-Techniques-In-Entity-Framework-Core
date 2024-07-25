using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MappingUsingDataAnnotations.Data.OneToOne
{
    public class UserProfile
    {
        [Key, ForeignKey("User")]
        public int UserId { get; set; }
        public string Bio { get; set; }

        // Navigation property
        public User User { get; set; }
    }
}
