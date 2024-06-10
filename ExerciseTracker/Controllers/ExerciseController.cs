using ExerciseTracker.Models;
using ExerciseTracker.Repositories.Interfaces;
using ExerciseTracker.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ExerciseTracker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExerciseController : Controller
    {
        private readonly IExerciseService _exerciseService;
        public ExerciseController(IExerciseService exerciseService)
        {
            _exerciseService = exerciseService;
        }
        [HttpGet]
        public IActionResult GetExercises()
        {
            var exercises = _exerciseService.GetAllPushUps();
            return Ok(exercises);
        }
    }
}
