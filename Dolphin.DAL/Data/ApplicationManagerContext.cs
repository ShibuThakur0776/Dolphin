﻿using Dolphin.DAL.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dolphin.DAL.Data
{
    public class ApplicationManagerContext : IdentityDbContext<User, IdentityRole, string>
    {
        public ApplicationManagerContext(DbContextOptions<ApplicationManagerContext> options):base(options)
        {

        }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Agency> Agencies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tasks>().ToTable("Tasks");
            modelBuilder.Entity<Agency>().ToTable("Agencies");

            base.OnModelCreating(modelBuilder);
        }

    }
}

