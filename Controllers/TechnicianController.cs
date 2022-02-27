
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System;

namespace Practice1.Controllers
{
    public class TechnicianController : Controller
    {
        //private readonly DatabaseContent _context;
        private readonly ILogger<TechnicianController> _logger;

        public TechnicianController(ILogger<TechnicianController> logger)
        {
            _logger = logger;
            //_context = context;
        }

        public IActionResult Technician()
        {
           // ViewData["Results"] = JoinDisplay();
           
            return View();
        }

      
       

    }
}
