

namespace NetFreelancer.Models
{
    public class ServiceProvider : ApplicationUser
    {
        public string ServiceCategory { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string CV { get; set; }
        public string VideoUrl   { get; set; }
    }
}