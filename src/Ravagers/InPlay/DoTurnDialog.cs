using Ravagers.Base;
using ROS.Model;
using ROS.Model.Enums;
using ROS.Model.World;

namespace Ravagers.InPlay
{
    internal class DoTurnDialog(IWorldModel model, IDialog? mainMenuDialog, Turns turn) : InPlayDialog(model, mainMenuDialog)
    {
        private readonly Turns _turn = turn;

        public override IDialog? Run()
        {
            _model.Avatar.Turn(_turn);
            return new NeutralDialog(_model, _mainMenuDialog);
        }
    }
}