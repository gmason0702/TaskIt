using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskItBlazorServer.Data
{
    public enum Type { Sprint, Feature, Bug}
    public enum Status { Planning, Ongoing, OnHold, WaitingForReview, Completed}
    public class Task : Project
    {
        [Key]
        public int TaskId { get; set; }

        [Required]
        public Type TaskType { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        [Required]
        [StringLength(100, ErrorMessage ="Name must be under 100 characters.")]
        public string DeveloperName { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Status TaskStatus { get; set; }
        public string Comments { get; set; }
    }
}
