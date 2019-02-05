using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerManagementSystemLibrary.Models;
using CustomerManagementSystemLibrary;

namespace CustomerManagementSystemTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddCustomer_To_CMS()
        {
            var customer = new Customer("John", "Smith", new DateTime(1980, 1, 1));
            var cms = new CMS();
            cms.AddCustomer(customer);
        }
    }
}
