using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Curriculos.Models
{
    public class Curriculo
    {
        [Key]
        public int Id_Curriculo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        [Column("pretensao_salarial")]
        public decimal PretensaoSalarial { get; set; }
        [Column("objetivo_profissional")]
        public string ObjetivoProfissional { get; set; }

    }
}