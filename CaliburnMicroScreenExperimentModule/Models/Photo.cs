using CaliburnMicroScreenExperiment.Infrastructure.Interfaces;

namespace CaliburnMicroScreenExperimentModule.Models
{
    public class Photo : IPhoto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}