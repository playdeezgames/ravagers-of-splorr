using Ravagers.Base;
using Ravagers.Constants;
using Ravagers.InPlay;
using Ravagers.Utility;
using ROS.Model;
using ROS.Model.World;
using Spectre.Console;

namespace Ravagers.Boilerplate
{
    internal class GameMenuDialog(IWorldModel model, IDialog? mainMenuDialog) : InPlayDialog(model, mainMenuDialog)
    {
        public override IDialog? Run()
        {
            AnsiConsole.Clear();
            var prompt = new SelectionPrompt<string>() { Title = Prompts.GameMenu };
            prompt.AddChoices(Choices.ContinueGame, Choices.AbandonGame);
            return AnsiConsole.Prompt(prompt) switch
            {
                Choices.ContinueGame => new NeutralDialog(_model, _mainMenuDialog),
                Choices.AbandonGame => new ConfirmDialog(Prompts.ConfirmAbandon, _mainMenuDialog, this),
                _ => throw new NotImplementedException()
            };
        }
    }
}