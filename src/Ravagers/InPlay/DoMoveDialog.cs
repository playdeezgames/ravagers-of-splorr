using Ravagers.Base;
using Ravagers.Constants;
using ROS.Model;
using Spectre.Console;

namespace Ravagers.InPlay
{
    internal class DoMoveDialog(WorldModel model, IDialog? mainMenuDialog, Moves move) : InPlayDialog(model, mainMenuDialog)
    {
        private readonly Moves _move = move;

        public override IDialog? Run()
        {
            AnsiConsole.Clear();
            _model.Move(_move);
            AnsiConsole.MarkupLine($"You move {_move}.");
            var prompt = new SelectionPrompt<string>() { Title = string.Empty };
            prompt.AddChoice(Choices.Ok);
            return new NeutralDialog(_model, _mainMenuDialog);
        }
    }
}