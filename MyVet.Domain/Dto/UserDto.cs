using System.ComponentModel.DataAnnotations;

namespace MyVet.Domain.Dto
{
    public class UserDto
    {
        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(100)]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        public string UserName { get; set; }
     



       

        public string Rol { get; set; }

        
    }
}