using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimeTracker.API.Repositories;
using TimeTracker.API.Services;
using TimeTracker.Shared.Entities;
using TimeTracker.Shared.Models;

namespace TimeTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeEntryController : ControllerBase
    {
        private readonly ITimeEntryService _timeEntryService;

        public TimeEntryController(ITimeEntryService timeEntryService)
        {
            _timeEntryService = timeEntryService;
        }

        [HttpGet]
        public ActionResult<List<TimeEntryResponse>> GetAllTimeEntries()
        {
            return Ok(_timeEntryService.GetAllTimeEntries());
        }

        [HttpPost]
        public ActionResult<List<TimeEntryResponse>> CreateTimeEntry(TimeEntryCreateRequest timeEntry)
        {
            return Ok(_timeEntryService.CreateTimeEntry(timeEntry));
        }
    }
}
