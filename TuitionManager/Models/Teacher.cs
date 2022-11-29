using Microsoft.Build.Framework;

namespace TuitionManager.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required]
        public string firtName { get; set; }
        public string? lastName { get; set; }
        [Required]
        public string University { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string PhoneNo { get; set; }
        public string? Email { get; set; }
    }
}
