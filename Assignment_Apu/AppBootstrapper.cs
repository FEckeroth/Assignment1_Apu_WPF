using Assignment_Apu.ViewModels;
using Caliburn.Micro;
using System.Collections.Generic;
using System.Windows;

namespace Assignment_Apu
{
    public class AppBootstrapper
        : BootstrapperBase
    {
        public AppBootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            var settings = new Dictionary<string, object>
        {
            { "SizeToContent", SizeToContent.Manual },
            { "WindowState" , WindowState.Normal }
        };

            DisplayRootViewFor<RootViewModel>(settings);
        }
    }
}
