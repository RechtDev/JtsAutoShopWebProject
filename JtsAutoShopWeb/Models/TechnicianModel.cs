using JtsAutoShopWeb.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JtsAutoShopWeb.Models
{
    public class TechnicianModel : PersonModel, ITicketActions
    {
        Queue<TicketModel> TicketsNeedToBeWorked { get; set; }
        List<TicketModel> AllTickets { get; set; }
        public string EmpId { get; }
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

        TicketModel ITicketActions.Create()
        {
            throw new NotImplementedException();
        }

        TicketModel ITicketActions.Delete()
        {
            throw new NotImplementedException();
        }

        void ITicketActions.Edit()
        {
            throw new NotImplementedException();
        }
    }
}
