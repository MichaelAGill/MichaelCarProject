using CarProject.Models;

namespace CarProject.Models
{
    public class Car
    {
        public Enums.CarMake Make { get; set; }

        public string? Model { get; set; }

        public Enums.EngineSize EngineSize { get; set; }

        public float BaseCost { get; set; }

        public bool MetalicPaint { get; set; }

        public bool HeatedSeats { get; set; }

        public bool ReversingCamera { get; set; }

        public Car()
        {
        }
    }
}
