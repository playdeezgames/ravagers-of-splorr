using ROS.Persistence.Enums;

namespace ROS.Persistence.World
{
    public interface IWorld
    {
        int X { get; set; }
        int Y { get; set; }
        Facings Facing { get; set; }
    }
}
