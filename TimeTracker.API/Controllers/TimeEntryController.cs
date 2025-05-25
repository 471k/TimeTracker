using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TimeTracker.Shared.Models.TimeEntry;

namespace TimeTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TimeEntryController : ControllerBase
    {
        private readonly ITimeEntryService _timeEntryService;

        public TimeEntryController(ITimeEntryService timeEntryService)
        {
            _timeEntryService = timeEntryService;
        }

        [HttpGet]
        public async Task<ActionResult<List<TimeEntryResponse>>> GetAllTimeEntries()
        {
            
            return Ok(await _timeEntryService.GetAllTimeEntries());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TimeEntryResponse>> GetTimeEntryById(int id)
        {
            var result = await _timeEntryService.GetTimeEntryById(id);
            if(result is null)
            {
                return NotFound("TimeEntry with the given ID was not found.");
            }
            return Ok(result);
            
        }

        [HttpGet("project/{projectId}")]
        public async Task<ActionResult<List<TimeEntryResponse>>> GetTimeEntriesByProject(int projectId)
        {
            return Ok(await _timeEntryService.GetTimeEntriesByProject(projectId));
        }

        [HttpPost]
        public async Task<ActionResult<List<TimeEntryResponse>>> CreateTimeEntry(TimeEntryCreateRequest timeEntry)
        {
            return Ok(await _timeEntryService.CreateTimeEntry(timeEntry));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<TimeEntryResponse>>> UpdateTimeEntry(int id, TimeEntryUpdateRequest timeEntry)
        {
            var result = await _timeEntryService.UpdateTimeEntry(id, timeEntry);
            if(result is null)
            {
                return NotFound("TimeEntry with the given ID was not found.");
            }

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<TimeEntryResponse>>> DeleteTimeEntry(int id)
        {
            var result = await _timeEntryService.DeleteTimeEntry(id);
            if(result is null)
            {
                return NotFound("TimeEntry with the given ID was not found.");
            }

            return Ok(result);
        }

        [HttpGet("year/{year}")]
        public async Task<ActionResult<List<TimeEntryResponse>>> GetTimeEntriesByYear(int year)
        {
            return Ok(await _timeEntryService.GetTimeEntriesByYear(year));
        }

        [HttpGet("month/{month}/{year}")]
        public async Task<ActionResult<List<TimeEntryResponse>>> GetTimeEntriesByMonth(int month, int year)
        {
            return Ok(await _timeEntryService.GetTimeEntriesByMonth(month, year));
        }

        [HttpGet("day/{day}/{month}/{year}")]
        public async Task<ActionResult<List<TimeEntryResponse>>> GetTimeEntriesByDay(int day, int month, int year)
        {
            return Ok(await _timeEntryService.GetTimeEntriesByDay(day, month, year));
        }
    }
}
