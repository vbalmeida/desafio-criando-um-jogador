using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_criando_um_jogador.Models
{
class Jogador
{
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }
    public int Idade { get; set; }
    public string Posicao { get; set; }
    public void Novo()
    {
      Nome = Console.ReadLine();
      Nacionalidade = Console.ReadLine();
      Idade = Convert.ToInt32(Console.ReadLine());
      Posicao = Console.ReadLine();
      
      Console.WriteLine($"Jogador criado!");
      Console.WriteLine(Nome);
      Console.WriteLine(Nacionalidade);
      Console.WriteLine(Idade);
      Console.WriteLine($"Posição: {Posicao}");

    }
}

class Program
{
    static void Main()
    {
      Jogador jg1 = new Jogador();
      jg1.Novo();
        
    }
}
}