using LocadoraLoca.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LocadoraLoca.Repository.Interfaces
{
    public interface ICategoriaRepository
    {
        Task<int> CreateAsync(Categoria categoria);
        Task<List<Categoria>> FindAllAsync();
    }
}