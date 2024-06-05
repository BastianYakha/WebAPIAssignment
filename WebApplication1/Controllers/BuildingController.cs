using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BuildingController : Controller
    {
        [Authorize]
        public BuildingHandler buildingHandler;
        public BuildingController()
        {
            buildingHandler = new BuildingHandler();
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("YKA/CreateBuilding")]
        public async Task<string> CreateBuilding([FromBody] Building bd)
        {
            return buildingHandler.createBuilding(bd).ToString();
        }

        [Route("YKA/GetAllBuildings")]
        public async Task<List<Building>> GetAllBuildings()
        {
            return await buildingHandler.getAllBuildings();
        }
    }
}
