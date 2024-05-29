namespace WebApplication1.Models
{
    public class Building
    {
        public string Id { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public List<Apartment> buildingApartments {get; set;}

        public Building()
        {
            buildingApartments = new List<Apartment>();
        }
    }
}
