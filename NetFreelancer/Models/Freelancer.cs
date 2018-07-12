

using System.ComponentModel.DataAnnotations.Schema;

namespace NetFreelancer.Models
{
    public class Freelancer 
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string ServiceCategory { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string CV { get; set; }
        public string VideoUrl { get; set; }
        public string City { get; set; }

        public string Province   { get; set; }
        public string Country   { get; set; }

       [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }

    }
}