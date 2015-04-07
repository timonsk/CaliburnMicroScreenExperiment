using System.Windows;
using Ninject;

namespace CaliburnMicroScreenExperiment.View
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ShellView : Window
    {
        public ShellView(ShellViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
        }
    }
}