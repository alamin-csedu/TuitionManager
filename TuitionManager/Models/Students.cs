using System.ComponentModel.DataAnnotations;
using TuitionManager.DbContext;

namespace TuitionManager.Models
{
    public class Students
    {
        public int ID { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Display(Name = "University/College")]
        public string Institution { get; set; }

        public enum Group { Science, Arts, Commerce }
        public string Department { get; set; }

    }

}