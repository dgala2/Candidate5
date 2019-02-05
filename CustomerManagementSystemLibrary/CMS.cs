using CustomerManagementSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CustomerManagementSystemLibrary.DataAccess;

namespace CustomerManagementSystemLibrary
{
    public class CMS
    {
        private IRepository _repository;
        public CMS(IRepository repository)
        {
            _repository = repository;
        }

        public void AddCustomer(Customer customer)
        {
            _repository.AddCustomer(customer);
        }

        public int GetAverageAge(Func<Customer, bool> ageFilter = null)
        {
            Func<Customer, bool> filter = ageFilter ?? delegate (Customer x) {
                return true;
            };
            var customers = _repository.GetCustomers();
            var averageYear = customers.Where(filter).Average(x => x.DateOfBirth.Year);
            var averageAge = DateTime.Now.Year - averageYear;
            return (int)averageAge;
        }
    }
}
