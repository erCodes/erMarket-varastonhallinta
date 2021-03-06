﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using erMarket_varastonhallinta_Dal.Dao.LogDbClasses;
using erMarket_varastonhallinta_Dal.Dao.ProductDbClasses;
using Microsoft.EntityFrameworkCore;


namespace erMarket_varastonhallinta_Dal.Dao
{
    public class Context : DbContext
    {
        public DbSet<DaoStore> Stores { get; set; }
        public DbSet<DaoCategories> ProductCategories { get; set; }
        public DbSet<LogData> ChangeLog { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=VarastonhallintaDb;Trusted_Connection=true;MultipleActiveResultSets=true");
        }
    }
}
