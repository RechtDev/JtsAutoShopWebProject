using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JtsAutoShopWeb.Models.ModelBuilders
{
    //Fluent Builder and Fuction to return itself with this
    //Build customer models(models) 
    public class CustomerModelBuilder
    {
        private CustomerModel Customer;
        public CustomerModelBuilder()
        {
            Customer = new CustomerModel();
        }
        public CustomerModelBuilder AddName(string fName, string lName)
        {
            Customer.FirstName = fName;
            Customer.LastName = lName;
            return this;
        }
        public CustomerModelBuilder AddEmail(string email)
        {
            Customer.Email = email;
            return this;
        }
        public CustomerModelBuilder AddPhoneNumber(string phoneNumber)
        {
            Customer.TelNumber = phoneNumber;
            return this;
        }
        public CustomerModel Build()
        {
            Customer.Tickets = new List<TicketModel>();
            return Customer;
        }
    }
}
