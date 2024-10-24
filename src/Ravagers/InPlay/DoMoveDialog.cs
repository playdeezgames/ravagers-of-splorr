using Ravagers.Base;
using Ravagers.Constants;
using ROS.Model;
using ROS.Model.Enums;
using ROS.Model.World;
using Spectre.Console;

namespace Ravagers.InPlay
{
    internal class DoMoveDialog(IWorldModel model, IDialog? mainMenuDialog, Moves move) : InPlayDialog(model, mainMenuDialog)
    {
        private readonly Moves _move = move;

        public override IDialog? Run()
        {
            AnsiConsole.Clear();
            _model.Avatar.Move(_move);
            AnsiConsole.MarkupLine($"You move {_move}.");
            var prompt = new SelectionPrompt<string>() { Title = string.Empty };
            prompt.AddChoice(Choices.Ok);
            return new NeutralDialog(_model, _mainMenuDialog);
        }
    }
}