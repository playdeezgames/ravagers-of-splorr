using ROS.Persistence;

namespace ROS.Model
{
    public interface IWorldModel
    {
        int X { get; }
        int Y { get; }
        Facings Facing { get; }
        void Turn(Turns turn);
        void Move(Moves move);
    }
}
