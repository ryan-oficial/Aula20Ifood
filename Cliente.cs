using System;

namespace Aula20SENAIfood
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string EnderecoAtual { get; set; }

        public string MostrarDados(){
            return $"Nome do cliente: {Nome}. \nEndereço atual do cliente: {EnderecoAtual}.";
        }
    }
}