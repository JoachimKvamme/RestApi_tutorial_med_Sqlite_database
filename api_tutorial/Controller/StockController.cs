using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_tutorial.Models;
using api_tutorial.Data;
using Microsoft.AspNetCore.Mvc;

namespace api_tutorial.Controller
{
    [Route("api/stock")]
    [ApiController]
    public class StockController : ControllerBase
    {   

        private readonly ApplicationDBContext _context;
        public StockController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll() {
            var stocks = _context.Stock.ToList();

            return Ok(stocks);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id) {
            var stock = _context.Stock.Find(id);

            if (stock == null) {
                return NotFound();
            }
            return Ok(stock);
        }
    }
}