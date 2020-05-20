using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskItBlazorServer.Data
{
    public enum SprintType { Sprint1, Sprint2, Sprint3 }
    public enum Priority { Low, Medium, High}
    public class Sprint
    {
        public int SprintId { get; set; }
        public Guid OwnerId { get; set; }
        public string Name { get; set; }
        public int MyProperty { get; set; }
        public SprintType SprintType { get; set; }
        public Status SprintStatus { get; set; }
        public TimeSpan Estimation { get; set; }
        public Priority Priority { get; set; }
    }
}
