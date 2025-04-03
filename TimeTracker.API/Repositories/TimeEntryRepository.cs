

namespace TimeTracker.API.Repositories
{
    public class TimeEntryRepository : ITimeEntryRepository
    {
        private readonly DataContext _context;

        public TimeEntryRepository(DataContext context)
        {
            _context = context;
        }

        private static List<TimeEntry> _timeEntries = new List<TimeEntry>
        {
            new TimeEntry
            {
                Id = 1,
                Project = "Time Tracker App",
                End = DateTime.Now.AddHours(1)
            }
        };

        public async Task<List<TimeEntry>> CreateTimeEntry(TimeEntry timeEntry)
        {
             _context.TimeEntries.Add(timeEntry);
            await _context.SaveChangesAsync();


            return await _context.TimeEntries.ToListAsync();
        }

        public async Task<List<TimeEntry>?> DeleteTimeEntry(int id)
        {
            /*var entryToDelete = _timeEntries.FirstOrDefault(t => t.Id == id);
            if(entryToDelete == null)
            {
                return null;
            }

            _timeEntries.Remove(entryToDelete);
            return _timeEntries;*/

            var dbTimeEntry = await _context.TimeEntries.FindAsync(id);
            if(dbTimeEntry is null)
            {
                return null;
            }

            _context.TimeEntries.Remove(dbTimeEntry);
            await _context.SaveChangesAsync();

            return await GetAllTimeEntries();
        }

        public async Task<List<TimeEntry>> GetAllTimeEntries()
        {
            //return _timeEntries;
            return await _context.TimeEntries.ToListAsync();
        }

        public async Task<TimeEntry?> GetTimeEntryById(int id)
        {
            //return _timeEntries.FirstOrDefault(t => t.Id == id);

            var timeEntry = await _context.TimeEntries.FindAsync(id);

            return timeEntry;
        }

        public async Task<List<TimeEntry>?> UpdateTimeEntry(int id, TimeEntry timeEntry)
        {
            /*var entryToUpdateIndex = _timeEntries.FindIndex(t => t.Id == id);
            if (entryToUpdateIndex == -1)
            {
                return null;
            }
            _timeEntries [ entryToUpdateIndex ] = timeEntry;
            return _timeEntries;
                        */
            var dbTimeEntry = await _context.TimeEntries.FindAsync(id);

            if(dbTimeEntry is null)
            {
                return null;
            }
            dbTimeEntry.Project = timeEntry.Project;
            dbTimeEntry.Start = timeEntry.Start;
            dbTimeEntry.End = timeEntry.End;
            dbTimeEntry.DateUpdated = timeEntry.DateUpdated;

            await _context.SaveChangesAsync();

            return await GetAllTimeEntries();


        }
    }
}
