using ROS.Persistence.World;

namespace ROS.Model.Avatar
{
    internal class AvatarModel: IAvatarModel
    {
        private readonly IWorld _world;
        internal AvatarModel(IWorld world)
        {
            _world = world;
        }
    }
}
