using LanchesJardim.NET6._0.Models;

namespace LanchesJardim.NET6._0.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
