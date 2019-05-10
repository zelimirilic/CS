using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{   
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        //Retrieve one customer
        
        public Customer Retrieve(int customerId)
        {
            
            Customer customer =  new Customer(customerId);
            

            if(customerId == 1)
            {
                customer.EmailAddres = "zelimir.ilic@gmail.com";
                customer.FirstName = "Zelimir";
                customer.LastName = "Ilic";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }

        //Retrieve all customers
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }
        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
