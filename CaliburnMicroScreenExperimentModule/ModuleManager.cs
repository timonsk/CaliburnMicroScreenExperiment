using CaliburnMicroScreenExperiment.Infrastructure.Interfaces;
using CaliburnMicroScreenExperimentModule.Models;
using Ninject.Modules;

namespace CaliburnMicroScreenExperimentModule
{
    public class ModuleManager : NinjectModule
    {
        public override void Load()
        {
            Bind<IUser>().To<User>();
            Bind<IAlbum>().To<Album>();
            Bind<IPhoto>().To<Photo>();
        }
    }
}