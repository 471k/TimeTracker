using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Shared.Models.Project;

namespace TimeTracker.Shared.Models.TimeEntry
{
    public record struct TimeEntryResponse(
        int Id,
        ProjectResponse Project,
        DateTime Start,
        DateTime? End
        );
}
