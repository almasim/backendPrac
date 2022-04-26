using Microsoft.AspNetCore.Mvc;
using coworker.Models;
using coworker.Services;
using System.Collections.Generic;

namespace coworker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CowokerController : Controller
    {
        private readonly CoworkerService coworkerService;
        public CowokerController(CoworkerService coworkerService)
        {
            this.coworkerService = coworkerService;
        }

        [HttpGet("")]
        public int GetAllWorker()
        {
            return coworkerService.GetAllWorker();

        }
        [HttpGet("email")]
        public Coworker GetStudentByEmail(string email)
        {
            return coworkerService.GetStudentByEmail(email);
        }
    }
}
