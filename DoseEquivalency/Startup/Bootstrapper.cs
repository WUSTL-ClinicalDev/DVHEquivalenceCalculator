using Autofac;
using DoseEquivalency.ViewModels;
using DoseEquivalency.Views;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.TPS.Common.Model.API;

namespace DoseEquivalency.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap(Patient patient, Course course, PlanSetup plan)
        {
            var container = new ContainerBuilder();
            container.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();
            container.RegisterType<MainView>().AsSelf();
            container.RegisterType<MainViewModel>().AsSelf();
            container.RegisterType<StructureSelectionViewModel>().AsSelf();
            container.RegisterType<EQD2DVHViewModel>().AsSelf();
            container.RegisterType<BEDDVHViewModel>().AsSelf();
            container.RegisterType<DVHViewModel>().AsSelf();
            
            container.RegisterInstance(patient);
            container.RegisterInstance(course);
            container.RegisterInstance(plan);
            return container.Build();
        }
    }
}
