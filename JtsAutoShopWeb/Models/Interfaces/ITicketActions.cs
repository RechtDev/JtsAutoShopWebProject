using JtsAutoShopWeb.Models.ModelBuilders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JtsAutoShopWeb.Models.Interfaces
{
    interface ITicketActions
    {
        IAuthorizeTicketActions Authorizer { get; set; }
        TicketModel Create(TicketModel ticketToBeBuilt);
        TicketModel Delete();
        void Edit();
    }
}
