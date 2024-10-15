using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_tutorial.Models;
using api_tutorial.Data;

namespace api_tutorial.Controller
{
    [Route("api/stock")]
    [ApiController]
    public class StockController : ControllerBase
    {   
        private readonly ApplcationDbContext _context;
        public StockController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll() {
            var 
        }
    }
}