using Ravagers.Base;
using Ravagers.Boilerplate;
using Ravagers.Constants;
using ROS.Model;
using Spectre.Console;

namespace Ravagers.InPlay
{
    internal class NeutralDialog(WorldModel worldModel, IDialog? mainMenuDialog) : InPlayDialog(worldModel, mainMenuDialog)
    {
        public override IDialog? Run()
        {
            AnsiConsole.Clear();
            AnsiConsole.MarkupLine($"Position: ({_model.X}, {_model.Y})");
            AnsiConsole.MarkupLine($"Facing: {_model.Facing}");
            var prompt = new SelectionPrompt<string>() { Title = Prompts.NowWhat };
            prompt.AddChoice(Choices.Move);
            prompt.AddChoice(Choices.Turn);
            prompt.AddChoice(Choices.GameMenu);
            return AnsiConsole.Prompt(prompt) switch
            {
                Choices.Move => new MoveDialog(_model, _mainMenuDialog),
                Choices.Turn => new TurnDialog(_model, _mainMenuDialog),
                Choices.GameMenu => new GameMenuDialog(_model, _mainMenuDialog),
                _ => throw new NotImplementedException()
            };
        }
    }
}