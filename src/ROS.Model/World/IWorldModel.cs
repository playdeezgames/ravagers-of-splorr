using ROS.Model.Avatar;
using ROS.Model.Enums;
using ROS.Persistence.Enums;

namespace ROS.Model.World
{
    public interface IWorldModel
    {
        IAvatarModel Avatar { get; }
        int X { get; }
        int Y { get; }
        Facings Facing { get; }
        void Turn(Turns turn);
        void Move(Moves move);
    }
}
