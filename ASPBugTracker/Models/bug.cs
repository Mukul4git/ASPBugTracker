using System.ComponentModel.DataAnnotations;

namespace ASPBugTracker.Models
{
    public class bug
    {

        public int Id { get; set; }

        public int StatusId     { get; set; }

        public int PriorityId { get; set; }

        [Required]
        public string Name { get; set; }



        [Required]
        public string Type { get; set; }
        [Required]
        public string Description { get; set; }

        public string Solution { get; set; }
        
        [Required]
        public string Creator { get; set; }

        //Parent model ref.
        public Status Status { get; set; }
        public Priority Priority { get; set; }


    }
}
