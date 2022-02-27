using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JtsAutoShopWeb.Models
{[Keyless]
    public class TicketModel
    {
        
        public string ProblemDescription { get; set; }
        public string Car { get; set; }


        [NotMapped]
        public TechnicianModel AssignedTo { get; set; }
        public StatusModel.TicketState TicketStatus { get; set; }
        public string TicketId { get; internal set; }
        [NotMapped]
        public PersonModel CreatedBy { get; set; }
        public DateTime Reservation { get; set; }

    }
}
