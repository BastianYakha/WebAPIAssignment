namespace WebApplication1.Models
{
    public class Apartment
    {
        public string Id { get; set; }
        public string Apartmentname {get; set; }
        public Tenant tenant { get; set; }
    }
}
