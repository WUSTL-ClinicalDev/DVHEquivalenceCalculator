using DoseEquivalency.Models;
using Newtonsoft.Json;
using OrderTemplates.Models;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;

namespace DoseEquivalency.ViewModels
{
    public class DoseMetricViewModel : BindableBase
    {
        private string logpath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Resources", "_MasterList.txt");
        public ObservableCollection<TemplateModel> OrderTemplates { get; private set; }
        public ObservableCollection<MetricEquivalentModel> Metrics { get; private set; }
        private TemplateModel selectedOrderTemplate;
        private PlanSetup _plan;

        public TemplateModel SelectedOrderTemplate
        {
            get { return selectedOrderTemplate; }
            set
            {
                SetProperty(ref selectedOrderTemplate, value);
                ReadFromTemplate();
            }

        }
        public DoseMetricViewModel(PlanSetup plan)
        {
            _plan = plan;
            OrderTemplates = new ObservableCollection<TemplateModel>();
            Metrics = new ObservableCollection<MetricEquivalentModel>();
            ReadLogFile();
        }
        private void ReadFromTemplate()
        {
            if (SelectedOrderTemplate != null)
            {
                var templatePath = Path.Combine(Path.GetDirectoryName(logpath), SelectedOrderTemplate.FilePath);
                var orderTempalte = JsonConvert.DeserializeObject<OrderTemplate>(File.ReadAllText(templatePath));
                foreach(var metric_structure in orderTempalte.DoseConstraints.GroupBy(x => x.StructureId))
                {
                    if(_plan.StructureSet.Structures.Any(x=>x.Id == metric_structure.Key))
                    {
                        var structure = _plan.StructureSet.Structures.FirstOrDefault(x => x.Id == metric_structure.Key);
                        foreach (var metric in metric_structure) 
                        {
                            //constraint types MAX, AVG, MIN, DOS, VOL
                            DoseValuePresentation dvp = DoseValuePresentation.Absolute;
                            VolumePresentation vp = VolumePresentation.Relative;
                            if(metric.Type == "VOL")
                            {
                                if(metric.ConstraintUnits != "cGy")
                                {
                                    dvp = DoseValuePresentation.Relative;
                                }
                                if(metric.ResultUnits == "cc")
                                {
                                    vp = VolumePresentation.AbsoluteCm3;
                                }
                            }
                            else
                            {
                                if (metric.ResultUnits != "cGy")
                                {
                                    dvp = DoseValuePresentation.Relative;
                                }
                                if(metric.ConstraintUnits == "cc")
                                {
                                    vp = VolumePresentation.AbsoluteCm3;
                                }
                            }
                            
                            var dvh = _plan.GetDVHCumulativeData(structure,
                                dvp,
                                vp,
                                1);
                            double metric_value = 0.0;
                            double eqd2_val = 0.0;
                            double bed_val = 0.0;
                            switch (metric.Type)
                            {
                                case "MAX":
                                    metric_value = dvh.MaxDose.Dose;
                                   // eqd2_val = (double)_plan.NumberOfFractions*metric_value/ 100.0 * (((double)ab + dperfx / 100.0) / ((double)ab + 2.0));
                                    break;
                                case "MIN":
                                    metric_value = dvh.MinDose.Dose;
                                    break;
                                case "AVG":
                                    metric_value = dvh.MeanDose.Dose;
                                    break;
                                case "DOS":
                                    metric_value = dvh.CurveData.LastOrDefault(x=>x.Volume>= metric.LevelDefinition).DoseValue.Dose;
                                    break;
                                case "VOL":
                                    metric_value = dvh.CurveData.FirstOrDefault(x => x.DoseValue.Dose >= metric.LevelDefinition).Volume;
                                    break;

                            }
                            Metrics.Add(new MetricEquivalentModel
                            {

                            });
                        }
                    }
                }
            }
        }
        private void ReadLogFile()
        {
            foreach (var line in File.ReadAllLines(logpath))
            {
                OrderTemplates.Add(new TemplateModel
                {
                    FilePath = line.Split('\t').First(),
                    TemplateName = line.Split('\t').Last()
                });
            }
        }
    }
}
