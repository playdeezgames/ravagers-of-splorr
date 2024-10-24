namespace ROS.Persistence
{
    public interface IWorld
    {
        int X {  get; set; }
        int Y { get; set; }
        Facings Facing { get; set; }
    }
}
