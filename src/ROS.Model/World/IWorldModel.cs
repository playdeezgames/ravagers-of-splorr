using ROS.Model.Avatar;

namespace ROS.Model.World
{
    public interface IWorldModel
    {
        IAvatarModel Avatar { get; }
    }
}
