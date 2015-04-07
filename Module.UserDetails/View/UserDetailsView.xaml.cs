using System.Windows.Controls;
using CaliburnMicroScreenExperiment.Infrastructure.Interfaces;

namespace Module.UserDetails.View
{
    public partial class UserDetailsView : ICaliburnControl
    {
        public UserDetailsView(UserDetailsViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
            ControlN = "UserDetailsView";
            Control = this;
        }

        public string ControlN { get; set; }

        public UserControl Control { get; set; }
    }
}