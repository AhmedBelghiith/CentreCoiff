using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infrastructure
{
    public class AMContext: DbContext
    {

        public DbSet<Client> Clients { get; set; }
        public DbSet<Prestataire> Prestataires { get; set; }
        public DbSet<Prestation> Prestations { get; set; }
        public DbSet<RDV> RDVs { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
              Initial Catalog=BeautyBelghithAhmed;MultipleActiveResultSets=true;Integrated Security=true") ;
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RDVConfiguration());



        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            //    // Pre-convention model configuration goes here
            configurationBuilder
                .Properties<string>()
                .HaveMaxLength(150);
        }



    }
}
