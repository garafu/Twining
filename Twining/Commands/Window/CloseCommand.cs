namespace Twining.Commands.Window
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Input;

    public class CloseCommand : CommandBase
    {
        public override void Execute(object parameter)
        {
            var window = parameter as Window;

            if (window == null)
            {
                return;
            }

            window.Close();
        }
    }
}
