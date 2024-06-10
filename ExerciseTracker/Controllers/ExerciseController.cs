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
        
        [HttpGet("{id}")]
        public IActionResult GetExerciseById(int id)
        {
            var exercise = _exerciseService.GetPushUpById(id);
            if (exercise == null)
            {
                return NotFound();
            }
            return Ok(exercise);
        }
        [HttpPost]
        public IActionResult PostExercise(PushUp pushUp)
        {
            try
            {
                _exerciseService.AddPushUp(pushUp);
                return Created();
            }
            catch (Exception ex) 
            {
                return BadRequest(ex);
            }
        }
    }
}
