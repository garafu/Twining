namespace Twining.Commands.Window
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Input;
    using Twining.Marshal;

    public class ShowSystemMenuCommand : CommandBase
    {
        public override void Execute(object parameter)
        {
            var window = parameter as Window;

            if (window == null)
            {
                return;
            }

            var position = User32.GetMousePosition();

            SystemCommands.ShowSystemMenu(window, position);
        }
    }
}
