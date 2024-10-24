using Ravagers.Base;
using ROS.Model;
using ROS.Model.Enums;

namespace Ravagers.InPlay
{
    internal class DoTurnDialog(WorldModel model, IDialog? mainMenuDialog, Turns turn) : InPlayDialog(model, mainMenuDialog)
    {
        private readonly Turns _turn = turn;

        public override IDialog? Run()
        {
            _model.Turn(_turn);
            return new NeutralDialog(_model, _mainMenuDialog);
        }
    }
}