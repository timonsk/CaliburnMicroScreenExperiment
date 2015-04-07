using CaliburnMicroScreenExperiment.Infrastructure.Interfaces;
using Module.CaliburnMicroScreenExperiment.Models;
using Ninject.Modules;

namespace Module.CaliburnMicroScreenExperiment
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