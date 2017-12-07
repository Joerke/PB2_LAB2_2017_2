using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2PabloJoerke.Models
{
    public class VeiculoContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public VeiculoContext() : base("name=VeiculoContext")
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToOneConstraintIntroductionConvention>();

            modelBuilder.Entity<Cliente>()
                .HasOptional(end => end.Endereco)
                .WithRequired(cli => cli.Cliente)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Cliente>()
                .HasMany(loca => loca.Locacoes )
                .WithRequired(cli => cli.Cliente)
                .HasForeignKey(cli => cli.ClienteId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .Property(cli => cli.Nome)
                .HasColumnType("varchar")
                ..HasMaxLength(200);

            modelBuilder.Entity<Cliente>()
                .Property(cli => cli.Email)
                .HasColumnType("varchar")
                .HasMaxLength(200);

            ///////////////////////

            modelBuilder.Entity<Marca>()
                .HasMany(vei => vei.Veiculos)
                .WithRequired(mar => mar.Marca)
                .HasForeignKey(mar => mar.MarcaId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Marca>()
                .Property(mar => mar.Descricao)
                .HasColumnType("varchar")
                .HasMaxLength(200);

            /////////////////////

            modelBuilder.Entity<Veiculo>()
                 .Property(vei => vei.Descricao)
                 .HasColumnType("varchar")
                 .HasMaxLength(200);


            modelBuilder.Entity<Veiculo>()
                 .Property(vei => vei.Placa)
                 .HasColumnType("varchar")
                 .HasMaxLength(200);

            modelBuilder.Entity<Veiculo>()
                .HasMany(loc => loc.Locacoes);



            ///////////////////

            modelBuilder.Entity<Endereco>()
                .Property(end => end.Logradouro)
                .HasColumnType("varchar");

            modelBuilder.Entity<Endereco>()
               .Property(end => end.Bairro)
               .HasColumnType("varchar");

            modelBuilder.Entity<Endereco>()
               .Property(end => end.CEP)
               .HasColumnType("varchar");

            modelBuilder.Entity<Endereco>()
               .Property(end => end.Numero)
               .HasColumnType("varchar");

            /////////////////////////////////

            modelBuilder.Entity<Locacao>()
                .Property(loc => loc.DataLocacao)
                .HasColumnType("datetime2");

            modelBuilder.Entity<Locacao>()
                .HasMany(vei => vei.Veiculos)
                .WithRequired(loc => loc.Locacao)
                .HasForeignKey(loc => loc.locacaoId)
                .WillCascadeOnDelete(false);


              















        }

    }
}
