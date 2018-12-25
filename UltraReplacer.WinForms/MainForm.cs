using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using UltraReplacer.Core.Factories;
using UltraReplacer.Core.Models;
using UltraReplacer.WinForms.Commands;

namespace UltraReplacer.WinForms
{
    public partial class MainForm : Form
    {
        public object CustomCommands { get; private set; }

        public MainForm()
        {
            InitializeComponent();

            // this is sooo hack...
            replacementsToolStripMenuItem.Tag = FunctionCommands.ReplaceText;
        }

        private void replacementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //BaseOptionsFactory<ReplaceOptions> optionsFactory = ReplaceOptionsFactory.GetInstance();

            //foreach (var replacement in optionsFactory.GetOptions().Replacements)
            //{
            //    richTextBoxMainText.Text = richTextBoxMainText.Text.Replace(replacement.OriginalText, replacement.ReplacementText);
            //}
            ICommand command = ((ToolStripItem)sender).Tag as ICommand;
            if (command != null)
            {
                command.Execute(null);
            }
        }

        private void Command_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Command == FunctionCommands.ReplaceText)
            {
                ReplaceText(richTextBoxMainText);
            }
        }

        private void Command_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (e.Command == FunctionCommands.Refresh)
            {
                throw new NotImplementedException();
            }
            else if (e.Command == FunctionCommands.ReplaceText)
            {
#warning TODO SHA: Implement: all event handlers use commands, that will enter Command_Executed event handler. This may make it easier to debug as more and more lines of code are added.
                throw new NotImplementedException();
            }
        }

#warning TODO SHA: See if you can decouple business-related logic from any UI references.
        #region Private Methods
        private void ReplaceText(TextBoxBase control)
        {
            BaseOptionsFactory<ReplaceOptions> optionsFactory = ReplaceOptionsFactory.GetInstance();

            foreach (var replacement in optionsFactory.GetOptions().Replacements)
            {
                control.Text = control.Text.Replace(replacement.OriginalText, replacement.ReplacementText);
            }
        }
        #endregion
    }
}
