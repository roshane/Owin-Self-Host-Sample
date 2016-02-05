using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Owin_Self_Host_Sample.model;

namespace Owin_Self_Host_Sample.controller
{
    public class CustomerController : ApiController
    {
        [HttpGet, ActionName("customer")]
        public Customer GetCustomer()
        {
            var customer = new Customer()
            {
                Age = 25,
                Email = "roshanep@hsenidmobile.com",
                FirstName = "roshane",
                LastName = "perera"
            };
            return customer;
        }

        [HttpGet, ActionName("customers")]
        public List<Customer> GetAllCustomers()
        {
            var customers = new List<Customer>();
            Enumerable.Range(1, 10).ToList().ForEach((count) =>
             {
                 customers.Add(new Customer()
                 {
                     Age = Faker.RandomNumber.Next(10, 100),
                     Email = Faker.Internet.Email(),
                     FirstName = Faker.Name.First(),
                     LastName = Faker.Name.Last()
                 });
             });
            return customers;
        }
    }
}