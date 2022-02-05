using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JtsAutoShopWeb.Models
{
    public abstract class PersonModel
    {
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set 
            {
                if(value.Length == 0)
                {
                    throw new Exception("Last Name is too short.");
                }
                else if (value.Length > 10)
                {
                    throw new Exception("Last Name cannot be more than 10 characters long");
                }
                _lastName = value;
            }
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set 
            {
                if (value.Length == 0)
                {
                    throw new Exception("First Name is too short.");
                }
                else if (value.Length > 10)
                {
                    throw new Exception("First Name cannot be more than 10 characters long");
                }
                _firstName = value;
            }
        }

        public string TelNumber { get; set; }
        private string _email;

        public string Email
        {
            get { return _email; }
            set 
            {
                if (value.Length == 0)
                {
                    throw new Exception("Please enter a valid email");
                }
                else if (!value.Contains("@"))
                {
                    throw new Exception("Please enter a valid email");
                }
                _email = value;
            }
        }
    }
}
