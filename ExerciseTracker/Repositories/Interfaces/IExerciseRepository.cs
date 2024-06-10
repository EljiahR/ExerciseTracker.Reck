namespace ExerciseTracker.Repositories.Interfaces
{
    public interface IExerciseRepository<T> : IDisposable
    {
        T GetExerciseById(int id);
        IEnumerable<T> GetAllExercises();
        void AddExercise(T exercise);
        void UpdateExercise(T exercise);
        void DeleteExercise(int id);
    }
}
