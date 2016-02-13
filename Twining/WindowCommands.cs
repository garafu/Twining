namespace Twining
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Twining.Commands;

    public static class WindowCommands
    {
        static WindowCommands()
        {
            WindowCommands.Close = new DelegateCommand(CloseCommand_Executed);
            WindowCommands.Maximize = new DelegateCommand(MaximizeCommand_Executed);
            WindowCommands.Minimize = new DelegateCommand(MinimizeCommand_Executed);
            WindowCommands.Restore = new DelegateCommand(RestoreCommand_Executed);
            WindowCommands.ShowSystemMenu = new DelegateCommand(ShowSystemMenuCommand_Executed);
        }

        public static DelegateCommand Close { get; private set; }

        public static DelegateCommand Maximize { get; private set; }

        public static DelegateCommand Minimize { get; private set; }

        public static DelegateCommand Restore { get; private set; }

        public static DelegateCommand ShowSystemMenu { get; private set; }

        private static void CloseCommand_Executed(object parameter)
        {
            var window = parameter as System.Windows.Window;

            if (window == null)
            {
                return;
            }

            window.Close();
        }

        private static void MaximizeCommand_Executed(object parameter)
        {
            var window = parameter as System.Windows.Window;

            if (window == null)
            {
                return;
            }

            window.WindowState = System.Windows.WindowState.Maximized;
        }

        private static void MinimizeCommand_Executed(object parameter)
        {
            var window = parameter as System.Windows.Window;

            if (window == null)
            {
                return;
            }

            window.WindowState = System.Windows.WindowState.Minimized;
        }

        private static void RestoreCommand_Executed(object parameter)
        {
            var window = parameter as System.Windows.Window;

            if (window == null)
            {
                return;
            }

            window.WindowState = System.Windows.WindowState.Normal;
        }

        private static void ShowSystemMenuCommand_Executed(object parameter)
        {
            var window = parameter as System.Windows.Window;

            if (window == null)
            {
                return;
            }

            var position = Twining.Marshal.User32.GetMousePosition();

            System.Windows.SystemCommands.ShowSystemMenu(window, position);
        }
    }
}
