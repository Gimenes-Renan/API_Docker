using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Docker.Models
{
    [Table("categorias")]
    public class Category
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("data")]
        public DateTime? DataCriacao { get; set; }

        [Column("expiracao")]
        public DateTime? DataExpiracao { get; set; }
    }
}
