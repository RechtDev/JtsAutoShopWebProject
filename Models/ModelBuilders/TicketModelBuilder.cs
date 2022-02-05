using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JtsAutoShopWeb.Models.ModelBuilders
{
    public class TicketModelBuilder
    {
        private TicketModel Ticket = new TicketModel();
        public TicketModelBuilder AddTicketDescription(string description)
        {
            Ticket.ProblemDescription = description;
            return this;
        }
        public TicketModelBuilder AddCarToBeServiced(string car)
        {
            Ticket.Car = car;
            return this;
        }
        public TicketModelBuilder AddDropOffTime(DateTime reservation)
        {
            Ticket.Reservation = reservation;
            return this;
        }
        public TicketModelBuilder AddCreator(PersonModel creator)
        {
            Ticket.CreatedBy = creator;
            return this;
        }
        public TicketModelBuilder AssignTechnicain()
        {
            //Todo
            //logic to assign tech
            return this;
        }
        public TicketModel Build()
        {
            Random randIDNum = new Random();
            Ticket.TicketId = randIDNum.Next(2000, 9012).ToString();
            return Ticket;
        }
    }
}
