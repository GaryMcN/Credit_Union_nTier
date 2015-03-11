using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class CustomerModel
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }

        public CustomerModel(string firstName,
                             string surname,
                             string email,
                             string phone,
                             string address1,
                             string address2,
                             string city,
                             string county)
        {
            FirstName = firstName;
            Surname = surname;
            Email = email;
            Phone = phone;
            Address1 = address1;
            Address2 = address2;
            City = city;
            County = county;
        }
        public CustomerModel(int customerID,
                             string firstName,
                             string surname,
                             string email,
                             string phone,
                             string address1,
                             string address2,
                             string city,
                             string county)
        {
            CustomerID = customerID;
            FirstName = firstName;
            Surname = surname;
            Email = email;
            Phone = phone;
            Address1 = address1;
            Address2 = address2;
            City = city;
            County = county;
        }
    }
}
