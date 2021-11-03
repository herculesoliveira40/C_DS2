using System;
namespace exec18
{
    public class Pessoa
    {

        public Pessoa(int id_Pessoa, string nome_Pessoa, int idade, string endereco_Pessoa)
        {
            this.Id_Pessoa = id_Pessoa;
            this.Nome_Pessoa = nome_Pessoa;
            this.Idade = idade;
            this.Endereco_Pessoa = endereco_Pessoa;

        }
        
        public int Id_Pessoa { get; set; }
        public string Nome_Pessoa { get; set; }
        public int Idade { get; set; }
        public string Endereco_Pessoa { get; set; }





                public void ExibirUsuario(){
                Console.WriteLine("Nome Usuario: " + this.Nome_Pessoa);
                    
                }
                public string MostrarUsuario(){
                return ("Nome Usuario: " + this.Nome_Pessoa);
                    
                }


    }
}