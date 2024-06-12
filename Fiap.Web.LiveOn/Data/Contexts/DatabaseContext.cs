using Fiap.Web.LiveOn.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Fiap.Web.LiveOn.Data.Contexts
{
    public class DatabaseContext : DbContext
    {

        public DbSet<Montadora> Montadoras { get; set; }

        public DbSet<ModeloVeiculo> ModeloVeiculos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Montadora>( e =>
            {
                e.ToTable("MONTADORA");

                e.HasKey(e => e.MontadoraId);

                e.Property(e => e.Nome).IsRequired();
                e.Property(e => e.PaisOrigem).HasMaxLength(50);
                e.Property(e => e.AnoFundacao);

                e.HasIndex( e => e.Nome);

                e.HasIndex(e => new { e.PaisOrigem, e.AnoFundacao })
                    .HasName("IDX_PAIS_ANO");

            });


            modelBuilder.Entity<ModeloVeiculo>( e =>
            {
                e.ToTable("MODELOS");
                e.HasKey(e => e.ModeloVeiculoId);
                e.Property(e => e.NomeModelo);
                e.Property(e => e.AnoModelo);
                e.Property(e => e.TipoCombustivel);

                e.HasOne(e => e.Montadora)
                    .WithMany()
                    .HasForeignKey(e => e.MontadoraId)
                    .IsRequired();

            });


        }


        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        protected DatabaseContext()
        {
        }
    }
}
