using System.ComponentModel.DataAnnotations.Schema;

namespace MappingUsingDataAnnotations.Data.OneToMany
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        // Foreign key
        public int CategoryId { get; set; }

        // Navigation property
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
