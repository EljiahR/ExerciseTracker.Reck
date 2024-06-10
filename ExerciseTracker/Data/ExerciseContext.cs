using ExerciseTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace ExerciseTracker.Data
{
    public class ExerciseContext : DbContext
    {
        public ExerciseContext(DbContextOptions<ExerciseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<PushUp> PushUps { get; set; }
        
    }
}
