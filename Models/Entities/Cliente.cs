using System.ComponentModel.DataAnnotations;

namespace CRUDProyect.Models.Entities
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]

        public string Nombre { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Telefono { get; set; } 

    }
}
