using Microsoft.AspNetCore.Mvc;
using Presentation.Services;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EventsController(EventService eventService) : ControllerBase
    {
    private readonly EventService _eventService = eventService;

    [HttpGet]
    public async Task<IActionResult> GetAllEvents()
        {
        var result = await _eventService.GetAllEventsAsync();
        return Ok(result);
        }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAll(string id)
        {
        var result = await _eventService.GetAsync(id);
        return result is null ? NotFound() : Ok(result);
        }


    }


