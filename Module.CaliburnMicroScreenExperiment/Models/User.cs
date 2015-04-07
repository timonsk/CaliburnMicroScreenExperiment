using System;
using System.Collections.ObjectModel;
using System.Linq;
using CaliburnMicroScreenExperiment.Infrastructure.Interfaces;
using Ninject;

namespace Module.CaliburnMicroScreenExperiment.Models
{
    public class User : IUser
    {
        public User()
        {
            Id = 12;
            Name = "Jack";
            Surname = "Holand";
            Albums = new ObservableCollection<IAlbum>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public ObservableCollection<IAlbum> Albums { get; set; }

        [Inject]
        public IAlbum Album { get; set; }

        public IAlbum GetDefaultAlbum()
        {
            return Album;
        }

        public IAlbum GetAlbum(Guid id)
        {
            var album = Albums.FirstOrDefault(a => a.Id.Equals(id));
            return album;
        }
    }
}