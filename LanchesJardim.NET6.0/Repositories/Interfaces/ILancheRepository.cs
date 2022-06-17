using LanchesJardim.NET6._0.Models;

namespace LanchesJardim.NET6._0.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }
        Lanche GetLancheById(int lancheId);


    }
}
