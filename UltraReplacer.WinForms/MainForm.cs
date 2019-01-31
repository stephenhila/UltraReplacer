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
        }

        private void replacementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaseOptionsFactory<ReplaceOptions> optionsFactory = ReplaceOptionsFactory.GetInstance();

            foreach (var replacement in optionsFactory.GetOptions().Replacements)
            {
                richTextBoxMainText.Text = richTextBoxMainText.Text.Replace(replacement.OriginalText, replacement.ReplacementText);
            }
        }

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
