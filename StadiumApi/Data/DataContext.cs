﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using StadiumApi.Models;

namespace StadiumApi.Data
{
    public class DataContext : DbContext
    {
        #region Properties

        public DbSet<Visitor> Visitors { get; set; }

        #endregion

        #region ctor

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        #endregion

        #region Overriden Methods

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("Host=172.20.10.2;Port=8000;Database=stadiumdb;" +
                "Username=postgres;Password=postgres;");
        }

        #endregion
    }
}