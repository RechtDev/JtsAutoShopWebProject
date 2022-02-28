
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System;
using JtsAutoShopWeb.Database;
using JtsAutoShopWeb.Models;
using System.Linq;

namespace Practice1.Controllers
{
    public class TechnicianController : Controller
    {
        private readonly ILogger<TechnicianController> _logger;
        private readonly DatabaseContent _context;

        public TechnicianController(ILogger<TechnicianController> logger)
        {
            _logger = logger;
            //_context = context;
        }

        public TechnicianController(DatabaseContent context)
        {
            
            _context = context;
        }

        public IActionResult Technician()
        {
           // ViewData["Results"] = JoinDisplay();
           
            return View();
        }

        public IActionResult Technician(string filterby, bool? des)
        {
            List<TicketModel> Results = new List<TicketModel>();
            switch (filterby)
            {
                case "none":
                    Results = _context.Tickets.ToList();
                    break;
                case "prodname":
                    if (des == true)
                    {
                        Results = _context.Tickets.OrderByDescending(x => x.TicketStatus).ToList();
                        break;
                    }
                    else
                    {
                        Results = _context.Tickets.OrderBy(x => x.TicketStatus).ToList();
                        break;
                    }
                case "prodprice":
                    if (des == true)
                    {
                        Results = _context.Tickets.OrderByDescending(x => x.TicketStatus).ToList();
                        break;
                    }
                    else
                    {
                        Results = _context.Tickets.OrderBy(x => x.TicketStatus).ToList();
                        break;
                    }
                case "prodtype":
                    if (des == true)
                    {
                        Results = _context.Tickets.OrderByDescending(x => x.TicketStatus).ToList();
                        break;
                    }
                    else
                    {
                        Results = _context.Tickets.OrderBy(x => x.TicketStatus).ToList();
                        break;
                    }
                default:
                    Results = _context.Tickets.ToList();
                    break;
            }
            return View(Results);
        }


    }
}
