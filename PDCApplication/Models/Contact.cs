using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDCApplication.Models
{
    public class Contact
    {
        public string ContactId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Deal> Deals { get; set; }
    }
}
