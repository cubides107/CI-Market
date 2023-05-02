﻿using CreditApp.Domain.UserEntities;
using Microsoft.EntityFrameworkCore;

namespace CreditApp.Infrastructure.EF
{
    public class CreditAppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        readonly User UserAux = new("Admin", "Admin", "Admin@gmail.com", "356a192b7913b04c54574d18c28d46e6395428ab");

        public CreditAppContext(DbContextOptions<CreditAppContext> options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            UserAux.TypeUser = TypeUser.ADMIN;
            UserAux.Id = 1;
            modelBuilder.Entity<User>().HasData(UserAux);
        }
    }
}