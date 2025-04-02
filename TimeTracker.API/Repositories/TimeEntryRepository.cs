using TimeTracker.Shared.Entities;

namespace TimeTracker.API.Repositories
{
    public class TimeEntryRepository : ITimeEntryRepository
    {
        private static List<TimeEntry> _timeEntries = new List<TimeEntry>
        {
            new TimeEntry
            {
                Id = 1,
                Project = "Time Tracker App",
                End = DateTime.Now.AddHours(1)
            }
        };

        public List<TimeEntry> CreateTimeEntry(TimeEntry timeEntry)
        {
            _timeEntries.Add(timeEntry);
            return _timeEntries;
        }

        public List<TimeEntry> GetAllTimeEntries()
        {            
            return _timeEntries;
        }
    }
}
