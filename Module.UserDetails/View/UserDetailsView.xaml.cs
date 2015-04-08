using System.Windows.Controls;
using CaliburnMicroScreenExperiment.Infrastructure.Interfaces;

namespace Module.UserDetails.View
{
    public partial class UserDetailsView : UserControl, ICaliburnControl
    {
        public UserDetailsView(UserDetailsViewModel viewModel)
        {
            DataContext = viewModel;
            InitializeComponent();
            ControlN = "UserDetailsView";
            Control = this;
        }

        public string ControlN { get; set; }

        public UserControl Control { get; set; }
    }
}