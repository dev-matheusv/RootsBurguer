using RootsBurguer.Context;
using RootsBurguer.Models;
using RootsBurguer.Repositories.Interfaces;

namespace RootsBurguer.Repositories
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
