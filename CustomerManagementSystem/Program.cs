using CustomerManagementSystemLibrary;
using CustomerManagementSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerManagementSystemLibrary.DataAccess;
using CustomerManagementSystemLibrary.Types;

namespace CustomerManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer john = new Customer("John", "Smith", new DateTime(1980, 1, 1), Gender.Male);
            Customer David = new Customer("David", "Smith", new DateTime(1974, 1, 1), Gender.Male);
            Customer meg = new Customer("Meg", "Brown", new DateTime(1988, 1, 1), Gender.Female);

            Customer lucy = new Customer("Lucy", "Johnson", new DateTime(1985, 1, 1), Gender.Female);
            var cms = new CMS(new Repository());
            cms.AddCustomer(john);
            cms.AddCustomer(David);
            cms.AddCustomer(meg);
            cms.AddCustomer(lucy);
            var allAges = cms.GetAverageAge();
            var femaleAges = cms.GetAverageAge(x => x.Gender == Gender.Female);
            var maleAges = cms.GetAverageAge(x => x.Gender == Gender.Male);
        }
    }
}
