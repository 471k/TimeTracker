using System.Net;
using TimeTracker.Shared.Models;

namespace TimeTracker.API.Services
{
    public interface ITimeEntryService
    {
        List<TimeEntryResponse> GetAllTimeEntries();
        List<TimeEntryResponse> CreateTimeEntry(TimeEntryCreateRequest timeEntry);
        List<TimeEntryResponse> UpdateTimeEntry(int id, TimeEntryUpdateRequest timeEntry);
        List<TimeEntryResponse> DeleteTimeEntry(int id);
    }
}
