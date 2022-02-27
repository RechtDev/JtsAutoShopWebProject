using JtsAutoShopWeb.Models;
using JtsAutoShopWeb.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JtsAutoShopWeb.BLL
{
    public class AuthenticationForTicketRule : IAuthorizeTicketActions
    { 
        public bool IsAuthorzied(TicketModel ticket,PersonModel person)
        {
            if (person.LastName == ticket.CreatedBy.LastName && person.Email == ticket.CreatedBy.Email)
            {
                return true;
            }
            else if(person.LastName == ticket.AssignedTo.LastName && person.Email == ticket.AssignedTo.Email)
            {
                return true;
            }
            return false;
        }
    }
}
