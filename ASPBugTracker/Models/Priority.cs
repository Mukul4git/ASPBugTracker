using System.ComponentModel.DataAnnotations;

namespace ASPBugTracker.Models
{
    public class Priority
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }


    }
}
