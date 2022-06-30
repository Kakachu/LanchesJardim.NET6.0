using LanchesJardim.NET6._0.Models;

namespace LanchesJardim.NET6._0.ViewModels
{
    public class LancheListViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
