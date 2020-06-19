using System;

namespace Aula20SENAIfood
{
    class Program
    {
        static void Main(string[] args)
        { 
            Restaurante Mc = new Restaurante();
            Cliente clie = new Cliente();
            Pedido ped = new Pedido();

            Mc.Endereco = "Rua das flores, 178, Bairro Juquia";
            
            System.Console.WriteLine("\nSeja bem vindo ao nosso App, o que deseja comprar?");
            ped.Itens = Console.ReadLine();

            System.Console.WriteLine("\nVoce quer fazer esse pedido para qual restaurante?");
            Mc.Nome = Console.ReadLine();

            System.Console.WriteLine("\nPor favor ensira, seu nome:");
            clie.Nome = Console.ReadLine();

            System.Console.WriteLine("\nAgora ensira seu endereço:");
            clie.EnderecoAtual = Console.ReadLine();

            System.Console.WriteLine("\n-----------------");
            System.Console.WriteLine($"\nPedido de: {ped.Itens}");
            System.Console.WriteLine($"\nPelo o cliente: \n{clie.Nome} \n\nNo endereço: \n{clie.EnderecoAtual}");
            System.Console.WriteLine($"\nPara o restaurante: \n{Mc.Nome} \n\nDo endereço: \n{Mc.Endereco}");
            

            
            

        }
    }
}
