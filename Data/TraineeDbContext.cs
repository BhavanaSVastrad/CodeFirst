using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using CodeFirst.Models;
using System.Collections.Generic;

namespace CodeFirst.Data
{
    public class TraineeDbContext : DbContext
    {
        public TraineeDbContext(DbContextOptions<TraineeDbContext> options) : base(options)
        {

        }

        public DbSet<Trainee> Trainees { get; set; }

    }
}