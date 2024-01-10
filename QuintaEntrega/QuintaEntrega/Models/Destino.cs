using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuintaEntrega.Models
{
    [Table("Destino")]
    public class Destino
    {
        [Key]
        public int Id { get; set; }
        [StringLength(30)]
        public String Nome { get; set; }
        [StringLength(30)]
        public String Pais { get; set; }

        [StringLength(30)]

        public String Estado { get; set; }
        [StringLength(30)]
        public String Cidade { get; set; }
        [StringLength(10)]
        public String Valor { get; set; }
        [StringLength(500)]
        public String Img { get; set; }
    }
}
