using LocadoraLoca.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraLoca.Repository
{
    public class LocadoraContext : DbContext
    {
        public LocadoraContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("locadoraloca");

            modelBuilder.Entity<Categoria>(e =>
            {
                e.ToTable("CATEGORIA");
                e.HasKey(p => p.IdCategoria);
                e.Property(p => p.Nome).HasColumnName("NOME");
                e.Property(p => p.DirecaoHidraulica).HasColumnName("DIRECAOHIDRAULICA");
                e.Property(p => p.QuantidadeAssentos).HasColumnName("QUANTIDADEASSENTOS");
                e.Property(p => p.Airbag).HasColumnName("AIRBAG");
                e.Property(p => p.PotenciaMotor).HasColumnName("POTENCIAMOTOR");
                e.Property(p => p.OffRoad).HasColumnName("OFFROAD");
                e.Property(p => p.ArCondicionado).HasColumnName("ARCONDICIONADO");
            });

            modelBuilder.Entity<Veiculo>(e =>
            {
                e.ToTable("VEICULO");
                e.HasKey(p => p.IdVeiculo);
                e.Property(p => p.Marca).HasColumnName("MARCA");
                e.Property(p => p.Modelo).HasColumnName("MODELO");
                e.Property(p => p.AnoModelo).HasColumnName("ANOMODELO");
                e.Property(p => p.AnoFabricacao).HasColumnName("ANOFABRICACAO");
                e.Property(p => p.Cor).HasColumnName("COR");
                e.Property(p => p.Placa).HasColumnName("PLACA");
                e.Property(p => p.Renavam).HasColumnName("RENAVAM");
                e.Property(p => p.Hodometro).HasColumnName("HODOMETRO");
                e.Property(p => p.IdCategoria).HasColumnName("IDCATEGORIA");
                e.HasOne(p => p.Categoria).WithMany(p => p.Veiculos).HasForeignKey(p => p.IdCategoria);
            });
        }

    }
}
