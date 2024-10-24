using Ravagers.Base;
using Ravagers.Constants;
using ROS.Model;
using ROS.Model.Enums;
using ROS.Model.World;
using Spectre.Console;

namespace Ravagers.InPlay
{
    internal class MoveDialog(IWorldModel model, IDialog? mainMenuDialog) : InPlayDialog(model, mainMenuDialog)
    {
        public override IDialog? Run()
        {
            AnsiConsole.Clear();
            var prompt = new SelectionPrompt<string>() { Title = Prompts.Move };
            prompt.AddChoices(Choices.Cancel, Choices.Ahead, Choices.Right, Choices.Left, Choices.Back);
            return AnsiConsole.Prompt(prompt) switch
            {
                Choices.Cancel => new NeutralDialog(_model, _mainMenuDialog),
                Choices.Ahead => new DoMoveDialog(_model, _mainMenuDialog, Moves.Forward),
                Choices.Left => new DoMoveDialog(_model, _mainMenuDialog, Moves.Left),
                Choices.Right => new DoMoveDialog(_model, _mainMenuDialog, Moves.Right),
                Choices.Back => new DoMoveDialog(_model, _mainMenuDialog, Moves.Backward),
                _ => throw new NotImplementedException()
            };
        }
    }
}