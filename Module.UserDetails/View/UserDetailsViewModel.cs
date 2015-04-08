using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using CaliburnMicroScreenExperiment.Infrastructure.Interfaces;

namespace Module.UserDetails.View
{
    public class UserDetailsViewModel : Screen
    {
        public IUser User { get; set; }

        public UserDetailsViewModel(IUser user)
        {
            User = user;
        }
    }
}
