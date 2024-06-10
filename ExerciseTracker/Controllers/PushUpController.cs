using ExerciseTracker.Models;
using ExerciseTracker.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ExerciseTracker.Controllers;

[ApiController]
[Route("[controller]")]
public class PushUpController : Controller
{
    private readonly IExerciseService<PushUp> _pushUpService;
    public PushUpController(IExerciseService<PushUp> exerciseService)
    {
        _pushUpService = exerciseService;
    }
    [HttpGet]
    public IActionResult GetPushUp()
    {
        var exercises = _pushUpService.GetAllExercises();
        return Ok(exercises);
    }

    [HttpGet("{id}")]
    public IActionResult GetPushUpById(int id)
    {
        var exercise = _pushUpService.GetExerciseById(id);
        if (exercise == null)
        {
            return NotFound();
        }
        return Ok(exercise);
    }
    [HttpPost]
    public IActionResult PostPushUp(PushUp pushUp)
    {
        try
        {
            _pushUpService.AddExercise(pushUp);
            return Created();
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }
}
