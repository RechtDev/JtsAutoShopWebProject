using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JtsAutoShopWeb.Models.Interfaces
{
    interface ITicketActions
    {
        internal IAuthorizeTicketActions Authorize { get; set; }
        TicketModel Create();
        TicketModel Delete();
        void Edit();
    }
}
