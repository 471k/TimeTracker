using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Shared.Models
{
    public class TimeEntryResponse
    {
        public int Id { get; set; }
        public required string Project { get; set; }
        public DateTime Start { get; set; } = DateTime.Now;
        public DateTime? End { get; set; }
    }
}
