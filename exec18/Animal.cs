using System;
namespace exec18
{
    public class Animal
    {

        public Animal(string tipo_Animal, string nome_Animal, string raca_Animal, int meses_Animal, bool vacinado, Pessoa id_Dono)
        {
            this.Tipo_Animal = tipo_Animal;
            this.Nome_Animal = nome_Animal;
            this.Raca_Animal = raca_Animal;
            this.Meses_Animal = meses_Animal;
            this.Vacinado = vacinado;
            this.Id_Dono = id_Dono;

        }
        public string Tipo_Animal { get; set; }
        public string Nome_Animal { get; set; }
        public string Raca_Animal { get; set; }
        public int Meses_Animal { get; set; }
        public bool Vacinado { get; set; }
        public Pessoa Id_Dono { get; set; }







    }
}