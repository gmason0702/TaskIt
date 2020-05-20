using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskItBlazorServer.Data
{
    public enum FeatureType { Prioritize, NewIdea}
    public enum FeatureStatus { Research, Design, Implementation, Complete}
    public enum Impact { Low, Medium, High}
    public class Feature
    {
        [Key]
        public int FeatureId { get; set; }
        public Guid OwnerId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage ="Feature name must be within 50 characters.")]
        public string Name { get; set; }

        [StringLength(1000, ErrorMessage ="Feature description must be within 1000 characters.")]
        public string Description { get; set; }
        public DateTime CreatedUtc { get; set; }
        public DateTime ModifiedUtc { get; set; }

        [Description("Amount of time spent on feature.")]
        public TimeSpan Effort { 
            get
            {
                var timeSpent = ModifiedUtc - CreatedUtc;
                return timeSpent;
            } }

        [Required]
        public FeatureType FeatureType { get; set; }

        [Required]
        public FeatureStatus FeatureStatus { get; set; }

        [Required]
        [Description("Potential impact on overall value of project")]
        public Impact Impact { get; set; }
    }
}
