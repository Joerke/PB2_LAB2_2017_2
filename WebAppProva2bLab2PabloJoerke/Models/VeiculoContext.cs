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



        }

    }
}
