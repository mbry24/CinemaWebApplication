﻿using CinemaWebApplication.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebApplication.Core.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Filmshow> Filmshows { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Seat> Seats { get; set; }
    }
}
