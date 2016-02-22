namespace Twining
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using Twining.Commands;
    using Twining.Commands.Window;

    public static class WindowCommands
    {
        static WindowCommands()
        {
            WindowCommands.Close = new CloseCommand();
            WindowCommands.Maximize = new MaximizeCommand();
            WindowCommands.Minimize = new MinimizeCommand();
            WindowCommands.Restore = new RestoreCommand();
            WindowCommands.ShowSystemMenu = new ShowSystemMenuCommand();
        }

        public static ICommand Close { get; private set; }

        public static ICommand Maximize { get; private set; }

        public static ICommand Minimize { get; private set; }

        public static ICommand Restore { get; private set; }

        public static ICommand ShowSystemMenu { get; private set; }
    }
}
