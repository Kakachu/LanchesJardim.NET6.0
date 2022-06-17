﻿using LanchesJardim.NET6._0.context;
using LanchesJardim.NET6._0.Interfaces;
using LanchesJardim.NET6._0.Models;

namespace LanchesJardim.NET6._0.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
