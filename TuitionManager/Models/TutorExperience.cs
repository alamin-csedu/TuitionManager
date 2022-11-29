using System.ComponentModel.DataAnnotations.Schema;

namespace TuitionManager.Models
{
    public class TutorExperience
    {
        public int Id { get; set; }
        [ForeignKey("Teachers")]
        public int TutorID { get; set; }
        public string StudentClass { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public int ServiceYear { get; set; }

    }
}
