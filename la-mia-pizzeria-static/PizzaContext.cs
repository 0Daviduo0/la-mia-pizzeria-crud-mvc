﻿using la_mia_pizzeria_static.Models;
using Microsoft.EntityFrameworkCore;

namespace la_mia_pizzeria_static
{
    public class PizzaContext : DbContext
    {
        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Ingredients> Ingredients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=BellaNapoliDB;Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}