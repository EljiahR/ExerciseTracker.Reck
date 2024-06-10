using ExerciseTracker.Data;
using ExerciseTracker.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ExerciseTracker.Repositories
{
    public class ExerciseRepository<T> : IExerciseRepository<T> where T : class
    {
        private readonly ExerciseContext _context;
        private readonly DbSet<T> _dbSet;
        public ExerciseRepository(ExerciseContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public void AddExercise(T exercise)
        {
            _dbSet.Add(exercise);
            SaveChanges();
           
        }

        public void DeleteExercise(T exercise)
        {
            _dbSet.Remove(exercise);
            SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAllExercises()
        {
            return _dbSet.ToList();
        }

        public T GetExerciseById(int id)
        {
            return _dbSet.Find(id);
        }

        public void UpdateExercise(T exercise)
        {
            throw new NotImplementedException();
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
