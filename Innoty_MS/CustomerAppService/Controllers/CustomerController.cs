using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerAppService.Entities;
using CustomerAppService.Repo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CustomerAppService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        /* Global Variables*/
        private IRepository<Customer> CustomerRepository;
        private IConfiguration config;
        public CustomerController(
                IRepository<Customer> CustomerRepository,
                IConfiguration config
        )
        {
            this.CustomerRepository = CustomerRepository;
            this.config = config;
        }

        /************************************ Start all Curd logic from here **************************************************/

        [HttpGet]
        [Route("")]
        public IEnumerable<Customer> GetAllCustomers() => CustomerRepository.GetAll();

        [HttpGet]
        [Route("{CustomerId}")]
        public Customer GetCustomerById(int CustomerId) => CustomerRepository.GetById(CustomerId);

        [HttpPost]
        [Route("")]
        [AllowAnonymous]
        public void AddCustomer([FromBody] Customer Customer) => CustomerRepository.Insert(Customer);

        [HttpPut]
        [Route("")]
        [AllowAnonymous]
        public void UpdateCustomer([FromBody] Customer Customer) => CustomerRepository.Update(Customer);

        [HttpDelete]
        [Route("{CustomerId}")]
        [AllowAnonymous]
        public void DeleteCustomer(int CustomerId) => CustomerRepository.Delete(CustomerId);

        /************************************ End all Curd logic from here **************************************************/


    }
}
