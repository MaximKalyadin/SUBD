using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Lab5.Models;

namespace Lab5
{
    public class SubdLab5DataBase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-GDNE8QD\MYSQLDATABASE;Initial Catalog=SubdLab5DataBase;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasIndex(c => c.Name);
            modelBuilder.Entity<Supplier>().HasIndex(c => c.Name_Organization);
            modelBuilder.Entity<Material>().HasIndex(c => c.Name_Material);
        }*/
        public virtual DbSet<Client> Clients { set; get; }
        public virtual DbSet<Service> Services { set; get; }
        public virtual DbSet<Material> Materials { set; get; }
        public virtual DbSet<Order> Orders { set; get; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
    }
}
