using ExerciseTracker.Models;

namespace ExerciseTracker.Services.Interfaces
{
    public interface IExerciseService
    {
        public void AddPushUp(PushUp pushUp);
        public void DeletePushUp(PushUp pushUp);
        public void UpdatePushUp(PushUp pushUp);
        public PushUp GetPushUpById(int id);
        public IEnumerable<PushUp> GetAllPushUps();
    }
}
