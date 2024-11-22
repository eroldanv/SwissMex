using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SwissMex.Models.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El Nombre no puede dejarse en blanco")]
        [DisplayName("Nombre")]        
        [MaxLength(50, ErrorMessage = "El Nombre no puede tener más de {1} caracteres")]
        public required string Name { get; set; } // = null! or string.empty
        
        [Display(Name = "Prioridad")]
        [Range(1, 75, ErrorMessage = "El valor de Prioridad debe estar entre {1} y {2}")]
        [Required(ErrorMessage = "Ingrese un valor para la Prioridad" )]
        public int? DisplayOrder { get; set; }

    }
}
