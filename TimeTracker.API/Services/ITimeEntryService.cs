using TimeTracker.Shared.Models;

namespace TimeTracker.API.Services
{
    public interface ITimeEntryService
    {
        List<TimeEntryResponse> GetAllTimeEntries();
        List<TimeEntryResponse> CreateTimeEntry(TimeEntryCreateRequest timeEntry);
    }
}
