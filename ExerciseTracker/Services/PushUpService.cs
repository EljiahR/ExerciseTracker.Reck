using ExerciseTracker.Models;
using ExerciseTracker.Repositories.Interfaces;
using ExerciseTracker.Services.Interfaces;

namespace ExerciseTracker.Services
{
    public class PushUpService : IExerciseService
    {
        private readonly IExerciseRepository<PushUp> _pushUpRepository;
        public PushUpService(IExerciseRepository<PushUp> pushUpRepository)
        {
            _pushUpRepository = pushUpRepository;
        }
        public void AddPushUp(PushUp pushUp)
        {
            _pushUpRepository.AddExercise(pushUp);
        }
        public void DeletePushUp(PushUp pushUp)
        {
            _pushUpRepository.DeleteExercise(pushUp);
        }
        public void UpdatePushUp(PushUp pushUp) 
        { 
            throw new NotImplementedException();
        }
        public PushUp GetPushUpById(int id)
        {
            return _pushUpRepository.GetExerciseById(id);
        }
        public IEnumerable<PushUp> GetAllPushUps()
        {
            return _pushUpRepository.GetAllExercises();
        }
    }
}
