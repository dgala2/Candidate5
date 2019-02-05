using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerManagementSystemLibrary.Models;

namespace CustomerManagementSystemLibrary.DataAccess
{
    public class Repository : IRepository
    {
        private List<Customer> _customer = new List<Customer>();
        public void AddCustomer(Customer customer)
        {
            _customer.Add(customer);
        }

        public Customer[] GetCustomers()
        {
            return _customer.ToArray();
        }
    }
}
