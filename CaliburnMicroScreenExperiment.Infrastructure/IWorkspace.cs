using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using CaliburnMicroScreenExperiment.Infrastructure.Interfaces;

namespace CaliburnMicroScreenExperiment.Infrastructure
{
    public class Workspace : IWorkspace
    {
        public Workspace(IEnumerable<ICaliburnControl> controls)
        {
            Controls = controls.ToList();
        }
        public List<ICaliburnControl> Controls { get; set; }

        public UserControl GetControl(string name)
        {
            if (name == null) throw new ArgumentNullException("name");
            var firstOrDefault = Controls.FirstOrDefault(c => c.ControlN.Equals(name));
            if (firstOrDefault != null)
                return firstOrDefault.Control;
            return null;
        }
    }

    public interface IWorkspace
    {
        List<ICaliburnControl> Controls { get; set; }
        UserControl GetControl(string name);
    }
}
