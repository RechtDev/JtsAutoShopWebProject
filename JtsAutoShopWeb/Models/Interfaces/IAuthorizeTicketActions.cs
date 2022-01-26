using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JtsAutoShopWeb.Models.Interfaces
{
    public interface IAuthorizeTicketActions
    {
        bool IsAuthorzied(TicketModel ticket,PersonModel person);
    }
}
