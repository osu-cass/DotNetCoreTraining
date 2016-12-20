using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Dal
{
    public class BusinessProContext : DbContext
    {
        public BusinessProContext(DbContextOptions<BusinessProContext> options) : base(options) { }
       
        //TODO: Add Models here
        public DbSet<Room> Rooms { get; set; }

        //TODO: see https://docs.microsoft.com/en-us/ef/core/modeling/relationships#many-to-many
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
