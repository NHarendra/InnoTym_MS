using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserAppService.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Phonenumber { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public decimal? Amount { get; set; }
        public bool IsAdmin { get; set; }
    }
}
