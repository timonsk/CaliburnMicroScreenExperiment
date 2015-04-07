using System.Windows;
using System.Windows.Controls;
using CaliburnMicroScreenExperiment.Infrastructure;
using CaliburnMicroScreenExperiment.Infrastructure.Interfaces;
using Ninject;


namespace CaliburnMicroScreenExperiment.View
{
    public class ShellViewModel : DependencyObject
    {
        public ShellViewModel(IWorkspace control)
        {
            _workspace = control;
            DisplayControl = _workspace.GetControl("UserDetailsView");
        }

        private IWorkspace _workspace { get; set; }
        public UserControl DisplayControl { get; set; }
    }
}