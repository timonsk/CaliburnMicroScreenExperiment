using CaliburnMicroScreenExperiment.Infrastructure.Interfaces;

namespace Module.CaliburnMicroScreenExperiment.Models
{
    public class Photo : IPhoto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}