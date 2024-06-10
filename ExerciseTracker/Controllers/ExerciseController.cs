using ExerciseTracker.Models;
using ExerciseTracker.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ExerciseTracker.Controllers
{
    public class ExerciseController : Controller
    {
        private readonly IExerciseRepository<PushUp> _exerciseRepository;
        public ExerciseController(IExerciseRepository<PushUp> exerciseRepository)
        {
            _exerciseRepository = exerciseRepository;
        }
        [HttpGet]
        public IActionResult GetExercises()
        {
            var exercises = _exerciseRepository.GetAllExercises();
            return Ok(exercises);
        }
    }
}
