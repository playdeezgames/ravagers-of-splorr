using ROS.Model.World;

namespace Ravagers.Base
{
    internal abstract class InPlayDialog(IWorldModel model, IDialog? mainMenuDialog) : IDialog
    {
        protected readonly IWorldModel _model = model;
        protected readonly IDialog? _mainMenuDialog = mainMenuDialog;
        public abstract IDialog? Run();
    }
}