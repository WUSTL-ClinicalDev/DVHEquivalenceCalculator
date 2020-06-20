using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Collections.Generic;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;
using System.Diagnostics;
using System.IO;

namespace VMS.TPS
{

    public class Script
    {

        public Script()
        {
        }

        public void Execute(ScriptContext context /*, System.Windows.Window window*/)
        {
            // TODO : Add here your code that is called when the script is launched from Portal Dosimetry
            try
            {
				if(context.PlanSetup!=null)
				{
					
                Process.Start(AppExePath(), String.Format("\"{0};{1};{2}\"",
                    context.Patient.Id,context.Course.Id,context.PlanSetup.Id));
				}
				else{
					Process.Start(AppExePath(), String.Format("\"{0};{1}\"",
                    context.Patient.Id,context.Course.Id,context.PlanSetupId));
				}
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to start application.");
            }
        }

        private string AppExePath()
        {
            return @"PathToEXEGoesHere";
        }
    }

}