using System.ComponentModel.DataAnnotations;

namespace SwissMex.Web.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; } // = null! or string.empty
        public int DisplayOrder { get; set; }
    }
}
