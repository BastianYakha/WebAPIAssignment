using WebApplication1.Models;

namespace WebApplication1
{
    public class InfrastructureHandler
    {
        public Complaint test()
        {
            Tenant tenant = new Tenant();
            tenant.Name = "Test";
            tenant.Surname = "Test";

            Apartment apartment = new Apartment();
            apartment.tenant = tenant;
            apartment.Apartmentname = "Test";

            Tenant tenant1 = new Tenant();
            tenant1.Name = "Test";
            tenant1.Surname = "Test";

            Apartment apartment1 = new Apartment();
            apartment1.tenant = tenant1;
            apartment1.Apartmentname = "Test";

            Building building = new Building();
            building.Street = "Test";
            building.StreetNumber = 1;
            building.buildingApartments.Add(apartment);

            Building building1 = new Building();
            building1.Street = "Test";
            building1.StreetNumber = 1;
            building1.buildingApartments.Add(apartment1);

            Complaint complaint = new Complaint();
            complaint.ComplainerLocation = building;
            complaint.Location = building1;
            complaint.Description = "test desc";
            complaint.Category = 2;
            complaint.status = 1;

            return complaint;
        }

        public void InsertComplaint()
        {

        }
    }
}
