using Mapster;
using TimeTracker.API.Repositories;
using TimeTracker.Shared.Entities;
using TimeTracker.Shared.Models;

namespace TimeTracker.API.Services
{
    public class TimeEntryService : ITimeEntryService
    {
        private readonly ITimeEntryRepository _timeEntryRepo;

        public TimeEntryService(ITimeEntryRepository timeEntryRepo)
        {
            _timeEntryRepo = timeEntryRepo;
        }

        public List<TimeEntryResponse> CreateTimeEntry(TimeEntryCreateRequest request)
        {
            //implementation without using Mapster extension
            /*var newEntry = new TimeEntry
            {
                Project = timeEntry.Project,
                Start = timeEntry.Start,
                End = timeEntry.End
            };*/

            //implementation using Mapster extension
            var newEntry = request.Adapt<TimeEntry>();

            var result = _timeEntryRepo.CreateTimeEntry(newEntry);

            //implementation without using Mapster extension
            /*return result.Select(t => new TimeEntryResponse 
            {
                Id = t.Id,
                Project = t.Project,
                Start = t.Start,
                End = t.End
            }).ToList();*/
            
            //implementation using Mapster extension
            return result.Adapt<List<TimeEntryResponse>>();
        }

        public List<TimeEntryResponse> DeleteTimeEntry(int id)
        {
            var result = _timeEntryRepo.DeleteTimeEntry(id);
            if(result is null)
            {
                return null;
            }
            return result.Adapt<List<TimeEntryResponse>>();
        }

        public List<TimeEntryResponse> GetAllTimeEntries()
        {
            var result = _timeEntryRepo.GetAllTimeEntries();

            //implementation without using Mapster extension
            /*return result.Select(t => new TimeEntryResponse{
                Id = t.Id,
                Project = t.Project,
                Start = t.Start,
                End = t.End
            }).ToList();*/

            //implementation using Mapster extension
            return result.Adapt<List<TimeEntryResponse>>();
        }

        public List<TimeEntryResponse> UpdateTimeEntry(int id, TimeEntryUpdateRequest request)
        {
            var updatedEntry = request.Adapt<TimeEntry>();
            var result = _timeEntryRepo.UpdateTimeEntry(id, updatedEntry);
            if(result is null)
            {
                return null;
            }

            return result.Adapt<List<TimeEntryResponse>>();
        }
    }
}
