using LocadoraLoca.Entity;
using LocadoraLoca.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraLoca.Repository
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private readonly LocadoraContext _locadoraContext;

        public VeiculoRepository(LocadoraContext locadoraContext)
        {
            _locadoraContext = locadoraContext;
        }

        public async Task<int> CreateAsync(Veiculo veiculo)
        {
            _locadoraContext.Veiculos.Add(veiculo);

            await _locadoraContext.SaveChangesAsync();

            return veiculo.IdVeiculo;
        }

        public async Task<List<Veiculo>> FindAllAsync()
        {
            return await _locadoraContext.Veiculos.ToListAsync();
        }
    }
}
