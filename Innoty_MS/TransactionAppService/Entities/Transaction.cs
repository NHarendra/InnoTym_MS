using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionAppService.Entities
{
    public class Transaction : BaseEntity
    {
        public int? UserId { get; set; } //should foriegn key from user table
        public int? RefId { get; set; } //should foriegn key from user table
        public string Transtype { get; set; }
        public DateTime? TransactionDate { get; set; }
        public decimal? InitialAmount { get; set; }
        public decimal? TransferAmount { get; set; }
    }
}
