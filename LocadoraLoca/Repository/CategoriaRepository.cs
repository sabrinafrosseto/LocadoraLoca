using LocadoraLoca.Entity;
using LocadoraLoca.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraLoca.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly LocadoraContext _locadoraContext;

        public CategoriaRepository(LocadoraContext locadoraContext)
        {
            _locadoraContext = locadoraContext;
        }

        public async Task<int> CreateAsync(Categoria categoria)
        {
            _locadoraContext.Categorias.Add(categoria);

            await _locadoraContext.SaveChangesAsync();

            return categoria.IdCategoria;
        }

        public async Task<List<Categoria>> FindAllAsync()
        {
            return await _locadoraContext.Categorias.ToListAsync();

        }
    }
}
