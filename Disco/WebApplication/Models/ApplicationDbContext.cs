﻿using Microsoft.EntityFrameworkCore;
using WebApplication.Models.Timer;

namespace WebApplication.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<TimerActivity> TimerActivities { get; set; }
    }
}
