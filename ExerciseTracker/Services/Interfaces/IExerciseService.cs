using ExerciseTracker.Models;

namespace ExerciseTracker.Services.Interfaces;

public interface IExerciseService<T>
{
    public void AddExercise(T exercise);
    public void DeleteExercise(T exercise);
    public void UpdateExercise(T exercise);
    public PushUp GetExerciseById(int id);
    public IEnumerable<T> GetAllExercises();
}
