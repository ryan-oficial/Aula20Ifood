namespace Aula20SENAIfood
{
    public class Restaurante
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public string MostrarDados(){
            return $"Nome do restaurante: {Nome}. \nEndereço: {Endereco}.";
        }
    }
}