using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UltraReplacer.Core.Factories;
using UltraReplacer.Core.Models;
using UltraReplacer.WPF.Commands;
using UltraReplacer.WPF.ViewModels;

namespace UltraReplacer.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindowViewModel model;

        public MainWindow()
        {
            model = new MainWindowViewModel();

            InitializeComponent();
            this.DataContext = model;
        }

        private void Command_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Command == FunctionCommands.Refresh)
            {
                throw new NotImplementedException();
            }
            else if (e.Command == FunctionCommands.ReplaceText)
            {
                ReplaceText();
            }
        }

        private void Command_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (e.Command == FunctionCommands.Refresh)
            {
#warning TODO SHA: Implement this 'command can execute'
                e.CanExecute = true;
            }
            else if (e.Command == FunctionCommands.ReplaceText)
            {
#warning TODO SHA: Implement this 'command can execute'
                e.CanExecute = true;
            }
        }

        #region Private Methods - Find a way to refactor these
        private void ReplaceText()
            {
            BaseOptionsFactory<ReplaceOptions> optionsFactory = ReplaceOptionsFactory.GetInstance();

            foreach (var replacement in optionsFactory.GetOptions().Replacements)
            {
                model.Text = model.Text.Replace(replacement.OriginalText, replacement.ReplacementText);
            }
        }

        #endregion
    }
}
