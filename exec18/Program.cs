using System;
using System.Collections.Generic;

namespace exec18
{
    class Program
    {
        static void Main(string[] args)
        {               string pp;

            Console.WriteLine("Hello World!");       
            Pessoa p = new Pessoa(0, "Nome_Pessoa", 0, "Endereco Dono");
            Gato g = new Gato("0", "nome_Animal", "raca_Animal", 0, false, p);
            Cachorro c = new Cachorro("0", "nome_Animal", "raca_Animal", 0, false, p, 1);

            Pessoa p2 = new Pessoa(0, "Joao ", 0, "Rua 01");   
            Pessoa usuario1 = new Pessoa(0, "Usuario 1", 0, "Endereco Usuario");  
            Gato g1 = new Gato("Gato", "nome_Animal", "albino", 1, false, usuario1);
            Gato g2 = new Gato("Gato", "nome_Animal", "siames", 5, false, p);
            Gato g3 = new Gato("Gato", "nome_Animal", "polones", 12, false, usuario1);
            Gato g4 = new Gato("Gato", "nome_Animal", "gelada", 15, false, p2);  
            Cachorro c1 = new Cachorro("Cachorro", "Auau 1", "raca_Animal", 0, false, usuario1, 1);
            Cachorro c2 = new Cachorro("Cachorro", "Cerelepepe", "breja", 7, false, p2, 1);
            Cachorro c3 = new Cachorro("Cachorro", "Ramirez", "viralatao", 15, false, p, 1);
            Cachorro c4 = new Cachorro("Cachorro", "Kyen", "vira latinha", 23, false, usuario1, 1);
            Cachorro c5 = new Cachorro("Cachorro", "Cinco Cachoroo", " mistura ", 3, false, p2, 1);  
                                        
                 Pessoa usuario = new Pessoa(0, "Usuario 1", 0, "Endereco Usuario");    usuario1.ExibirUsuario();     pp = usuario1.MostrarUsuario(); Console.WriteLine(pp);         

            List<Gato> gato = new List<Gato>();
            List<Cachorro> cachorro = new List<Cachorro>();              
            gato.Add(g); gato.Add(g1); gato.Add(g2); gato.Add(g3); gato.Add(g4);
            cachorro.Add(c); cachorro.Add(c1); cachorro.Add(c2); cachorro.Add(c3); cachorro.Add(c4); cachorro.Add(c5);
     

           foreach (Gato gatins  in gato)
                {
                Console.WriteLine("****************************************"); 
                Console.WriteLine("\n Tipo Animal: "  + gatins.Tipo_Animal  + "\n Nome Animal: " + gatins.Nome_Animal + "\n Raca Animal: " + gatins.Raca_Animal + "\n Meses Animal: " + gatins.Meses_Animal + "\n Animal Vacinado: " + gatins.Vacinado + "\n Dono Animal: " + gatins.Id_Dono.Nome_Pessoa);  
                }
            foreach (Cachorro cachorrins  in cachorro)
                {
                Console.WriteLine("****************************************");   
                Console.WriteLine("\n Tipo Animal: "  + cachorrins.Tipo_Animal  + "\n Nome Animal: " + cachorrins.Nome_Animal + "\n Raca Animal: " + cachorrins.Raca_Animal + "\n Meses Animal: " + cachorrins.Meses_Animal + "\n Animal Vacinado: " + cachorrins.Vacinado + "\n Dono Animal: " + cachorrins.Id_Dono.Nome_Pessoa + "\n Tamanho Cachorro: " +  cachorrins.Tamanho_Cachorro);                    
                }                           


                //  List<Animal> animais = new List<Animal>();
                //  animais.AddRange(gato);
                //  animais.AddRange(cachorro);   
                //  foreach (Animal petshop_animais in animais)
                //  {
                //  Console.WriteLine("****************************************");     
                //  Console.WriteLine("\n Tipo Animal: "  + petshop_animais.Tipo_Animal  + "\n Nome Animal: " + petshop_animais.Nome_Animal + "\n Dono Animal: " + petshop_animais.Id_Dono.Nome_Pessoa + "\n Endereço Dono: " + petshop_animais.Id_Dono.Endereco_Pessoa);                    
                    
                //  }   
        // Funcao Cadastrar & condicao tipo animal

        }
    }
}
