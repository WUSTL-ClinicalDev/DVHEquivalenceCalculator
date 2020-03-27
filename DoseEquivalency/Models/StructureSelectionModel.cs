using DoseEquivalency.Events;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoseEquivalency.Models
{
    public class StructureSelectionModel:BindableBase
    {
        public string StructureId { get; set; }
		private bool selected;

		public bool Selected
		{
			get { return selected; }
			set 
			{ 
				SetProperty(ref selected, value);
				if (Selected)
				{
					_eventAggregator.GetEvent<AddStructureEvent>().Publish(this);
				}
				else 
				{ 
					_eventAggregator.GetEvent<RemoveStructureEvent>().Publish(this); 
				}
			}
		}
		private double abRatio;
		private IEventAggregator _eventAggregator;

		public double ABRatio
		{
			get { return abRatio; }
			set { 
				SetProperty(ref abRatio, value);
				if (ABRatio!=0.0)
				{
					_eventAggregator.GetEvent<RemoveStructureEvent>().Publish(this);
					_eventAggregator.GetEvent<AddStructureEvent>().Publish(this);
				}
			}
		}
		public StructureSelectionModel(IEventAggregator eventAggregator)
		{
			_eventAggregator = eventAggregator;
		}

	}
}
