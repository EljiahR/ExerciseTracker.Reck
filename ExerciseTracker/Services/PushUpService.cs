using ExerciseTracker.Models;
using ExerciseTracker.Repositories.Interfaces;
using ExerciseTracker.Services.Interfaces;

namespace ExerciseTracker.Services
{
    public class PushUpService : IExerciseService<PushUp>
    {
        private readonly IExerciseRepository<PushUp> _pushUpRepository;
        public PushUpService(IExerciseRepository<PushUp> pushUpRepository)
        {
            _pushUpRepository = pushUpRepository;
        }
        public void AddExercise(PushUp pushUp)
        {
            _pushUpRepository.AddExercise(pushUp);
        }
        public void DeleteExercise(PushUp pushUp)
        {
            _pushUpRepository.DeleteExercise(pushUp);
        }
        public void UpdateExercise(PushUp pushUp) 
        { 
            throw new NotImplementedException();
        }
        public PushUp GetExerciseById(int id)
        {
            return _pushUpRepository.GetExerciseById(id);
        }
        public IEnumerable<PushUp> GetAllExercises()
        {
            return _pushUpRepository.GetAllExercises();
        }
    }
}
