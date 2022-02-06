﻿using JtsAutoShopWeb.Models;
using JtsAutoShopWeb.Models.Interfaces;
using JtsAutoShopWeb.Models.ModelBuilders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JtsAutoShopWeb.BLL
{
    public class TicketingCRUDRule : ITicketActions
    {//Business Logic
        //separate class to create, delete, edit proposal
        private PersonModel Person = null;
        private TicketModel Ticket = null;

        public IAuthorizeTicketActions Authorizer { get; set; } = null;

        //optional parameter
        public TicketingCRUDRule(string operation, PersonModel person = null, TicketModel ticket = null)
        {
            if (operation == "delete" || operation == "edit")
            {
                Authorizer = new AuthenticationForTicketRule();
            }
            Person = person;
            Ticket = ticket;
        }

        public TicketModel Create(TicketModel ticketToBeBuilt)
        {
            if (ticketToBeBuilt != null)
            {
                //Ticket = ticketToBeBuilt;
                var customer = (CustomerModel)ticketToBeBuilt.CreatedBy;
                customer.Tickets.Add(ticketToBeBuilt);
                ticketToBeBuilt.TicketStatus = StatusModel.TicketState.Active;
                //TODO add implentation for assigning ticket to avaialbe tech
                return ticketToBeBuilt;
            }
            else
            {
                //throw new Exception("Ticket invalid");
                return null;
            }
        }

        public TicketModel Delete()
        {
            if (Authorizer.IsAuthorzied(Ticket, Person))
            {
                //casting customer model and list of people
                var customer = (CustomerModel)Person;
                //TODO add status for tickets and List that holds active tickets and inactive tickets

                var tech = Ticket.AssignedTo;
                Ticket.TicketStatus = StatusModel.TicketState.Closed;
            }
            throw new Exception("This user is not authtorzied to delete this ticket");
        }

        public void Edit()
        {
            if (Authorizer.IsAuthorzied(Ticket, Person))
            {
                // edit from Ticket
            }
            throw new Exception("This user is not authtorzied to edit this ticket");
        }
    }
}
