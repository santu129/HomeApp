
using Microsoft.EntityFrameworkCore;
using practice.Models;
using System;
using System.Collections.Generic;
using System.Text;




namespace HomeApp.Models
{
    public class DB_Entities : DbContext
    {
        public DB_Entities(DbContextOptions<DB_Entities> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HouseModel>()
      .Property(u => u.houseid)
      .ValueGeneratedOnAdd(); // Indicates that the value is generated on insert.

            modelBuilder.Entity<States>()
     .Property(u => u.StateID)
     .ValueGeneratedOnAdd();


            base.OnModelCreating(modelBuilder);
        }
        public DbSet<HouseModel> HouseInfo { get; set; }

        public DbSet<States> lstStates { get; set; }
        public DbSet<Districts> lstDistricts { get; set; }
        public DbSet<Villages> lstVillages { get; set; }
    }
}
