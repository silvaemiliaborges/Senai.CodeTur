using Microsoft.EntityFrameworkCore;
using Senai.CodeTur.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Senai.CodeTur.Infra.Data.Contextos {
    public class CodeTurContext : DbContext {

        public DbSet<UsuarioDominio> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS3TT;Initial Catalog=CodeTur;User ID=sa;Pwd=sa132");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<UsuarioDominio>().HasData(
                new UsuarioDominio()
                {
                    IdUsuario = 1,
                    Email = "fernando.guerra@sp.senai.br",
                    Senha = "senai132",
                    Tipo = "Administrador"
                }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
         