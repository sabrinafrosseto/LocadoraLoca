using LocadoraLoca.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LocadoraLoca.Repository.Interfaces
{
    public interface IVeiculoRepository
    {
        Task<int> CreateAsync(Veiculo veiculo);
        Task<List<Veiculo>> FindAllAsync();
    }
}