using System.ComponentModel.DataAnnotations;

namespace MoveisPlanejados.Models
{
    public class Movel
    {
      [Key]
        public int Id_Movel { get; set; }
        [Required(ErrorMessage="O nome do cliente é obrigatório",AllowEmptyStrings=false)]       
        public string Nome_Cliente { get; set; }
        [Required(ErrorMessage="O nome do movel é obrigatório",AllowEmptyStrings=false)]         
        public string Nome_Movel { get; set; }
        [Required(ErrorMessage="A cor do movel é obrigatório",AllowEmptyStrings=false)]         
        public string Cor_Movel { get; set; }
        [Required(ErrorMessage="A medida do movel é obrigatório",AllowEmptyStrings=false)]         
        public string Medidas_Movel { get; set; }
        [Required(ErrorMessage="O material do movel é obrigatório",AllowEmptyStrings=false)]         
        public string Material_Movel { get; set; }        
        public double Valor_Movel { get; set; }
        [Required(ErrorMessage="A imagem do movel é obrigatório",AllowEmptyStrings=false)]         
        public string Imagem_Movel { get; set; }
        public string Status_Movel { get; set; }
        public int FuncionarioId { get; set; }

        public virtual Funcionario Funcionario { get; set; }

    }
}