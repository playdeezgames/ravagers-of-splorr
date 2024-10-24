using Ravagers.Base;
using Ravagers.Constants;
using ROS.Model;
using ROS.Model.Enums;
using ROS.Model.World;
using Spectre.Console;

namespace Ravagers.InPlay
{
    internal class TurnDialog(IWorldModel model, IDialog? mainMenuDialog) : InPlayDialog(model, mainMenuDialog)
    {
        public override IDialog? Run()
        {
            AnsiConsole.Clear();
            var prompt = new SelectionPrompt<string>() { Title = Prompts.Turn };
            prompt.AddChoices(Choices.Cancel, Choices.Left, Choices.Right, Choices.Around);
            return AnsiConsole.Prompt(prompt) switch
            {
                Choices.Cancel => new NeutralDialog(_model, _mainMenuDialog),
                Choices.Left => new DoTurnDialog(_model, _mainMenuDialog, Turns.Left),
                Choices.Right => new DoTurnDialog(_model, _mainMenuDialog, Turns.Right),
                Choices.Around => new DoTurnDialog(_model, _mainMenuDialog, Turns.Around),
                _ => throw new NotImplementedException()
            };
        }
    }
}