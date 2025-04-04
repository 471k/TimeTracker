using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Shared.Models
{
    public record struct TimeEntryUpdateRequest(
        string Project,
        DateTime Start,
        DateTime? End
        );
}
