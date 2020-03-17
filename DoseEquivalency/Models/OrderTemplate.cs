using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTemplates.Models
{
    public class OrderTemplate
    {
        public string Description { get; set; }
        public List<DoseConstraint> DoseConstraints { get; set; }
    }
}
