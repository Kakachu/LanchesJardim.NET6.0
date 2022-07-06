using LanchesJardim.NET6.Models;

namespace LanchesJardim.NET6.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
