using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace Chocolateria.Models
{
    public class Chocolate // Ou Chocolate DB <Chocolate>
    {
        [Key] //  [Key] ?
        public int id_Chocolate { get; set; }
    	public double Valor_Chocolate { get; set; }
        public int Quantidade_Disponivel { get; set; }
        public double Peso_Chocolate { get; set; }
        [Required(ErrorMessage="O nome da marca é obrigatório",AllowEmptyStrings=false)] 
        public string Marca_Chocolate { get; set; }
        public double Porcentagem_Cacau { get; set; }
        [Required(ErrorMessage="O tipo do chocolate é obrigatório",AllowEmptyStrings=false)] 
        public string Tipo_Chocolate { get; set; }
        public DateTime Data_Validade { get; set; }
        [Range(5.0, 15.0, ErrorMessage= "O cupom deve estar ser 5, 10 ou 15")]
        public double Cupom_Desconto { get; set; }
        public double Valor_Com_Cupom { get; set; }                        
        
        
    }
}