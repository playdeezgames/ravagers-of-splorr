using Ravagers.Base;
using Ravagers.InPlay;
using ROS.Model;

namespace Ravagers.Boilerplate
{
    internal class EmbarkDialog(IDialog? mainMenuDialog) : IDialog
    {
        private readonly IDialog? _mainMenuDialog = mainMenuDialog;

        public IDialog? Run()
        {
            return new NeutralDialog(WorldModel.Create(), _mainMenuDialog);
        }
    }
}