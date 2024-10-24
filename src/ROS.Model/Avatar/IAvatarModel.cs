using ROS.Model.Enums;
using ROS.Persistence.Enums;

namespace ROS.Model.Avatar
{
    public interface IAvatarModel
    {
        int X { get; }
        int Y { get; }
        Facings Facing { get; }
        void Turn(Turns turn);
        void Move(Moves move);
    }
}
