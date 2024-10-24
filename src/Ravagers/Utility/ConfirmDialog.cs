using Ravagers.Base;
using Ravagers.Constants;
using Spectre.Console;

namespace Ravagers.Utility
{
    internal class ConfirmDialog : IDialog
    {
        private readonly string _prompt;
        private readonly IDialog? _yesDialog;
        private readonly IDialog? _noDialog;

        public ConfirmDialog(string prompt, IDialog? yesDialog, IDialog? noDialog)
        {
            _prompt = prompt;
            _yesDialog = yesDialog;
            _noDialog = noDialog;
        }

        public IDialog? Run()
        {
            AnsiConsole.Clear();
            var prompt = new SelectionPrompt<string>()
            {
                Title = _prompt
            };
            prompt.AddChoice(Choices.No);
            prompt.AddChoice(Choices.Yes);
            return AnsiConsole.Prompt(prompt) switch
            {
                Choices.No => _noDialog,
                _ => _yesDialog,
            };
        }
    }
}