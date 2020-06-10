using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class PlantShopDbContext : DbContext
    {
        public PlantShopDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Model.Environment> Environments { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
    }
}
