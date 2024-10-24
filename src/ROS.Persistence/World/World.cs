namespace ROS.Persistence
{
    public class World: IWorld
    {
        protected World()
        {

        }

        public int X { get; set; }
        public int Y { get; set; }
        public Facings Facing { get; set; }

        public static IWorld Create()
        {
            return new World();
        }
    }
}
