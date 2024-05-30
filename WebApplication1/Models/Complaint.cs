namespace WebApplication1.Models
{
    public class Complaint
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Building ComplainerLocation { get; set; }
        public Building Location { get; set; }
        public string Description { get; set; }
        public int Category { get; set; }
        public int status { get; set; }
        public DateTime created { get; set; }

    }
}
