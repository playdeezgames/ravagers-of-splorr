using Ravagers.Base;

namespace Ravagers.Boilerplate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ravagers of SPLORR!!";
            IDialog? dialog = new TitleDialog();
            while (dialog != null)
            {
                dialog = dialog.Run();
            }
        }
    }
}
