using CustomerManagementSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystemLibrary.DataAccess
{
    public interface IRepository
    {
        void AddCustomer(Customer customer);
        Customer[] GetCustomers();
    }
}
