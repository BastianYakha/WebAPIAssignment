using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.Models;
using Newtonsoft.Json;

namespace WebApplication1.Controllers
{
    public class BetterController : Controller
    {
        [Authorize]
        public DatabaseHandler dataHandler;
        public BetterController() 
        {
            dataHandler = new DatabaseHandler();
        }
        public IActionResult Index()
        {
            return View();
        }
        /*
        [Route("YKA/AssignmentRoute1")]
        public async Task<Building> AssignmentRoute1()
        {
            InfrastructureHandler IH = new InfrastructureHandler();
            return IH.returnBuildingOBJ();
        }


        [Route("YKA/AssignmentRoute2")]
        public async Task<Building> AssignmentRoute2([FromBody] Building setBuilding)
        {
            InfrastructureHandler IH = new InfrastructureHandler();
            return IH.thorBackBuilding(setBuilding);
        }

        [Route("YKA/TestinsertTenant")]
        public async Task<string> TestinsertTenant([FromBody] Tenant newT)
        {
            DatabaseHandler DH = new DatabaseHandler();
            return DH.InsertTenant(newT);

        }
        [Route("YKA/GetTenant")]
        [HttpPost]
        public async Task<Tenant> GetTenant([FromBody] Tenant newT)
        {
            DatabaseHandler DH = new DatabaseHandler();
            return await DH.GetTenant(newT);
        }


        [Route("YKA/CreateBuildingWithBDAndTenants")]
        public async Task<Building> CreateBuildingWithBDAndTenants([FromBody] Building setBuilding)
        {
            InfrastructureHandler IH = new InfrastructureHandler();
            return IH.thorBackBuilding(setBuilding);
        }

        [Route("YKA/CreateComplaint")]
        public async Task<Complaint> CreateComplaint([FromBody] Complaint newComplaint)
        {
            return newComplaint;
        }
        */
        [Route("YKA/CreateComplaint")]
        public async Task<Complaint> CreateComplaint()
        {
            InfrastructureHandler IH = new InfrastructureHandler();
            return IH.test();
        }

        [Route("YKA/returnComplaint")]
        public async Task<Complaint> returnComplaint([FromBody]Complaint comp)
        {
            return comp;
        }

        //InsertComplaint
        [Route("YKA/InsertNewComplaint")]
        public async Task<string> InsertNewComplaint([FromBody] Complaint comp)
        {
            return dataHandler.InsertComplaint(comp).ToString();
        }

        //UpdateComplaint
        [Route("YKA/UpdateComplaint")]
        public async Task<string> UpdateComplaint([FromBody] Complaint comp)
        {
            return dataHandler.UpdateComplaint(comp).ToString();
        }
    }
}
