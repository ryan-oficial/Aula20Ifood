namespace Aula20SENAIfood
{
    public class Pedido
    {
        public string Itens { get; set; }
        public Cliente Cliente { get; set; }
        public Restaurante Restaurante { get; set; }
        public string FormaDePGTO { get; set; }
        public bool PedidoPago { get; set; }
        // public DateTime Horario { get; set; }
        public string EscolherRest { get; set; }
       

        // public string EntregarPedido(){
            
        //     string retorno = "Pedido entregue para:";
            

        //     return retorno;
        // }

        


    }
}