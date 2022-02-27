using JtsAutoShopWeb.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JtsAutoShopWeb.Models
{
    public class CustomerModel : PersonModel
    {
        public List<TicketModel> Tickets { get; set; }

    }
}
