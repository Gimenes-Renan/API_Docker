using System.ComponentModel.DataAnnotations;

namespace API_Docker.Models
{
    public class CategoryInput
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Descricao { get; set; }

        public double Valor { get; set; }

    }
}