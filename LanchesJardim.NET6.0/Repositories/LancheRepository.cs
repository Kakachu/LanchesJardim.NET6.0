using LanchesJardim.NET6._0.context;
using LanchesJardim.NET6._0.Models;
using LanchesJardim.NET6._0.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LanchesJardim.NET6._0.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categorias);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches
                                                                .Where(l => l.IsLanchePreferido)
                                                                .Include(c => c.Categorias);

        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
        }
    }
}
