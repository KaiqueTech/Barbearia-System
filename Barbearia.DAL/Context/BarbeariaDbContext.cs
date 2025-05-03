
using Barbearia.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Barbearia.DAL.Context
{
    public class BarbeariaDbContext : DbContext
    {
        public DbSet<BarbeariaModel> Barbearias {get; set;}
        public DbSet<FuncionarioModel> Funcionarios {get; set;}
        public DbSet<ClienteModel> Clientes {get; set;}
        public DbSet<AgendamentoModel> Agendamentos {get; set;}

        public BarbeariaDbContext(DbContextOptions<BarbeariaDbContext> options) : base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<FuncionarioModel>()
                .HasKey(funcionario => funcionario.FuncionarioId);
            modelBuilder.Entity<BarbeariaModel>()
                .HasKey(barbearia => barbearia.BarbeariaId);
            modelBuilder.Entity<ClienteModel>()
                .HasKey(cliente => cliente.ClienteId);
            modelBuilder.Entity<AgendamentoModel>()
                .HasKey(agendamento => agendamento.AgendamentoId);
            modelBuilder.Entity<AgendamentoModel>()
                .HasOne(agendamento => agendamento.Cliente)
                .WithMany(cliente => cliente.Agendamentos)
                .HasForeignKey(agendamento => agendamento.ClienteId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<AgendamentoModel>()
                .HasOne(agendamento => agendamento.Funcionario)
                .WithMany(funcionario => funcionario.Agendamentos)
                .HasForeignKey(agendamento => agendamento.FuncionarioId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FuncionarioModel>()
                .HasOne(funcionario => funcionario.Barbearia)
                .WithMany(barbearia => barbearia.Funcionarios)
                .HasForeignKey(funcionario => funcionario.BarbeariaId)
                .OnDelete(DeleteBehavior.Restrict); 

            base.OnModelCreating(modelBuilder);
        }
    }
}