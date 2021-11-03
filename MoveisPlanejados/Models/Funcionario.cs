using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
namespace MoveisPlanejados.Models

{
    public class Funcionario
    {
      
        public int FuncionarioId { get; set; }
        [Required(ErrorMessage="O nome do Funcionario é obrigatório",AllowEmptyStrings=false)]          
        public string Nome_Funcionario { get; set; }
        public string Status_Funcionario { get; set; }

        public virtual ICollection<Movel> Moveis { get; set; }
    }
}