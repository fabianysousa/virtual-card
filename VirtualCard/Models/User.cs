using System.ComponentModel.DataAnnotations;

namespace VirtualCard.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Email { get; set; }

    }
}
