using Autofac;
using DoseEquivalency.Startup;
using DoseEquivalency.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using VMS.TPS.Common.Model.API;

namespace DoseEquivalency
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        private VMS.TPS.Common.Model.API.Application _esapiApp;
        private Patient _patient;
        private Course _course;
        private PlanSetup _plan;
        private MainView mv;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            this.ShutdownMode = ShutdownMode.OnMainWindowClose;
            try
            {
                _esapiApp = VMS.TPS.Common.Model.API.Application.CreateApplication();
                _patient = _esapiApp.OpenPatientById(e.Args.First().Split(';').First().Trim('\"'));
                _course = _patient.Courses.FirstOrDefault(x => x.Id == e.Args.First().Split(';').ElementAt(1));
                _plan = _course.PlanSetups.FirstOrDefault(x => x.Id == e.Args.First().Split(';').Last());
             }
            catch
            {
                _course = null;
                _plan = null;
            }
            var bootStrapper = new Bootstrapper();
            var container = bootStrapper.Bootstrap(_patient, _course,_plan);
            mv = container.Resolve<MainView>();
            mv.ShowDialog();            
        }
    }
}
