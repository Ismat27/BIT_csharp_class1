using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Wema.BIT.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public List<Payment> Payments { get; set; } = new List<Payment>();

        public Payment makePayement(decimal amount)
        {
            return new Payment()
            {
                UserId = this.Id,
                Amount = amount,
            };
        }
    }
}
