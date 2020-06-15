using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDCApplication.Models
{
    public class Deal
    {
        public string DealId { get; set; }
        public string Name { get; set; }
        public DateTime CloseDate { get; set; }
        public string Amount { get; set; }
        public string Status { get; set; }
        public Property Property { get; set; }
        public Contact Contact { get; set; }    
    }
}
