using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CaliburnMicroScreenExperiment.Infrastructure.Interfaces
{
    public interface ICaliburnControl
    {
        string ControlN { get; set; }
        UserControl Control { get; set; }
    }
}
