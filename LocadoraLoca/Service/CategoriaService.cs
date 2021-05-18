using LocadoraLoca.Entity;
using LocadoraLoca.Repository;
using LocadoraLoca.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraLoca.Service
{
    public class CategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public async Task<int> CreateAsync(Categoria categoria)
        {

           return await _categoriaRepository.CreateAsync(categoria);

        }

        public async Task<List<Categoria>> FindAllAsync()
        {
            return await _categoriaRepository.FindAllAsync();
        }
    }
}
