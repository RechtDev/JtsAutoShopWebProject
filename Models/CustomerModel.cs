﻿using JtsAutoShopWeb.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JtsAutoShopWeb.Models
{
    public class CustomerModel : PersonModel
    {
        [NotMapped]
        public List<TicketModel> Tickets { get; set; }

    }
}
