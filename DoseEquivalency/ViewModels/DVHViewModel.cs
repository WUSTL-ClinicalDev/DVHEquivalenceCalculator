using DoseEquivalency.Events;
using DoseEquivalency.Models;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;

namespace DoseEquivalency.ViewModels
{
    public class DVHViewModel
    {
        private PlanSetup _plan;
        private IEventAggregator _eventAggregator;
        //private int _numberOfFractions;

        public PlotModel DVHPlotModel { get; private set; }
        public DVHViewModel(PlanSetup plan, IEventAggregator eventAggregator)
        {
            _plan = plan;
            _eventAggregator = eventAggregator;
            //_eventAggregator.GetEvent<UpdateNumberOfFractionsEvent>().Subscribe(OnUpdateFx);
            DVHPlotModel = new PlotModel
            {
                Title = "DVH"
            };
            _eventAggregator.GetEvent<AddStructureEvent>().Subscribe(OnAddStructure);
            _eventAggregator.GetEvent<RemoveStructureEvent>().Subscribe(OnRemoveStructure);
            AddAxes();
        }

        

        private void OnRemoveStructure(StructureSelectionModel structure)
        {
            var series_structure = DVHPlotModel.Series.FirstOrDefault(x => x.Title == structure.StructureId);
            if (series_structure != null)
            {
                DVHPlotModel.Series.Remove(series_structure);
                DVHPlotModel.InvalidatePlot(true);
            }
        }

        private void OnAddStructure(StructureSelectionModel structure)
        {
            var s = _plan.StructureSet.Structures.FirstOrDefault(x => x.Id == structure.StructureId);
            if (s != null)
            {
                var dvh = _plan.GetDVHCumulativeData(s,
                    DoseValuePresentation.Absolute,
                    VolumePresentation.Relative,
                    1);
                if (dvh != null)
                {
                    DVHPlotModel.Series.Add(CreateDVHSeries(dvh, s, structure.ABRatio));
                    DVHPlotModel.InvalidatePlot(true);
                }
            }
        }

        private OxyPlot.Series.Series CreateDVHSeries(DVHData dvh, Structure s, double ab)
        {
            var series = new LineSeries()
            {
                Title = s.Id,
                Color = OxyColor.FromArgb(s.Color.A, s.Color.R, s.Color.G, s.Color.B)
            };
            foreach (var dvh_point in dvh.CurveData)
            {
                //var dose_value = dvh_point.DoseValue.Dose;
                //var dperfx = dose_value / (double)_plan.NumberOfFractions;
                //var bed = dperfx / 100.0 * (1 + (dperfx / 100.0) / ab);
                series.Points.Add(new DataPoint(dvh_point.DoseValue.Dose/100.0, dvh_point.Volume));
            }
            return series;
        }

        private void AddAxes()
        {
            DVHPlotModel.Axes.Add(new LinearAxis
            {
                Title = "Dose [Gy]",
                Position = AxisPosition.Bottom
            });
            DVHPlotModel.Axes.Add(new LinearAxis
            {
                Title = "Volume [%]",
                Position = AxisPosition.Left
            });
        }
    }
}
