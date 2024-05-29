using WebApplication1.Models;

namespace WebApplication1
{
    public class InfrastructureHandler
    {
        /*
        public Tenant returnTenantOBJ()
        {
            Tenant newTenant = new Tenant();
            newTenant.Name = "Bastian";
            newTenant.Surname = "Baumann";

            return newTenant;
        }

        public Apartment returnApartmentOBJ()
        {
            Apartment newAP = new Apartment();
            newAP.Apartmentname = "E2";
            newAP.tenant = returnTenantOBJ();

            return newAP;
        }

        public Building returnBuildingOBJ()
        {
            Building newBD = new Building();
            newBD.Street = "new test Street";
            newBD.StreetNumber = 5;
            newBD.buildingApartments.Add(returnApartmentOBJ());
            newBD.buildingApartments.Add(returnApartmentOBJ());
            newBD.buildingApartments.Add(returnApartmentOBJ());
            newBD.buildingApartments.Add(returnApartmentOBJ());
            newBD.buildingApartments.Add(returnApartmentOBJ());
            newBD.buildingApartments.Add(returnApartmentOBJ());

            return newBD;
        }

        public Building thorBackBuilding(Building setBuilding)
        {
            DatabaseHandler dataHandler = new DatabaseHandler();
            dataHandler.InsertTenant()
            return setBuilding;
        }
        */

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
            complaint.Category = "Test";
            complaint.status = 1;

            return complaint;
        }

        public void InsertComplaint()
        {

        }
    }
}
