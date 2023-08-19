using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Category Name")]
        [MaxLength(30)]
        public string Name { get; set; } = null!;

        [DisplayName("Display Order")]
        [Range(0, 100, ErrorMessage = "Display order must be between 1 - 100")]
        public int DisplayOrder { get; set; }
    }
}
