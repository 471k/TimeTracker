namespace TimeTracker.API.Repositories
{
    public interface ITimeEntryRepository
    {
        Task<TimeEntry?> GetTimeEntryById(int id);
        Task<List<TimeEntry>> GetAllTimeEntries();
        Task<List<TimeEntry>> CreateTimeEntry(TimeEntry timeEntry);
        Task<List<TimeEntry>> UpdateTimeEntry(int id, TimeEntry timeEntry);
        Task<List<TimeEntry>?> DeleteTimeEntry(int id);
        Task<List<TimeEntry>> GetTimeEntriesByProject(int projectId);
        Task<List<TimeEntry>> GetTimeEntriesByYear(int year);
        Task<List<TimeEntry>> GetTimeEntriesByMonth(int month, int year);
        Task<List<TimeEntry>> GetTimeEntriesByDay(int day, int month, int year);
    }
}
