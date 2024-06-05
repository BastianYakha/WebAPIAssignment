using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TenantController : Controller
    {
        public TenantHandler tenanthandler;

        [Authorize]
        public TenantController()
        {
            tenanthandler = new TenantHandler();
        }
        public IActionResult Index()
        {
            return View();
        }

        [Route("YKA/CreateTenant")]
        public async Task<string> CreateTenant([FromBody] Tenant tenant)
        {
            return await tenanthandler.insertTenant(tenant);
        }

        [Route("YKA/UpdateTenant")]
        public async Task<string> UpdateTenant([FromBody] Tenant tenant)
        {
            return await tenanthandler.updateAPTenant(tenant);
        }

        [Route("YKA/GetAllTenant")]
        public async Task<List<Tenant>> GetAllTenant()
        {
            return await tenanthandler.getAllTenants();
        }
    }
}
