namespace ExerciseTracker.Repositories.Interfaces
{
    public interface IExerciseRepository<T>
    {
        T GetExerciseById(int id);
        IEnumerable<T> GetAllExercises();
        void AddExercise(T exercise);
        void UpdateExercise(T exercise);
        void DeleteExercise(T exercise);
        void SaveChanges();
    }
}
