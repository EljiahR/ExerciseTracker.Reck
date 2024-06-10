using ExerciseTracker.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ExerciseTracker.Repositories
{
    public class ExerciseRepository<T> : IExerciseRepository<T> where T : class
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;
        public ExerciseRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public void AddExercise(T exercise)
        {
            throw new NotImplementedException();
        }

        public void DeleteExercise(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAllExercises()
        {
            throw new NotImplementedException();
        }

        public T GetExerciseById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateExercise(T exercise)
        {
            throw new NotImplementedException();
        }
    }
}
