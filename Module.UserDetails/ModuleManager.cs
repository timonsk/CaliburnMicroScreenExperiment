using CaliburnMicroScreenExperiment.Infrastructure.Interfaces;
using CaliburnMicroScreenExperiment;
using Module.UserDetails.View;
using Ninject.Modules;

namespace Module.UserDetails
{
    public class ModuleManager : NinjectModule
    {
        public override void Load()
        {
            Bind<UserDetailsViewModel>().ToSelf().InSingletonScope();
            Bind<ICaliburnControl>().To<UserDetailsView>().InSingletonScope();

        }
    }
}
