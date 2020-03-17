using DoseEquivalency.Models;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoseEquivalency.Events
{
    public class AddStructureEvent:PubSubEvent<StructureSelectionModel>
    {
    }
}
