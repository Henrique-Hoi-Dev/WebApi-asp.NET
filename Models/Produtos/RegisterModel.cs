using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Produtos
{
    public class RegisterModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Categoria { get; set; }
        [Required]
        public string Altura { get; set; }
        [Required]
        public string Largura { get; set; }
        [Required]
        public string Comprimento { get; set; }
        [Required]
        public string CodigoBarras { get; set; }
        [Required]
        public string Peso { get; set; }
        [Required]
        public string Preco { get; set; }
        [Required]
        public string Descricao { get; set; }
        public string DiaSemana { get; set; }
        public string Horario { get; set; }
    }
}
