using LanchesJardim.NET6.Models;

namespace LanchesJardim.NET6.Repositories.Interfaces
{
    public interface IPedidoRepository
    {
        void CriarPedido(Pedido pedido);
    }
}
