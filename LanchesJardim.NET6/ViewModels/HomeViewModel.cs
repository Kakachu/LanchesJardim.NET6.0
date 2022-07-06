using LanchesJardim.NET6.Models;

namespace LanchesJardim.NET6.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Lanche> LanchesPreferidos { get; set; }
    }
}
