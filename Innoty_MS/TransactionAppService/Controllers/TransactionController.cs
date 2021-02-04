using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TransactionAppService.Entities;
using TransactionAppService.Repo;

namespace TransactionAppService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        /* Global Variables*/
        private IRepository<Transaction> TransactionRepository;
        private IConfiguration config;
        public TransactionController(
                IRepository<Transaction> TransactionRepository,
                IConfiguration config
        )
        {
            this.TransactionRepository = TransactionRepository;
            this.config = config;
        }

        /************************************ Start all Curd logic from here **************************************************/

        [HttpGet]
        [Route("")]
        public IEnumerable<Transaction> GetAllTransactions() => TransactionRepository.GetAll();

        [HttpGet]
        [Route("{TransactionId}")]
        public Transaction GetTransactionById(int TransactionId) => TransactionRepository.GetById(TransactionId);

        [HttpPost]
        [Route("")]
        [AllowAnonymous]
        public void AddTransaction([FromBody] Transaction Transaction) => TransactionRepository.Insert(Transaction);

        [HttpPut]
        [Route("")]
        [AllowAnonymous]
        public void UpdateTransaction([FromBody] Transaction Transaction) => TransactionRepository.Update(Transaction);

        [HttpDelete]
        [Route("{TransactionId}")]
        [AllowAnonymous]
        public void DeleteTransaction(int TransactionId) => TransactionRepository.Delete(TransactionId);

        /************************************ End all Curd logic from here **************************************************/

    }
}
