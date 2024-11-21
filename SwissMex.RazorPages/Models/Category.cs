using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SwissMex.RazorPages.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Escriba un valor para el Nombre")]
        [Display(Name = "Nombre")]
        public required string Name { get; set; }


        [Range(1, 75, ErrorMessage = "El valor debe estar entre {1} y {2}")]
        [DisplayName("Prioridad")]
        //[Required(ErrorMessage = "Escriba un valor para la Prioridad")]
        public int DisplayOrder { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
