using ExerciseTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace ExerciseTracker.Data
{
    public class ExerciseContext : DbContext
    {
        public DbSet<PushUp> PushUps { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("exercise.db");
        }
    }
}
