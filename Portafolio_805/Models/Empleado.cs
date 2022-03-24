using System.ComponentModel.DataAnnotations;

namespace Portafolio_805.Models
{
    public class Empleado
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Cedula es obligatorio")]
        public int Cedula { get; set; }


        [Required(ErrorMessage = "El campo de Nombre Completo es obligatorio")]
        public string NombreC { get; set; }

        [Required(ErrorMessage = "El campo Telefono es obligatorio")]
        public string Telefono { get; set; }


        [Required(ErrorMessage = "El campo Email es obligatorio")]
        public string Email { get; set; }


        [Required(ErrorMessage = "El campo Estado es obligatorio")]
        public int Estado { get; set; }

    }
}
