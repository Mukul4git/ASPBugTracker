using System.ComponentModel.DataAnnotations;

namespace ASPBugTracker.Models
{
    public class bug
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string status { get; set; }

        [Required]
        public string type { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public string priority { get; set; }
        public string solution { get; set; }
        
        [Required]
        public string creator { get; set; }


    }
}
