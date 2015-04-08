using Caliburn.Micro;
using CaliburnMicroScreenExperiment.Infrastructure;

namespace CaliburnMicroScreenExperiment.View
{
    public class ShellViewModel : Conductor<object>
    {
        public ShellViewModel(IWorkspace workspace)
        {
            _workspace = workspace;
           var control = _workspace.GetControl("UserDetailsView");
           ActivateItem(control.DataContext);

        }

        public override sealed void ActivateItem(object item)
        {
            base.ActivateItem(item);
        }

        private IWorkspace _workspace { get; set; }

    }
}