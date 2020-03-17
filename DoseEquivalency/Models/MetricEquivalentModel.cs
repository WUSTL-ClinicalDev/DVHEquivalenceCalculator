using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoseEquivalency.Models
{
    public class MetricEquivalentModel
    {
        public string Metric { get; set; }
        public double Value { get; set; }
        public double EQD2 { get; set; }
        public double BED { get; set; }
    }
}
