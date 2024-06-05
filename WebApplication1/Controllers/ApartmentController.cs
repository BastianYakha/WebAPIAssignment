using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ApartmentController : Controller
    {
        [Authorize]
        public ApartmentHandler apartmentHandler;
        public ApartmentController()
        {
            apartmentHandler = new ApartmentHandler();
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("YKA/CreateApartment")]
        public async Task<string> CreateApartment([FromBody] Apartment ap)
        {
            return await apartmentHandler.createApartment(ap);
        }

        [Route("YKA/GetAllApartments")]
        public async Task<List<Apartment>> GetAllApartments()
        {
            return await apartmentHandler.getAllApartments();
        }
    }
}
