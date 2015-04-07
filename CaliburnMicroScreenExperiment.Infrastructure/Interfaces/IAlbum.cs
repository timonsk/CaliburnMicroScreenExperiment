using System;
using System.Collections.ObjectModel;

namespace CaliburnMicroScreenExperiment.Infrastructure.Interfaces
{
    public interface IAlbum
    {
        Guid Id { get; set; }
        string Name { get; set; }
        ObservableCollection<IPhoto> Photos { get; set; }

        IPhoto Photo { get; set; }
        IPhoto GetPhoto(int id);
    }
}