using System;

namespace exec18
{
    public class Cachorro : Animal
    {
        public Cachorro(string tipo_Animal, string nome_Animal, string raca_Animal, int meses_Animal, bool vacinado, Pessoa id_Dono, int tamanho_Cachorro) : base (tipo_Animal, nome_Animal, raca_Animal, meses_Animal, vacinado, id_Dono)
        {
            this.Tamanho_Cachorro = tamanho_Cachorro;

        }
        public int Tamanho_Cachorro { get; set; }

    }
}