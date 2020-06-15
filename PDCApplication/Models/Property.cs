using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDCApplication.Models
{
    public class Property
    {
        public string PropertyId { get; set; }
        public string Name { get; set; }
        public string BldgSize { get; set; }
        public virtual ICollection<Deal> Deals { get; set; }
    }
}
