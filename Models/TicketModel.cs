using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JtsAutoShopWeb.Models
{
    public partial class TicketModel
    {
#nullable disable

        public string ProblemDescription { get; set; }
        public string Car { get; set; }

      
        public TechnicianModel AssignedTo { get; set; }
        public StatusModel.TicketState TicketStatus { get; set; }
        
        
        [Key]
        public int TicketId { get; internal set; }
       
        public PersonModel CreatedBy { get; set; }
        public DateTime Reservation { get; set; }

    }
}
