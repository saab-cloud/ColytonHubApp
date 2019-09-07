using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ColytonHubApp.DataAccessLayer.Models
{
    public class ColytonHubDbContext : DbContext
    {
        public DbSet<Child> Children { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<TalentCapacity> TalentCapacities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Language_Person> Language_People { get; set; }
        public DbSet<Language> Languages { get; set; }

        public ColytonHubDbContext(DbContextOptions<ColytonHubDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=HP-PC\SQLEXPRESS;Database=ColytonHubDb;Trusted_Connection=True");/* ;MultipleActiveResultSets=true");*/
            
            //optionsBuilder.UseSqlServer(@"Server=HP-PC\SQLEXPRESS;Database=ColytonHubDb;Trusted_Connection=True", b => b.MigrationsAssembly("ColytonHubApp.UI"));
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* use fluent API  for composite keys cuz no way to make them in Data Annotations*/
            modelBuilder.Entity<Language_Person>().HasKey(c => new { c.LanguageId, c.PersonId});

            //modelBuilder.Entity<Language_Person>().HasOne(m => m.Person)
            //.WithMany(m => m.Language_People)
            //.HasForeignKey(m => m.PersonId)
            //.OnDelete(DeleteBehavior.SetNull);

            //modelBuilder.Entity<Language_Person>().HasOne(m => m.Language)
            //.WithMany(m => m.Language_People)
            //.HasForeignKey(m => m.LanguageId)
            //.OnDelete(DeleteBehavior.SetNull);

            /*
            modelBuilder.Entity<Person>().HasOne(m => m.Country)
           .WithMany(m => m.Person)
           .HasForeignKey(m => m.CountryId)
           .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Person>().HasOne(m => m.TalentCapacity)
           .WithMany(m => m.Person)
           .HasForeignKey(m => m.TalentCapacityID)
           .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Person>().HasOne(m => m.Language)
           .WithMany(m => m.Person)
           .HasForeignKey(m => m.LanguageId)
           .OnDelete(DeleteBehavior.Restrict);*/
        }
    }
}
