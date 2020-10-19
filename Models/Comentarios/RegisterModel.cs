using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Comentarios
{
    public class RegisterModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Descricao { get; set; }
        
    }
}
