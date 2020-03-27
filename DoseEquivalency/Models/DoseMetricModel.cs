using DoseEquivalency.Models;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;

namespace DoseMetrics.Models
{
    public class DoseMetricModel : BindableBase
    {
        public string Structure { get; set; }
        public string Metric { get; set; }
        public double InputValue { get; set; }
        public List<string> InputUnits { get; set; }

        private string inputUnit;

        public string InputUnit
        {
            get { return inputUnit; }
            set { SetProperty(ref inputUnit, value); }
        }

        public List<string> OutputUnits { get; set; }
        private string outputUnit;
        public string OutputUnit
        {
            get { return outputUnit; }
            set { SetProperty(ref outputUnit, value); }
        }
        private double abRatio;

        public double ABRatio
        {
            get { return abRatio; }
            set {SetProperty(ref abRatio,value); }
        }


        public double OutputValue { get; set; }
        public double OutputEQD2 { get; set; }
        public double OutputBED { get; set; }
        private string tolerance;

        public string Tolerance
        {
            get { return tolerance; }
            set { SetProperty(ref tolerance, value); }
        }

        public ToleranceEnum ToleranceMet { get; set; }
        private PlanSetup _plan;
        public DoseMetricModel(PlanSetup plan)
        {
            _plan = plan;
            ToleranceMet = ToleranceEnum.None;
        }

        internal void GetOutputValue()
        {
            //put methods here.
            if(_plan.StructureSet.Structures.FirstOrDefault(x => x.Id == Structure)==null)
            {
                OutputValue = -1.0;
                ToleranceMet = ToleranceEnum.None;
                return;
            }
            if (Metric == "Dose At Volume")
            {
                OutputValue = _plan.GetDoseAtVolume(_plan.StructureSet.Structures.FirstOrDefault(x=>x.Id == Structure),
                    InputValue,
                    InputUnit == "%" ? VolumePresentation.Relative : VolumePresentation.AbsoluteCm3,
                    OutputUnit == "%" ? DoseValuePresentation.Relative : DoseValuePresentation.Absolute).Dose;
                OutputValue = OutputValue / 100.0;
                if (ABRatio != 0.0 && OutputUnit != "%") 
                {
                    OutputEQD2 = OutputValue* ((ABRatio + (OutputValue/(double)_plan.NumberOfFractions)) / (ABRatio + 2.0));
                    OutputBED = OutputValue * (1 + (OutputValue / (double)_plan.NumberOfFractions) / ABRatio);
                }
            }
            else if (Metric == "Volume At Dose")
            {
                OutputValue = _plan.GetVolumeAtDose(_plan.StructureSet.Structures.FirstOrDefault(x => x.Id == Structure),
                    new DoseValue(InputUnit == "%"?InputValue:InputValue/100.0, (InputUnit == "%" ? DoseValue.DoseUnit.Percent : DoseValue.DoseUnit.cGy)),
                    OutputUnit == "%" ? VolumePresentation.Relative : VolumePresentation.AbsoluteCm3);
            }
            else { throw new ApplicationException("Could not determine metric"); }
            if (!String.IsNullOrEmpty(Tolerance))
            {
                if (Tolerance.Contains("<"))
                {
                    ToleranceMet = OutputValue < Convert.ToDouble(Tolerance.TrimStart('<')) ? ToleranceEnum.Pass : ToleranceEnum.Fail;
                }
                else if (Tolerance.Contains(">"))
                {
                    ToleranceMet = OutputValue > Convert.ToDouble(Tolerance.TrimStart('>')) ? ToleranceEnum.Pass : ToleranceEnum.Fail;
                }
                else if (Tolerance.Contains("="))
                {
                    ToleranceMet = OutputValue == Convert.ToDouble(Tolerance.TrimStart('=')) ? ToleranceEnum.Pass : ToleranceEnum.Fail;
                }
                else
                {
                    //no tolerance specified
                }
            }
        }
    }
}
