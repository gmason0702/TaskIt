using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskItBlazorServer.Data
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public Guid OwnerId { get; set; }

        [Required]
        [StringLength(400, ErrorMessage ="Name must be under 400 characters.")]

        public string Name { get; set; }

        [Required]
        [StringLength(200, ErrorMessage ="Project Manager must be under 200 characters.")]
        public string ProjectManager { get; set; }

        [StringLength(50, ErrorMessage ="Genre must be under 50 characters.")]
        public string Genre { get; set; }

        [Required]
        public DateTime StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan Duration
        {
            get
            {
                var taskDur = EndDate - StartDate;
                return taskDur;
            }
        }
        public bool IsDeliverable { get; set; }
        public bool IsOverdue
        {
            get
            {
                if (DueDate > EndDate)
                {
                    return true;
                }
                return false;
            }
        }


    }
}
