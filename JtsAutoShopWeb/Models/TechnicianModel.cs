using JtsAutoShopWeb.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JtsAutoShopWeb.Models
{
    public class TechnicianModel : PersonModel
    {
        public List<TicketModel> AllTickets { get; set; }
        public string EmpId { get; }
    }
}
