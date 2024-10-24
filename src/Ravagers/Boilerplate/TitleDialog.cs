using Ravagers.Base;
using Ravagers.Constants;
using Spectre.Console;

namespace Ravagers.Boilerplate
{
    internal class TitleDialog : IDialog
    {
        public IDialog? Run()
        {
            AnsiConsole.Clear();
            var figlet = new FigletText("Ravagers of SPLORR!!")
            {
                Color = Color.Fuchsia,
                Justification = Justify.Center
            };
            AnsiConsole.Write(figlet);
            AnsiConsole.MarkupLine("A Production of TheGrumpyGameDev");
            var prompt = new SelectionPrompt<string>()
            {
                Title = string.Empty
            };
            prompt.AddChoice(Choices.Ok);
            AnsiConsole.Prompt(prompt);
            return new MainMenuDialog();
        }
    }
}