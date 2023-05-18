using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Challenge_idwall.Model
{
    [Table("TABLE_NACIONALIDADE")]
    public class NacionalidadeModel
    {
        [Key]
        [Required]
        [Column("Pais")]

        public int Pais { get; set; }


        [Column("Estado")]
        [Required]

        public string Estado { get; set; }


        [Column("Cidade")]
        public string Cidade { get; set; }



    }
}
