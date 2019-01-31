using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UltraReplacer.WPF.Commands
{
    public static class FunctionCommands
    {
        public static readonly RoutedUICommand Refresh
            = new RoutedUICommand("Refresh", "Refresh", typeof(FunctionCommands),
                                    new InputGestureCollection() { new KeyGesture(Key.F5) });
        public static readonly RoutedUICommand ReplaceText
            = new RoutedUICommand("ReplaceText", "ReplaceText", typeof(FunctionCommands));
        public static readonly RoutedUICommand ViewOptions
            = new RoutedUICommand("ViewOptions", "ViewOptions", typeof(FunctionCommands));
    }
}
