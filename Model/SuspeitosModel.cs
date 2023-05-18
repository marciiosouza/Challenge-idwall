using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Challenge_idwall.Model
{
    [Table("TABLE_SUSPEITOS")]
    public class SuspeitosModel
    {
        [Key]
        [Required]
        [Column("SuspeitoId")]
        
        public int SuspeitoId { get; set; }
        [Column("SuspeitoName")]
        [Required]
        
        public string SuspeitoName { get; set; }
        
        [Column("DataNacimento")]
        public DateTime DataNascimento { get; set; }

        [Column("Sexo")]
        public char Sexo { get; set; }
        

    }
}
