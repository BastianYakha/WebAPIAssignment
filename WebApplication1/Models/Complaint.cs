namespace WebApplication1.Models
{
    public class Complaint
    {
        public string Id { get; set; }
        public Building ComplainerLocation { get; set; }
        public Building Location { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int categoryID {  get; set; }
        public string currentStatus { get; set; }
        public int status { get; set; }
        public DateTime lastUpdated { get; set; }

    }
}
