using byteBank.Titular;

namespace byteBank.Desafio
{
    public class Pedido
    {
        public decimal Id { get; set; }
        public Cliente Cliente { get; set; }
        public ItemPedido item;
        public Produto Produto { get; set; }
        public double ValorTotal { get; set; }
        public int NumeroItens { get; set; }
    }
}
