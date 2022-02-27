using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JtsAutoShopWeb.Models
{
    [Keyless]
    public class StatusModel
    {
        public enum TicketState
        {
            Active,
            Closed,
            InProgress
        }


    }
}
