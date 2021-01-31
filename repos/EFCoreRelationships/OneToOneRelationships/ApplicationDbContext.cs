namespace OneToOneRelationships
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Passport> Passport { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=personsDb;Trusted_Connection=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Passport>()
                .HasOne(pa => pa.Person)
                .WithOne(pe => pe.Passport)
                .HasForeignKey<Person>(pe=>pe.PassportId);
        }
    }

}
