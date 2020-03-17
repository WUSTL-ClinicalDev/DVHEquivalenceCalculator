using DoseEquivalency.Models;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.TPS.Common.Model.API;

namespace DoseEquivalency.ViewModels
{
    public class StructureSelectionViewModel:BindableBase
    {
        private PlanSetup _plan;
        private IEventAggregator _eventAggregator;

        public ObservableCollection<StructureSelectionModel> SelectionStructures { get; private set; }
        public StructureSelectionViewModel(PlanSetup plan, IEventAggregator eventAggregator)
        {
            _plan = plan;
            _eventAggregator = eventAggregator;
            SelectionStructures = new ObservableCollection<StructureSelectionModel>();
            FillStructures();
        }

        private void FillStructures()
        {
            foreach(var s in _plan.StructureSet.Structures.Where(x=>x.DicomType!="MARKER" && x.DicomType != "SUPPORT"))
            {
                SelectionStructures.Add(new StructureSelectionModel(_eventAggregator)
                {
                    StructureId = s.Id,
                    ABRatio = s.DicomType.Contains("TV") ? 10.0 : 3.0,
                    Selected = false
                });
            }
        }
    }
}
