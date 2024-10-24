using Ravagers.Base;
using Ravagers.Constants;
using Ravagers.Utility;
using Spectre.Console;

namespace Ravagers.Boilerplate
{
    internal class MainMenuDialog : IDialog
    {
        public IDialog? Run()
        {
            AnsiConsole.Clear();
            var prompt = new SelectionPrompt<string>()
            {
                Title = Prompts.MainMenu
            };
            prompt.AddChoice(Choices.Embark);
            prompt.AddChoice(Choices.Quit);
            return AnsiConsole.Prompt(prompt) switch
            {
                Choices.Embark => new EmbarkDialog(this),
                Choices.Quit => new ConfirmDialog(Prompts.ConfirmQuit, null, this),
                _ => this,
            };
        }
    }
}