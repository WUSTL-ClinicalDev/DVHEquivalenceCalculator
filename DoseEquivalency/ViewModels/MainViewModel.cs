using DoseEquivalency.Events;
using DoseMetrics.ViewModels;
using Prism.Commands;
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
    public class MainViewModel : BindableBase
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
        private PlanSetup selectedPlan;

        public PlanSetup SelectedPlan
        {
            get { return selectedPlan; }
            set
            {
                SetProperty(ref selectedPlan, value);
                LoadPlanCommand.RaiseCanExecuteChanged();
            }
        }
        public DelegateCommand LoadPlanCommand { get; set; }
        public ObservableCollection<PlanSetup> Plans { get; private set; }
        public MainViewModel(StructureSelectionViewModel structureSelectionViewModel,
            EQD2DVHViewModel eqd2DVHViewModel,
            BEDDVHViewModel bedDVHViewModel,
            DVHViewModel dvhViewModel,
            DoseMetricSelectionViewModel doseMetricSelectionViewModel,
            DoseMetricViewModel doseMetricViewModel,
            IEventAggregator eventAggregator,
            Course course,
            PlanSetup plan)
        {
            _course = course;
            _plan = plan;
            Plans = new ObservableCollection<PlanSetup>();
            //SetPlans();
            LoadPlanCommand = new DelegateCommand(OnLoadPlan, CanLoadPlan);
            StructureSelectionViewModel = structureSelectionViewModel;
            EQD2DVHViewModel = eqd2DVHViewModel;
            BEDDVHViewModel = bedDVHViewModel;
            DVHViewModel = dvhViewModel;
            DoseMetricSelectionViewModel = doseMetricSelectionViewModel;
            DoseMetricViewModel = doseMetricViewModel;
            _eventAggregator = eventAggregator;
            //NumberOfFractions = 30;
        }

        private void OnLoadPlan()
        {
            throw new NotImplementedException();
        }

        private bool CanLoadPlan()
        {
            throw new NotImplementedException();
        }

        private void SetPlans()
        {
            //foreach (var ps in _course.PlanSums)
            //{
            //    Plans.Add(ps as PlanningItem);
            //}
            //foreach (var ps in _course.PlanSetups)
            //{
            //    Plans.Add(ps as PlanningItem);
            //}
            //if (_plan != null)
            //{
            //    SelectedPlan = Plans.FirstOrDefault(x => x.Id == _plan.Id);
            //}
        }

        private Course _course;
        private PlanningItem _plan;

        public StructureSelectionViewModel StructureSelectionViewModel { get; }
        public EQD2DVHViewModel EQD2DVHViewModel { get; }
        public BEDDVHViewModel BEDDVHViewModel { get; }
        public DVHViewModel DVHViewModel { get; }
        public DoseMetricSelectionViewModel DoseMetricSelectionViewModel { get; }
        public DoseMetricViewModel DoseMetricViewModel { get; }

        private IEventAggregator _eventAggregator;
    }
}
