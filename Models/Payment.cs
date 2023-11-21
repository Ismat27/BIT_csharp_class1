using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wema.BIT.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public object formatDetails ()
        {
            return new
            {
                Id,
                Amount,
                UserId,
                UserFirstName = User.FirstName,
                UserLastName = User.LastName,
                UserEmail = User.Email,

            };
        }
    }
}
