using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.Models;
using Newtonsoft.Json;

namespace WebApplication1.Controllers
{
    public class ComplaintController : Controller
    {
        [Authorize]
        public ComplaintHandler complaintHandler;
        public ComplaintController() 
        {
            complaintHandler = new ComplaintHandler();
        }
        public IActionResult Index()
        {
            return View();
        }

        //InsertComplaint
        [Route("YKA/InsertNewComplaint")]
        public async Task<string> InsertNewComplaint([FromBody] Complaint comp)
        {
            return complaintHandler.InsertComplaint(comp).ToString();
        }

        //UpdateComplaint
        [Route("YKA/UpdateComplaint")]
        public async Task<string> UpdateComplaint([FromBody] Complaint comp)
        {
            return complaintHandler.UpdateComplaint(comp).ToString();
        }

        //setComplaintActive
        [Route("YKA/setComplaintActive")]
        public async Task<string> setComplaintActive([FromQuery] string id)
        {
            return complaintHandler.ComplaintActive(id).ToString();
        }

        //closeComplaint
        [Route("YKA/closeComplaint")]
        public async Task<string> closeComplaint([FromQuery] string id)
        {
            return complaintHandler.closedComplaint(id).ToString();
        }

        //selectByDate
        [Route("YKA/selectByDate")]
        public async Task<List<Complaint>> selectByDate([FromQuery] DateTime date)
        {
            return await complaintHandler.selectComplaintByDate(date);
        }

        //selectByName
        [Route("YKA/selectByName")]
        public async Task<List<Complaint>> selectByName([FromQuery] string name)
        {
            return await complaintHandler.selectComplaintByName(name);
        }

        //GetAllComplaints
        [Route("YKA/GetAllComplaints")]
        public async Task<List<Complaint>> GetAllComplaints()
        {
            return await complaintHandler.selectAllComplaints();
        }
    }
}
