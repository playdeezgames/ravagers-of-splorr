using ROS.Model;

namespace Ravagers.Base
{
    internal abstract class InPlayDialog(WorldModel worldModel, IDialog? mainMenuDialog) : IDialog
    {
        protected readonly WorldModel _model = worldModel;
        protected readonly IDialog? _mainMenuDialog = mainMenuDialog;
        public abstract IDialog? Run();
    }
}