using DoseEquivalency.Events;
using DoseMetrics.ViewModels;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoseEquivalency.ViewModels
{
    public class MainViewModel:BindableBase
    {
        //private int numberOfFractions;

        //public int NumberOfFractions
        //{
        //    get { return numberOfFractions; }
        //    set {
        //        SetProperty(ref numberOfFractions,value);
        //        _eventAggregator.GetEvent<UpdateNumberOfFractionsEvent>().Publish(NumberOfFractions);
        //    }
        //}

        public MainViewModel(StructureSelectionViewModel structureSelectionViewModel,
            EQD2DVHViewModel eqd2DVHViewModel,
            BEDDVHViewModel bedDVHViewModel,
            DVHViewModel dvhViewModel,
            DoseMetricSelectionViewModel doseMetricSelectionViewModel,
            DoseMetricViewModel doseMetricViewModel,
            IEventAggregator eventAggregator)
        {
            StructureSelectionViewModel = structureSelectionViewModel;
            EQD2DVHViewModel = eqd2DVHViewModel;
            BEDDVHViewModel = bedDVHViewModel;
            DVHViewModel = dvhViewModel;
            DoseMetricSelectionViewModel = doseMetricSelectionViewModel;
            DoseMetricViewModel = doseMetricViewModel;
            _eventAggregator = eventAggregator;
            //NumberOfFractions = 30;
        }

        public StructureSelectionViewModel StructureSelectionViewModel { get; }
        public EQD2DVHViewModel EQD2DVHViewModel { get; }
        public BEDDVHViewModel BEDDVHViewModel { get; }
        public DVHViewModel DVHViewModel { get; }
        public DoseMetricSelectionViewModel DoseMetricSelectionViewModel { get; }
        public DoseMetricViewModel DoseMetricViewModel { get; }

        private IEventAggregator _eventAggregator;
    }
}
