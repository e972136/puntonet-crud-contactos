using System.ComponentModel.DataAnnotations;

namespace puntoNet.Models
{
    public class ContactoModel
    {
        public int IdContacto { get; set; }

        [Required]
        public string? Nombre { get; set; }

        [Required]
        public string? Telefono { get; set; }

        [Required]
        public string? Correo { get; set; }
    }
}
