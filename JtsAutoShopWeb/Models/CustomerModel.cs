using JtsAutoShopWeb.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JtsAutoShopWeb.Models
{
    public class CustomerModel : PersonModel, ITicketActions
    {
        public List<TicketModel> Tickets { get; set; }
        IAuthorizeTicketActions ITicketActions.Authorize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public TicketModel Create()
        {
            throw new NotImplementedException();
        }

        public TicketModel Delete()
        {
            throw new NotImplementedException();
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }
    }
}
