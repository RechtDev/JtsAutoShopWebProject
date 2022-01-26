using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JtsAutoShopWeb.Models
{
    public class TicketModel
    {
        public PersonModel CreatedBy { get; set; }
        public DateTime Reservation { get; set; }
        public string ProblemDescription { get; set; }
        public string Car { get; set; }
        public TechnicianModel AssignedTo { get; set; }
        public StatusModel.TicketState TicketStatus { get; set; }
        public string TicketId { get; internal set; }
    }
}
